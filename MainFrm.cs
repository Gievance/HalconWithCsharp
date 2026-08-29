using HalconDotNet;
using HalconWithCsharp_CarCard.Models;
using static System.Windows.Forms.MonthCalendar;
namespace HalconWithCsharp_CarCard
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            hwmc.MouseWheel += hwmc.HSmartWindowControl_MouseWheel;
        }
        #region 图像采集
        private HImage ho_Image;
        private void btn1_Click(object sender, EventArgs e)
        {
            HTuple img_path;
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "图像类型|*.png;*.jpg";
                ofd.InitialDirectory = Environment.CurrentDirectory;
                ofd.Title = "请选择图片";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img_path = ofd.FileName;
                    ho_Image = new HImage(img_path);
                }
            }
            hwmc.HalconWindow.DispObj(ho_Image);
            hwmc.SetFullImagePart();
        }
        #endregion

        #region 灰度化
        HObject ho_GrayImage;
        private void btn2_Click(object sender, EventArgs e)
        {

            HOperatorSet.Rgb1ToGray(ho_Image, out ho_GrayImage);
            hwmc.HalconWindow.DispObj(ho_GrayImage);
            hwmc.SetFullImagePart();
        }
        #endregion



        #region 阈值化处理
        HObject ho_Region;
        private void btn3_Click(object sender, EventArgs e)
        {
            Threshold ths = new Threshold();
            HTuple ming = ths.mingray, maxg = ths.maxgray;

            propertyGrid.SelectedObject = ths;
            propertyGrid.SelectedGridItemChanged += ThresholdChange;

            HOperatorSet.Threshold(ho_GrayImage, out ho_Region, ming, maxg);

        }

        private void ThresholdChange(object? sender, SelectedGridItemChangedEventArgs e)
        {
            var threshold = ((PropertyGrid)sender).SelectedObject as Threshold;
            var mingray = threshold.mingray < 0 ? 0 : threshold.mingray;
            var maxgary = threshold.maxgray > 255 ? 255 : threshold.maxgray;

            threshold.mingray = mingray;
            threshold.maxgray = maxgary;
            propertyGrid.SelectedObject = threshold;

            HOperatorSet.Threshold(ho_GrayImage, out ho_Region, mingray, maxgary);
            hwmc.HalconWindow.ClearWindow();
            hwmc.HalconWindow.DispObj(ho_Region);
            hwmc.SetFullImagePart();
        }

        #endregion


        #region 区域砍断
        HObject ho_ConnectedRegions;
        private void btn4_Click(object sender, EventArgs e)
        {
            propertyGrid.SelectedGridItemChanged -= ThresholdChange;
            HOperatorSet.Connection(ho_Region, out ho_ConnectedRegions);

            // hwmc.HalconWindow.ClearWindow();
            hwmc.HalconWindow.SetColored(12);
            hwmc.HalconWindow.DispObj(ho_ConnectedRegions);
            hwmc.SetFullImagePart();
        }
        #endregion

        #region 区域选择
        HObject ho_SelectedRegion;
        private void btn5_Click(object sender, EventArgs e)
        {
            Feature fea = new Feature();
            propertyGrid.SelectedGridItemChanged += FeatureChange;
            propertyGrid.SelectedObject = null;
            propertyGrid.SelectedObject = fea;

            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegion, fea.feature,
                fea.opera, fea.minval, fea.maxval);

            hwmc.HalconWindow.ClearWindow();
            hwmc.HalconWindow.DispObj(ho_SelectedRegion);
            hwmc.SetFullImagePart();
        }

        private void FeatureChange(object? sender, SelectedGridItemChangedEventArgs e)
        {
            // 获取对象
            Feature fea = ((PropertyGrid)sender).SelectedObject as Feature;
            // 检查对象
            var min = fea.minval < 0 ? 0 : fea.minval;
            var max = fea.maxval < fea.minval ? fea.minval : fea.maxval;
            fea.minval = min;
            fea.maxval = max;
            propertyGrid.SelectedObject = fea;

            HOperatorSet.SelectShape(ho_ConnectedRegions, out ho_SelectedRegion, fea.feature,
        fea.opera, fea.minval, fea.maxval);


            // 显示对象
            hwmc.HalconWindow.DispObj(ho_SelectedRegion);
            hwmc.SetFullImagePart();
        }
        #endregion


        #region 形态学处理
        HObject ho_RegionFillUp, ho_RegionOpening, ho_RegionTrans;
        private void btn6_Click(object sender, EventArgs e)
        {
            HOperatorSet.FillUp(ho_SelectedRegion, out ho_RegionFillUp);
            HOperatorSet.OpeningCircle(ho_RegionFillUp, out ho_RegionOpening, 3);
            HOperatorSet.ShapeTrans(ho_RegionOpening, out ho_RegionTrans, "rectangle2");

            hwmc.HalconWindow.ClearWindow();
            hwmc.HalconWindow.DispObj(ho_RegionTrans);
            hwmc.SetFullImagePart();
        }
        #endregion

        #region 仿射变换

        HObject ho_ImageReduced, ho_RegionAffineTrans, ho_ImageAffineTrans;
        HTuple hv_Row, hv_Column, hv_Phi, hv_HomMat2D;
        private void btn7_Click(object sender, EventArgs e)
        {
            HOperatorSet.ReduceDomain(ho_Image, ho_RegionOpening, out ho_ImageReduced);
            HOperatorSet.AreaCenter(ho_RegionOpening, out _, out hv_Row, out hv_Column);
            HOperatorSet.OrientationRegion(ho_RegionOpening, out hv_Phi);

            HOperatorSet.HomMat2dIdentity(out hv_HomMat2D);
            HOperatorSet.VectorAngleToRigid(hv_Row, hv_Column, hv_Phi, hv_Row, hv_Column,
                0, out hv_HomMat2D);

            HOperatorSet.AffineTransRegion(ho_RegionOpening, out ho_RegionAffineTrans, hv_HomMat2D,
                 "nearest_neighbor");
            HOperatorSet.AffineTransImage(ho_ImageReduced, out ho_ImageAffineTrans, hv_HomMat2D,
                "constant", "false");

            hwmc.HalconWindow.ClearWindow();
            hwmc.HalconWindow.DispObj(ho_ImageAffineTrans);
            hwmc.SetFullImagePart();
        }

        #endregion

        #region 提取目标
        HObject ho_ImageReduced1;

        private void btn8_Click(object sender, EventArgs e)
        {
            HOperatorSet.ReduceDomain(ho_ImageAffineTrans, ho_RegionAffineTrans, out ho_ImageReduced1);

            hwmc.HalconWindow.ClearWindow();
            hwmc.HalconWindow.DispObj(ho_ImageReduced1);
            hwmc.SetFullImagePart();
        }

        #endregion


    }
}
