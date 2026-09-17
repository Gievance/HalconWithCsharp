using HalconDotNet;
using HalconWithCsharp.Pipe3DMatching.Models;
using HalconWithCsharp.Pipe3DMatching.Tools;
using log4net;
using Log4netComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media;
using System.Xml.Linq;
namespace HalconWithCsharp.Pipe3DMatching
{
    public partial class PipeFrm : Form
    {
        public PipeFrm()
        {
            InitializeComponent();
        }

        private void PipeFrm_Load(object sender, EventArgs e)
        {
            Logger.RegistryLog();
            Logger.InitializeRichTextBox(rtbLog);
            Logger.Info("初始化项目完成");
            Logger.ModParamModify("修改日志节点初始化完成");

            hswm.HMoveContent = false;

            reg = new Register();
            prep = new PreProcess();
            groupBox2.Enabled = false;
        }
        #region
        VisualizeModel3D vistool = new VisualizeModel3D();

        HTuple Load_ObjectModel3d;

        #endregion

        #region 加载点云数据
        HTuple Pose_Load = new HTuple(0, 0, 0, 0, 0, 0);
        private void btn_LoadPoint_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "点云文件(.om3)|*.om3";
                ofd.InitialDirectory = $"{Path.Combine(Application.StartupPath + "om3")}";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filepath = ofd.FileName;

                    HOperatorSet.ReadObjectModel3d(filepath, 1, new HTuple(), new HTuple(), out Load_ObjectModel3d, out _);
                    Logger.Info("完成 — 读取参考点云");
                    Logger.Info($"参考点云:{filepath}");
                    // 设置配置参数
                    Last_ObjectModel3D = Load_ObjectModel3d;
                    HOperatorSet.HomMat3dIdentity(out Base_HomMat3DIdentity);
                    HomMat3DComp = Base_HomMat3DIdentity;
                    ObjectModel3DCollection.Append(Last_ObjectModel3D);

                    if (Load_ObjectModel3d != null)
                    {
                        vistool.hv_ExpDefaultWinHandle = hswm.HalconWindow;
                        vistool.Show3D(Load_ObjectModel3d, new HTuple(), new HTuple("lut", "disp_pose"), new HTuple("color1", "true"), out Pose_Load);

                    }

                }
            }

        }

        #endregion

        #region 退出收尾
        private void FrmClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否退出", "退出界面", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false; // 不取消 退出操作
            }
            else
            {
                e.Cancel = true; // 取消 退出操作
            }
        }

        private void FrmClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
        #endregion

        #region 配准操作
        Register reg;
        // 配准
        HTuple Last_ObjectModel3D;
        HTuple Base_HomMat3DIdentity;
        HTuple HomMat3DComp;
        HTuple ObjectModel3DCollection = new HTuple(); //收集所有3D对象模型
        HTuple HomMatCollection = new HTuple(); // 收集配准后的变换
        HTuple UnionObjectModel3D;
        string[] pair_files;
        int num_load_om3;
        private void btn_Register_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "点云文件(.om3)|*.om3";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    procGrid.SelectedObject = reg; // 显示配置参数
                    pair_files = ofd.FileNames;
                    num_load_om3 = pair_files.Length;

                    btn_exePair.Text = "执行配准";
                    
                }
            }
        }

        private void btn_exePair_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string text = btn.Text;

            switch (text)
            {
                case "执行配准":
                    Operator_Pair(); break;
                case "执行预处理":
                    Operator_PreProcess(); break;

                default:
                    throw new NotSupportedException($"功能 {text} 不支持操作");

            }
        }


        private void Operator_Pair()
        {
            Logger.Info("开始 执行 配准操作");
            int minpoint = reg.PointNum;
            float score = reg.MatchScore;
            int num = pair_files.Length; // 获取局部配准次数
            for (int idx = 1; idx < num; idx++)
            {   //读取相邻帧
                string path = pair_files[idx - 1][..^6] + $"{idx:D2}.om3";
                HOperatorSet.ReadObjectModel3d(path, 1, new HTuple(), new HTuple(), out HTuple Cur_ObjectModel3D, out _);
                // 点云筛选
                HOperatorSet.GetObjectModel3dParams(Cur_ObjectModel3D, "num_points", out var param_num_points);
                if (param_num_points < minpoint)
                {
                    continue;
                }
                // 局部配准
                string method = reg.method;
                string paramName = reg.GenParamName;
                string paramValue = reg.GenParamValue;
                HOperatorSet.RegisterObjectModel3dPair(Cur_ObjectModel3D, Last_ObjectModel3D, method, paramName, paramValue, out var hv_Pose1, out var hv_Score);

                if (hv_Score < score)
                {
                    continue;
                }
                HOperatorSet.PoseToHomMat3d(hv_Pose1, out var hv_HomMat3D);// 生成矩阵
                HOperatorSet.HomMat3dCompose(HomMat3DComp, hv_HomMat3D, out HomMat3DComp); // 组装矩阵
                HOperatorSet.AffineTransObjectModel3d(Cur_ObjectModel3D, HomMat3DComp, out var ObjectModel3DAffineTrans); // 当前帧坐标对齐

                // 用于全局配准               
                ObjectModel3DCollection.Append(Cur_ObjectModel3D);
                HomMatCollection.Append(hv_HomMat3D);

                // 更新当前帧
                Last_ObjectModel3D = Cur_ObjectModel3D;

            }

            // 进行全局配准
            HOperatorSet.RegisterObjectModel3dGlobal(ObjectModel3DCollection, HomMatCollection, "previous", new HTuple(), "max_num_iterations", 1, out var Global_HomMats3DOut, out var Global_Scores);
            HOperatorSet.AffineTransObjectModel3d(ObjectModel3DCollection, Global_HomMats3DOut, out var Global_ObjectModel3D);
            HOperatorSet.ClearWindow(hswm.HalconWindow);

            HOperatorSet.UnionObjectModel3d(Global_ObjectModel3D, "points_surface", out UnionObjectModel3D);
            PairedObjectModel3D = UnionObjectModel3D;

            Logger.Info("配准完成");
            groupBox2.Enabled = true;

            vistool.Show3D(UnionObjectModel3D, Pose_Load, new HTuple("lut"), new HTuple("color1"), out _);


        }
        #endregion

        #region 点云预处理
        HTuple PairedObjectModel3D;
        HTuple SampledObjectModel3D;
        HTuple TriangulatedObjectModel3D;
        PreProcess prep;

        private HTuple SampleConvert(string name, string value)
        {
            switch (name)
            {
                case "min_num_points":
                    return new HTuple(int.Parse(value));
                case "keep_normals":
                    return new HTuple(bool.Parse(value));
                case "keep_attributes":
                    return new HTuple(bool.Parse(value));
                default:
                    throw new NotSupportedException($"参数 {name} 不支持转换");
            }
        }
        private void btn_PreProcess_Click(object sender, EventArgs e)
        {
            Logger.Info("开始 3D对象预处理");
            procGrid.SelectedObject = null;
            // 子采样
            if (PairedObjectModel3D == null) return;

            procGrid.SelectedObject = prep;
            btn_exePair.Text = "执行预处理";

        }

        private void Operator_PreProcess()
        {
            // 获取采样参数
            string method = prep.sampleMethod;
            float dist = prep.sampleDistance;
            string paramn = prep.sampleParamName;
            var paramv = SampleConvert(paramn, prep.sampleParamValue);
            HOperatorSet.SampleObjectModel3d(PairedObjectModel3D, method, dist, paramn, paramv, out SampledObjectModel3D);

            // 平滑处理
            HOperatorSet.GetObjectModel3dParams(SampledObjectModel3D, "bounding_box1", out var hv_Box);
            HOperatorSet.GetObjectModel3dParams(SampledObjectModel3D, "center", out var hv_Center);
            HOperatorSet.HomMat3dIdentity(out var HomMat3DIdentity);
            HOperatorSet.HomMat3dTranslate(HomMat3DIdentity, -hv_Center[0].D, -hv_Center[1].D, -hv_Box[2].D, out var HomMat3DTranslate);
            HOperatorSet.AffineTransObjectModel3d(SampledObjectModel3D, HomMat3DTranslate, out var ObjectModel3DTrans);

            HOperatorSet.SmoothObjectModel3d(ObjectModel3DTrans, "mls", "mls_force_inwards", "true", out var SmoothObjectModel3D);

            HOperatorSet.HomMat3dInvert(HomMat3DTranslate, out var HomMat3DInvert);
            HOperatorSet.AffineTransObjectModel3d(SmoothObjectModel3D, HomMat3DInvert, out SmoothObjectModel3D);

            // 三角化
            HOperatorSet.TriangulateObjectModel3d(SmoothObjectModel3D, "greedy", new HTuple(), new HTuple(), out TriangulatedObjectModel3D, out _);

            Logger.Info("预处理执行完成");
            vistool.Show3D(TriangulatedObjectModel3D, Pose_Load, new HTuple("color"), new HTuple("white"), out _);
        }
        #endregion

        #region 创建表面模版
        HTuple SurfaceModelID;
        HTuple ObjectModel3DSelected;
        private void btn_createSurface_Click(object sender, EventArgs e)
        {
            

            HOperatorSet.ConnectionObjectModel3d(TriangulatedObjectModel3D, "mesh", 1, out var ObjectModel3DConnected);
            HOperatorSet.SelectObjectModel3d(ObjectModel3DConnected, new HTuple("has_triangles", "num_triangles"), "and", new HTuple(1, 20000), new HTuple(1, 30000), out ObjectModel3DSelected);

            if(ObjectModel3DSelected==null)
            {
                MessageBox.Show("未选中对象");
                return;
            }
            procGrid.SelectedObject = null;
            btn_exePair.Text = "功能";

            test_normal_direction(ObjectModel3DSelected, out var hv_InvertNormal);

            HOperatorSet.CreateSurfaceModel(ObjectModel3DSelected, 0.03, "model_invert_normals", hv_InvertNormal, out SurfaceModelID);
            Logger.Info("3D表面模版创建完成");
        }

        public void test_normal_direction(HTuple hv_ObjectModel3D, out HTuple hv_InvertNormal)
        {

            // Local iconic variables 

            // Local control variables 

            HTuple hv_Diameter = new HTuple(), hv_SampledObjectModel3D = new HTuple();
            HTuple hv_NX = new HTuple(), hv_NY = new HTuple(), hv_NZ = new HTuple();
            HTuple hv_X = new HTuple(), hv_Y = new HTuple(), hv_Z = new HTuple();
            HTuple hv_M = new HTuple(), hv_Test1 = new HTuple(), hv_Test2 = new HTuple();
            // Initialize local and output iconic variables 
            hv_InvertNormal = new HTuple();
            try
            {
                //Request the Diameter for estimating a reasonable  subsampling rate
                HOperatorSet.GetObjectModel3dParams(hv_ObjectModel3D, "diameter", out hv_Diameter);
                //Subsample the scene and compute the normals only for those few points
                HOperatorSet.SampleObjectModel3d(hv_ObjectModel3D, "fast_compute_normals",
                        hv_Diameter * 0.01, new HTuple(), new HTuple(), out hv_SampledObjectModel3D);
                //Request all normals and point values
                HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_normal_x",
                    out hv_NX);
                HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_normal_y",
                    out hv_NY);
                HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_normal_z",
                    out hv_NZ);
                HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_coord_x",
                    out hv_X);
                HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_coord_y",
                    out hv_Y);
                HOperatorSet.GetObjectModel3dParams(hv_SampledObjectModel3D, "point_coord_z",
                    out hv_Z);
                //Compute the mean point, which will be used as a virtual center
                HOperatorSet.MomentsObjectModel3d(hv_SampledObjectModel3D, "mean_points", out hv_M);
                //Calculate the distance of all points + and - their normals to the virtual center

                hv_Test1 = ((((((hv_X + ((hv_NX * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(
                    0))) * ((hv_X + ((hv_NX * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(0)))) + (((hv_Y + ((hv_NY * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(
                    1))) * ((hv_Y + ((hv_NY * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(1))))) + (((hv_Z + ((hv_NZ * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(
                    2))) * ((hv_Z + ((hv_NZ * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(2)))))).TupleMean()
                    ;
                hv_Test2 = ((((((hv_X - ((hv_NX * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(
                    0))) * ((hv_X - ((hv_NX * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(0)))) + (((hv_Y - ((hv_NY * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(
                    1))) * ((hv_Y - ((hv_NY * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(1))))) + (((hv_Z - ((hv_NZ * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(
                    2))) * ((hv_Z - ((hv_NZ * hv_Diameter) * 0.03)) - (hv_M.TupleSelect(2)))))).TupleMean()
                    ;
                // If Test2 is larger than Test1 the normals point to the center and have to be inverted for surface based matching
                if (hv_Test1 < hv_Test2)
                {
                    hv_InvertNormal = "true";
                }
                else
                {
                    hv_InvertNormal = "false";
                }

                return;

            }
            catch (HalconException HDevExpDefaultException)
            {
                throw HDevExpDefaultException;
            }
        }

        string[]? fp = null;
        private void btn_LoadMatching_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "点云文件(.om3)|*.om3";
                ofd.Multiselect = false;
                ofd.Title = $"当前已选中点云数为{num_load_om3}";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fp = ofd.FileNames;
                }
            }
            Logger.Info("加载 完成待匹配3D点云数据");
            btn_exePair.Text = "功能";
            procGrid.SelectedObject = null;
        }
        #endregion


        private void btn_exeSurfaceMatch_Click(object sender, EventArgs e)
        {
            if (fp != null && fp.Length > 0)
            {
                int num = fp.Length;
                for (int idx = 0; idx < num; idx++)
                {
                    string imgpath = fp[idx].Replace("om3","image")[..^5].Replace("xyz", "intensities")+ $"png";
                    HOperatorSet.ReadImage(out var ho_Image, imgpath);
                    // HOperatorSet.DispText(hswm.HalconWindow, fp[idx], "window", new HTuple(12), new HTuple(12), new HTuple("red"), new HTuple(), new HTuple());
                    HOperatorSet.ReadObjectModel3d(fp[idx], "m", new HTuple(), new HTuple(), out var ObjectModel3D, out _);

                    HOperatorSet.GetObjectModel3dParams(ObjectModel3D, "mapping_row", out var hv_rows);
                    HOperatorSet.GetObjectModel3dParams(ObjectModel3D, "mapping_col", out var hv_cols);
                    HOperatorSet.AccessChannel(ho_Image, out var ImageGray, 1);
                    HOperatorSet.GetGrayval(ImageGray, hv_rows, hv_cols, out var hv_Grayval);
                    HOperatorSet.SetObjectModel3dAttribMod(ObjectModel3D, "&gray", "points", hv_Grayval);
                    if (SurfaceModelID == null)
                    {
                        return;
                    }
                    HOperatorSet.FindSurfaceModel(SurfaceModelID, ObjectModel3D, 0.05, 0.2, 0, "false", new HTuple(), new HTuple(), out var Pose, out var Score, out var SurfaceMatchingResultID);
                    HOperatorSet.PoseToHomMat3d(Pose, out var HomMat3D1);
                    HOperatorSet.AffineTransObjectModel3d(ObjectModel3DSelected, HomMat3D1, out var ObjectModel3DAffineTrans);

                    //vistool.Show3D(new HTuple(ObjectModel3D, ObjectModel3DAffineTrans), new HTuple(), new HTuple("alpha_1", "color_0", "color_attrib_start", "color_attrib_end"), new HTuple(0.8, "green", 0, 255), out _);


                    HOperatorSet.DistanceObjectModel3d(ObjectModel3D,ObjectModel3DAffineTrans, new HTuple(), 0, "distance_to", "points");
                    HOperatorSet.GetObjectModel3dParams(ObjectModel3D, "&distance", out var hv_GenParamValue1);
                    HOperatorSet.SelectPointsObjectModel3d(ObjectModel3D, "&distance", 0, 2, out var ObjectModel3DTraget);
                    HOperatorSet.SelectPointsObjectModel3d(ObjectModel3D, "&distance", 2,100, out var ObjectModel3DBG);

                    Logger.Info("显示表面匹配结果");
                    vistool.Show3D(new HTuple(ObjectModel3DTraget, ObjectModel3DBG), new HTuple(),
                        new HTuple("color_1", "color_attrib_1", "color_attrib_0", "color_attrib_start_0", "color_attrib_end_0", "lut_0", "disp_background"),
                        new HTuple("blue", "&distance", "&distance", 2, -2, "color1", "true"),
                        out _);
                    HOperatorSet.DispText(hswm.HalconWindow, fp[idx], "window", new HTuple(12), new HTuple(12), new HTuple("red"), new HTuple(), new HTuple());



                }
            }
        }

        private void btn_validate_Click(object sender, EventArgs e)
        {
  
        }
    }
}
