using HalconDotNet;
using HalconWithCsharp.AdhesiveBead.MyControl;
using HalconWithCsharp.AdhesiveBead.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using HalconWithCsharp.AdhesiveBead.Models;

namespace HalconWithCsharp.AdhesiveBead
{
    public partial class Adhesivebead : Form
    {
        public Adhesivebead()
        {
            InitializeComponent();
            DisablePanel();
            LogTool.Initialize(logview);
            LogTool.Info("初始化胶路质量检测");
            probead.thickness = 14;
            probead.tolerance = 7;
            probead.pos_tolerance = 30;

            proBeanModel.SelectedObject = probead;

            hswm.MouseWheel += HSmartControl_MouseWheel;            

        }

        private void HSmartControl_MouseWheel(object sender, MouseEventArgs e)
        {
            hswm.HSmartWindowControl_MouseWheel(sender, e);
        }

        #region 变量
        HObject Ref_Image;
        HObject ho_TransImage;
        HObject ho_ImageReduced;
        HTuple hv_Rc, hv_Cc;
        HTuple hv_ModelID;
        HObject ho_Contour;
        HObject AlignedImage;
        bool isModeling = false;

        BeadModel probead = new BeadModel();
        HTuple hv_BeadInspectionModel;
        HObject ho_WidthContours;
        HTuple hv_Target_thick;
        HTuple hv_Position_tolerance;

        HObject ho_PositionContours;
        #endregion

        #region 方法
        void EnablePanel()
        {
            foreach (var c in panel.Controls.OfType<Button>())
            {
                c.Enabled = true;
            }
        }
        void DisablePanel()
        {
            foreach (var c in panel.Controls.OfType<Button>())
            {
                c.Enabled = false;
            }
        }
        void ShowMsg(string msg)
        {
            MessageBox.Show(msg, "提示");
        }
        void EnableAll()
        {
            foreach (var c in this.Controls.OfType<Button>())
            {
                c.Enabled = true;
            }
        }
        void DisableAll()
        {
            foreach (var c in this.Controls.OfType<Button>())
            {
                c.Enabled = false;
            }
        }
        #endregion

        private void btn_loadRefImage_Click(object sender, EventArgs e)
        {
            if (!isModeling)
            {
                string filePath = "";
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "图像文件|*.jpg;*.png";
                    ofd.Title = "请选择图像";
                    ofd.InitialDirectory = Application.StartupPath;
                    ofd.Multiselect = false;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        filePath = ofd.FileName;
                    }
                }
                try
                {
                    HOperatorSet.ReadImage(out Ref_Image, new HTuple(filePath));
                }
                catch (Exception ex)
                {
                    ShowMsg("未读取到图像");
                }
                hswm.HalconWindow.DispObj(Ref_Image);
                hswm.SetFullImagePart();
                LogTool.Info("加载参考图像" + filePath);
            }
            else
            {
                btn_loadDetImage_Click(null, null);
                EnablePanel();
            }


        }
        private void Adhesivebead_Load(object sender, EventArgs e)
        {
            LogTool.Info("初始化胶路质量检测 - 完成");
        }

        private void btn_getRefRegion_Click(object sender, EventArgs e)
        {
            hswm.HalconWindow.ClearWindow();
            int[] pxi = new int[]
            {
                659,300,316,694
            };
            HTuple Px = new HTuple(pxi);

            int[] pyi = new int[]
            {
                333,317,974,952
            };
            HTuple Py = new HTuple(pyi);
            HTuple hv_Qx = 400 + ((((new HTuple(3.4)).TupleConcat(0)).TupleConcat(0)).TupleConcat(3.4) * 100);
            HTuple hv_Qy = 400 + ((((new HTuple(0)).TupleConcat(0)).TupleConcat(6.12)).TupleConcat(6.12) * 100);
            try
            {
                HOperatorSet.VectorToProjHomMat2d(Px, Py, hv_Qx, hv_Qy, "normalized_dlt", new HTuple(), new HTuple(), new HTuple(), new HTuple(), new HTuple(), new HTuple(), out HTuple hv_HomMat2D, out HTuple hv_Covariance);
                HOperatorSet.ProjectiveTransImage(Ref_Image, out ho_TransImage, hv_HomMat2D, "bilinear", "false", "false");
            }
            catch (Exception ex)
            {
                ShowMsg("加载检测区域失败");
                LogTool.Info("加载检测区域失败");
                return;
            }

            hswm.HalconWindow.DispObj(ho_TransImage);
            hswm.SetFullImagePart();
            LogTool.Info("加载检测区域成功！");
        }

        private void btn_createModel_Click(object sender, EventArgs e)
        {
            hswm.HalconWindow.ClearWindow();
            HOperatorSet.BinaryThreshold(ho_TransImage, out HObject ho_Region, "smooth_histo", "light", out HTuple hv_UsedThreshold);
            HOperatorSet.OpeningCircle(ho_Region, out HObject ho_RegionOpening, 7.5);
            HOperatorSet.Connection(ho_RegionOpening, out HObject ho_ConnectedRegions);
            HOperatorSet.AreaCenter(ho_ConnectedRegions, out HTuple hv_Area, out HTuple hv_Row, out HTuple hv_Column);
            HOperatorSet.SelectObj(ho_ConnectedRegions, out HObject ho_ObjectSelected, ((new HTuple(((-hv_Area)).TupleSortIndex())).TupleSelect(0)) + 1);
            HOperatorSet.FillUp(ho_ObjectSelected, out HObject ho_RegionFillUp);
            HOperatorSet.DilationCircle(ho_RegionFillUp, out HObject ho_RegionDilation, 5.5);
            HOperatorSet.ReduceDomain(ho_TransImage, ho_RegionDilation, out ho_ImageReduced);
            HOperatorSet.AreaCenter(ho_ImageReduced, out HTuple hv__, out hv_Rc, out hv_Cc);

            try
            {
                HOperatorSet.CreatePlanarUncalibDeformableModel(ho_ImageReduced, "auto", new HTuple(), new HTuple(), "auto", 1, new HTuple(), "auto", 1, new HTuple(), "auto", "none", "use_polarity", "auto", "auto", new HTuple(), new HTuple(), out hv_ModelID);
            }
            catch (Exception ex)
            {
                LogTool.Error("创建模版失败" + ex.Message);
                return;
            }
            hswm.HalconWindow.DispObj(ho_ImageReduced);
            hswm.SetFullImagePart();
            LogTool.Info("创建模版成功！");

            isModeling = true;
            btn_getRefRegion.Enabled = false;
            btn_createModel.Enabled = false;


        }

        private async void btn_drawBead_Click(object sender, EventArgs e)
        {

            var handle = hswm.HalconWindow;
            handle.ClearWindow();
            handle.DispObj(AlignedImage);
            HTuple hv_RowsOut = new HTuple();
            HTuple hv_ColumnsOut = new HTuple();
            await Task.Run(() =>
            {
                while (true)
                {
                    HOperatorSet.GetMbutton(handle, out var hv_Row1, out var hv_Column1, out var hv_Button);
                    if (hv_Button == 1)
                    {
                        hv_RowsOut.Append(hv_Row1);
                        hv_ColumnsOut.Append(hv_Column1);

                        HOperatorSet.GenEmptyObj(out HObject ho_Concatobj);
                        if (hv_RowsOut.Length > 1)
                        {
                            //生成局部轨迹
                            for (int i = 0; i < hv_RowsOut.Length - 2; i++)
                            {
                                HalconTool.gen_arrow_contour_xld(out HObject ho_Arrow, hv_RowsOut[i], hv_ColumnsOut[i], hv_RowsOut[i + 1], hv_ColumnsOut[i + 1], 5, 5);
                                HOperatorSet.ConcatObj(ho_Concatobj, ho_Arrow, out ho_Concatobj);
                                handle.SetColored(12);
                                handle.DispObj(AlignedImage);
                                handle.DispObj(ho_Concatobj);
                            }
                        }
                    }
                    else if (hv_Button == 4)
                    {
                        break;
                    }
                }
            });

            HOperatorSet.GenContourNurbsXld(out ho_Contour, hv_RowsOut, hv_ColumnsOut, "auto", "auto", 3, 1, 5);
            handle.ClearWindow();
            handle.DispObj(AlignedImage);
            hswm.HalconWindow.DispObj(ho_Contour);
            hswm.SetFullImagePart();
            LogTool.Info("胶路轨迹绘制成功！");
        }

        private void btn_loadDetImage_Click(object sender, EventArgs e)
        {
            string filePath = "";
            HObject detImage;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "图像文件|*.jpg;*.png";
                ofd.Title = "请选择图像";
                ofd.InitialDirectory = Application.StartupPath;
                ofd.Multiselect = false;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                }
            }
            try
            {
                HOperatorSet.ReadImage(out detImage, new HTuple(filePath));
            }
            catch (Exception ex)
            {
                ShowMsg("未读取到检测图像");
                return;
            }
            //hswm.HalconWindow.DispObj(Ref_Image);
            //hswm.SetFullImagePart();
            LogTool.Info("加载检测图像" + filePath);

            hswm.HalconWindow.ClearWindow();
            HDevEngine eng = new HDevEngine();
            string procPath = Path.Combine(Application.StartupPath, @"AdhesiveBead\HalHalconFunc");
            eng.SetProcedurePath(procPath);

            HDevProcedure proc = new HDevProcedure("AlignImage");
            if (proc == null)
            {
                ShowMsg("未发现可调用函数");
                return;
            }
            HDevProcedureCall pcall = proc.CreateCall();
            if (detImage == null)
                return;
            pcall.SetInputIconicParamObject("InputImage", detImage);
            pcall.SetInputCtrlParamTuple("ModelID", hv_ModelID);
            pcall.SetInputCtrlParamTuple("RowCenter", hv_Rc);
            pcall.SetInputCtrlParamTuple("ColumnCenter", hv_Cc);

            pcall.Execute();
            AlignedImage = pcall.GetOutputIconicParamObject("AlignedImage");
            LogTool.Info("显示矫正后检测图像");
            hswm.HalconWindow.DispObj(AlignedImage);
            hswm.SetFullImagePart();
        }

        private void btn_preBead_Click(object sender, EventArgs e)
        {
            HTuple rows = new HTuple([733, 722, 708, 694, 683, 671, 648, 629, 611, 597, 585, 576, 562, 546, 532, 525, 511, 495, 474, 465, 447, 438, 426, 414, 412, 417, 424, 424, 431, 431, 438, 440, 447, 447, 456, 461, 470, 486, 493, 507, 516, 537, 542, 553, 569, 583, 599, 613, 625, 639, 648, 659, 673, 685, 710, 715, 717]);
            HTuple cols = new HTuple([418, 427, 434, 434, 430, 425, 420, 420, 423, 430, 446, 462, 474, 492, 504, 513, 524, 538, 555, 568, 582, 598, 610, 628, 645, 658, 684, 693, 712, 723, 742, 765, 795, 813, 825, 843, 862, 878, 880, 885, 890, 899, 903, 910, 927, 938, 947, 957, 966, 968, 977, 982, 984, 991, 998, 1000, 1000]);
            HOperatorSet.GenContourNurbsXld(out ho_Contour, rows, cols, "auto", "auto", 3, 1, 5);
            hswm.HalconWindow.ClearWindow();
            hswm.HalconWindow.DispObj(AlignedImage);
            hswm.HalconWindow.DispObj(ho_Contour);
            hswm.SetFullImagePart();
            LogTool.Info("预定义胶路轨迹绘制成功！");
        }

        private void btn_createBeadModel_Click(object sender, EventArgs e)
        {
            // 获取胶路模版参数
            BeadModel mb = proBeanModel.SelectedObject as BeadModel;
            hv_Target_thick = mb.thickness;
            HTuple hv_Target_tolerance = mb.tolerance;
            hv_Position_tolerance = mb.pos_tolerance;

            HOperatorSet.CreateBeadInspectionModel(ho_Contour, hv_Target_thick, hv_Target_tolerance, hv_Position_tolerance, "dark", new HTuple(), new HTuple(), out hv_BeadInspectionModel);
            LogTool.Info("胶路模版创建成功！");

        }

        private void btn_drawBeadWidth_Click(object sender, EventArgs e)
        {
            HOperatorSet.GenParallelContourXld(ho_Contour, out HObject ho_WidthContours1, "regression_normal", hv_Target_thick / 2);
            HOperatorSet.GenParallelContourXld(ho_Contour, out HObject ho_WidthContours2, "regression_normal", (-hv_Target_thick) / 2);
            HOperatorSet.ConcatObj(ho_WidthContours1, ho_WidthContours2, out ho_WidthContours);

            hswm.HalconWindow.SetColor("yellow");
            hswm.HalconWindow.ClearWindow();
            hswm.HalconWindow.DispObj(AlignedImage);
            hswm.HalconWindow.DispObj(ho_WidthContours);
            hswm.SetFullImagePart();
            LogTool.Info("胶宽轮廓绘制成功！");


        }

        private void btn_drawBeadPos_Click(object sender, EventArgs e)
        {
            HOperatorSet.GenParallelContourXld(ho_Contour, out HObject ho_PositionContours1, "regression_normal", hv_Position_tolerance / 2);
            HOperatorSet.GenParallelContourXld(ho_Contour, out HObject ho_PositionContours2, "regression_normal", (-hv_Position_tolerance) / 2);
            HOperatorSet.ConcatObj(ho_PositionContours1, ho_PositionContours2, out ho_PositionContours);

            hswm.HalconWindow.SetColor("yellow");
            hswm.HalconWindow.ClearWindow();
            hswm.HalconWindow.DispObj(AlignedImage);
            hswm.HalconWindow.DispObj(ho_PositionContours);
            hswm.SetFullImagePart();
            LogTool.Info("胶路偏移轮廓绘制成功！");
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            var handle = hswm.HalconWindow;

            HOperatorSet.ApplyBeadInspectionModel(AlignedImage, out HObject ho_LeftContour, out HObject ho_RightContour, out HObject ho_ErrorSegment, hv_BeadInspectionModel, out HTuple hv_ErrorType);
            LogTool.Info($"错误数量{hv_ErrorType.Length}");
            handle.ClearWindow();
            var window = handle;
            HOperatorSet.DispObj(AlignedImage, window);

            HOperatorSet.SetLineWidth(window, 1);
            hswm.HalconWindow.SetColor("yellow");
            HOperatorSet.DispObj(ho_Contour, window);
            HOperatorSet.DispObj(ho_WidthContours, window);
            HOperatorSet.DispObj(ho_PositionContours, window);

            hswm.HalconWindow.SetColor("green");
            HOperatorSet.SetLineWidth(window, 2);
            HOperatorSet.DispObj(ho_LeftContour, window);
            HOperatorSet.DispObj(ho_RightContour, window);

            hswm.HalconWindow.SetColor("red");
            HOperatorSet.SetLineWidth(window, 5);
            HOperatorSet.DispObj(ho_ErrorSegment, window);

            int numerror = hv_ErrorType.Length;
            for (int j = 0; j < numerror; j++)
            {
                // 选择错误段
                HOperatorSet.SelectObj(ho_ErrorSegment, out HObject ho_SingleErrorSeg, j + 1);
                // 获取中心位置
                HOperatorSet.AreaCenterXld(ho_SingleErrorSeg, out var hv_Area1, out var hv_RowC, out var hv_ColC, out var hv_PointOrder);
                string defectstr = hv_ErrorType[j];

                HOperatorSet.DispText(handle, defectstr, "image", hv_RowC, hv_ColC, "red", new HTuple(), new HTuple());
            }

            if (hv_ErrorType.Length == 0)
            {
                HOperatorSet.DispText(handle, "胶路质量正常", "window", 20, 20, "green", new HTuple(), new HTuple());
            }
            else
            {
                HOperatorSet.DispText(handle, "胶路质量异常", "window", 20, 20, "red", new HTuple(), new HTuple());
            }

        }
    }
}

