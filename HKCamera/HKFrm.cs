using MvCameraControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace HalconWithCsharp.HKCamera
{
    public partial class HKFrm : Form
    {
        public HKFrm()
        {
            InitializeComponent();
        }

        private void HKFrm_Load(object sender, EventArgs e)
        {
            // 海康相机SDK初试化，对非托管相机资源分配内存
            SDKSystem.Initialize();
            // 更新设别信息
            refreshDevices();

            cbIformat.DataSource = imgformat;

        }
        #region 中间变量

        List<string> imgformat = new List<string>()
        {
            "bmp","jpg","tiff","png"
        };

        // 枚举可用设别
        List<IDeviceInfo> enumDevice;
        // 指定显示设备的类别
        DeviceTLayerType dType = DeviceTLayerType.MvGigEDevice | DeviceTLayerType.MvUsbDevice | DeviceTLayerType.MvGenTLCXPDevice | DeviceTLayerType.MvGenTLXoFDevice;
        // 指向打开的设别
        IDevice device;
        // 采集标志
        bool isGrabbing = false;
        static object saveImageLock = new object();
        IFrameOut saveframe;
        Thread capImage;

        bool isRecord = false;
        #endregion

        #region 触发模式
        private void TriggerMode_A(IDevice device)
        {
            if (device == null)
                return;
            device.Parameters.SetEnumValueByString("TriggerMode", "Off");
        }
        private void TriggerMode_B(IDevice device)
        {
            if (device == null)
                return;
            device.Parameters.SetEnumValueByString("TriggerMode", "Off");
        }
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton cb = sender as RadioButton;
            string mode;
            if(cb.Checked)
            {
                mode = cb.Text;
                switch (mode)
                {
                    case "连续采集": { TriggerMode_A(device); }break;
                    case "触发采集": { TriggerMode_B(device); } break;
                }
            }
        }
        #endregion

        #region 获取可用设备
        /// <summary>
        /// 刷新可用设备信息
        /// </summary>
        private void refreshDevices()
        {
            cbdevices.Items.Clear();

            int ret = DeviceEnumerator.EnumDevices(dType, out enumDevice);
            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("读取可用设备失败", "提示", MessageBoxButtons.OK);
                return;
            }

            if (enumDevice.Count < 0 || enumDevice == null)
            {
                MessageBox.Show("无设备可以使用", "提示", MessageBoxButtons.OK);
                return;
            }

            for (int i = 0; i < enumDevice.Count; i++)
            {
                IDeviceInfo Info = enumDevice[i];
                if (Info.UserDefinedName != "")
                {
                    cbdevices.Items.Add(Info.TLayerType.ToString() + ":" + Info.UserDefinedName + "(" + Info.SerialNumber + ")");
                }
                else
                {
                    cbdevices.Items.Add(Info.TLayerType.ToString() + ":" + Info.ManufacturerName + "(" + Info.SerialNumber + ")");
                }
            }

            // 设置默认项 (失误点，默认项设置为0，缺少前提设备数量不少于0)
            if (cbdevices.SelectedIndex == -1 && enumDevice.Count > 0)
            {
                cbdevices.SelectedIndex = 0;
            }

        }
        private void btn_showDevice_Click(object sender, EventArgs e)
        {
            refreshDevices();
        }
        #endregion

        #region 打开设备
        private void btn_Opendevice_Click(object sender, EventArgs e)
        {
            int ret = cbdevices.SelectedIndex;
            if (ret < 0)
            {
                MessageBox.Show("请选择设备", "提示", MessageBoxButtons.OK);
                return;
            }
            if (enumDevice.Count < 0)
            {
                MessageBox.Show("无可用设备", "提示", MessageBoxButtons.OK);
                return;
            }

            try
            {
                device = DeviceFactory.CreateDevice(enumDevice[ret]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("缺少可用设备" + ex.Message, "提示");
                return;
            }
            int ret2 = device.Open();
            if (ret2 != MvError.MV_OK)
            {
                MessageBox.Show("打开失败", "提示");
            }

            if (device is IGigEDevice)
            {
                IGigEDevice gdevice = device as IGigEDevice;
                int psize;
                gdevice.GetOptimalPacketSize(out psize);
                gdevice.Parameters.SetIntValue("GevSCPSPacketSize", psize);
            }
            else if (device is IUSBDevice)
            {
                /*设置USB同步读写超时时间*/
                IUSBDevice usbDevice = device as IUSBDevice;
                usbDevice.SetSyncTimeOut(1000);
            }

            // 设置采集连续模式
            device.Parameters.SetEnumValueByString("AcquisitionMode", "Continuous");
            TriggerMode_A(device);
            rb1.Checked = true;
            btn_GetParam_Click(null, null);
            MessageBox.Show("打开成功", "提示");
        }
        #endregion

        #region 关闭设备
        private void btn_Closedevice_Click(object sender, EventArgs e)
        {
            if (device != null)
            {
                int ret = device.Close();
                if (ret != MvError.MV_OK)
                {
                    MessageBox.Show("关闭失败", "提示");
                    return;
                }
                device.Dispose();
                MessageBox.Show("关闭成功", "提示");
            }
            else
            {
                MessageBox.Show("未使用设备", "提示");
            }
            
        }
        #endregion

        #region 获取参数
        private void btn_GetParam_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                return;
            }
            IFloatValue val;

            int ret = device.Parameters.GetFloatValue("ExposureTime", out val);
            if (ret == MvError.MV_OK)
            {
                tb1.Text = val.CurValue.ToString("F1");
            }
            ret = device.Parameters.GetFloatValue("Gain", out val);
            if (ret == MvError.MV_OK)
            {
                tb2.Text = val.CurValue.ToString("F1");
            }

            ret = device.Parameters.GetFloatValue("ResultingFrameRate", out val);
            if (ret == MvError.MV_OK)
            {
                tb3.Text = val.CurValue.ToString("F1");
            }

            cbformat.Items.Clear();
            ret = device.Parameters.GetEnumValue("PixelFormat", out IEnumValue enumvalue);
            foreach (var f in enumvalue.SupportEnumEntries)
            {
                cbformat.Items.Add(f.Symbolic);
                if (f.Symbolic == enumvalue.CurEnumEntry.Symbolic)
                {
                    cbformat.SelectedIndex = cbformat.Items.Count - 1;
                }
            }
        }
        #endregion

        #region 设置参数
        private void btn_SetParam_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(tb1.Text);
                float.Parse(tb2.Text);
                float.Parse(tb3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("请重新输入参数" + ex.Message, "提示");
            }

            // 曝光时间
            device.Parameters.SetEnumValue("ExposureAuto", 0);
            int ret = device.Parameters.SetFloatValue("ExposureTime", float.Parse(tb1.Text));
            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("设置曝光时间失败!", "提示");
            }

            // 增益值
            device.Parameters.SetEnumValue("GainAuto", 0);
            ret = device.Parameters.SetFloatValue("Gain", float.Parse(tb2.Text));
            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("设置增益值失败!", "提示");
            }
            ret = device.Parameters.SetBoolValue("AcquisitionFrameRateEnable", true);
            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("设置采集帧启用失败!", "提示");
            }
            else
            {
                device.Parameters.SetFloatValue("AcquisitionFrameRate",
                    float.Parse(tb3.Text));
                if (ret != MvError.MV_OK)
                {
                    MessageBox.Show("设置帧率失败!", "提示");
                }

            }

            MessageBox.Show("参数设置成功", "提示");

        }
        #endregion


        #region 图像采集
        private void CaptureThread(Object obj)
        {
            if (obj == null)
            {
                return;
            }
            IStreamGrabber streamGrabber = obj as IStreamGrabber;
            while (isGrabbing)
            {
                IFrameOut fout;
                int ret = streamGrabber.GetImageBuffer(1000, out fout);
                if (ret == MvError.MV_OK)
                {
                    lock (saveImageLock)
                    {
                        try
                        {
                            saveframe = fout.Clone() as IFrameOut;
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("IFrameOut复制失败" + ex.Message);
                            return;
                        }
                    }
                    this.Invoke(() =>
                    {
                        device.ImageRender.DisplayOneFrame(pic.Handle, fout.Image);
                    });
                    streamGrabber.FreeImageBuffer(fout);
                }


            }



        }

        private void btn_CapImage_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                MessageBox.Show("没有打开设备", "提示");
                return;
            }
            IStreamGrabber sg = device.StreamGrabber;
            int ret = sg.StartGrabbing();
            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("抓取图像失败", "提示");
                return;
            }

            isGrabbing = true;
            capImage = new Thread(CaptureThread);

            capImage.Start(sg);
            capImage.Join();
        }

        private void btn_stopCap_Click(object sender, EventArgs e)
        {
            if (device == null)
            {
                MessageBox.Show("没有打开设备", "提示");
                return;
            }
            isGrabbing = false;
            capImage.Join();
            int ret = device.StreamGrabber.StopGrabbing();
            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("停止采集失败", "提示");
            }
        }
        #endregion

        #region 视频采集
        private void btn_capVideo_Click(object sender, EventArgs e)
        {
            if (isGrabbing == false)
            {
                MessageBox.Show("没有开始采集", "提示");
                return;
            }

            IIntValue intValue;
            IFloatValue floatValue;
            IEnumValue enumValue;
            uint width;
            uint height;
            MvGvspPixelType pixelType;

            int result;
            // 宽度+高度
            result = device.Parameters.GetIntValue("Width", out intValue);
            if (result != MvError.MV_OK)
            {
                MessageBox.Show("Get Width failed!");
                return;
            }
            else
            {
                width = (uint)intValue.CurValue;
            }

            result = device.Parameters.GetIntValue("Height", out intValue);
            if (result != MvError.MV_OK)
            {
                MessageBox.Show("Get Height failed!");
                return;
            }
            else
            {
                height = (uint)intValue.CurValue;
            }

            result = device.Parameters.GetEnumValue("PixelFormat", out enumValue);
            if (result != MvError.MV_OK)
            {
                MessageBox.Show("获取像素格式失败!");
                return;
            }
            else
            {
                pixelType = (MvGvspPixelType)enumValue.CurEnumEntry.Value;
            }

            string filepath = "./Record.avi";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FilterIndex = 1;
                sfd.Filter = $"录像地址*.avi | *.mp4";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filepath = sfd.FileName;
                }

            }
            // 设置录像参数
            RecordParam recordParam;
            recordParam.Width = width;
            recordParam.Height = height;
            recordParam.PixelType = pixelType;
            recordParam.FrameRate = float.Parse(tb3.Text);
            recordParam.BitRate = 1000;
            recordParam.FormatType = VideoFormatType.AVI;


            result = device.VideoRecorder.StartRecord(filepath, recordParam);
            if (result != MvError.MV_OK)
            {
                MessageBox.Show("启动录像失败!");
                return;
            }
            else
            {
                isRecord = true;
                MessageBox.Show("录像中~!");
            }




        }


        private void btn_stopVideo_Click(object sender, EventArgs e)
        {
            if (isGrabbing == false)
            {
                MessageBox.Show("还没有开始采集！");
                return;
            }
            //通过设备停止录像操作
            int result = device.VideoRecorder.StopRecord();
            if (result != MvError.MV_OK)
            {
                MessageBox.Show("停止录像失败了！");
            }

            isRecord = false;
        }
        #endregion

        #region 保存图像
        private int SaveImage(ImageFormatInfo imageFormatInfo)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FilterIndex = 1;
                sfd.Filter = $"图片文件 | *.{imageFormatInfo.FormatType.ToString()}";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string iagePath = sfd.FileName;
                    lock (saveImageLock)
                    {
                        return device.ImageSaver.SaveImageToFile(iagePath, saveframe.Image,
                              imageFormatInfo, CFAMethod.Equilibrated);
                    }
                }
            }
            return int.MinValue;
        }

        private void btn_saveImage_Click(object sender, EventArgs e)
        {
            string IType = cbIformat.Text;
            ImageFormatInfo ifi = new ImageFormatInfo();

            switch (IType)
            {
                case "png": { ifi.FormatType = ImageFormatType.Png; }; break;
                case "bmp": { ifi.FormatType = ImageFormatType.Bmp; }; break;
                case "tiff": { ifi.FormatType = ImageFormatType.Tiff; }; break;
                case "jpg": { ifi.FormatType = ImageFormatType.Jpeg; }; break;
            }
            int ret = SaveImage(ifi);

            if (ret != MvError.MV_OK)
            {
                MessageBox.Show("保存图像失败!");
                return;
            }
            else
            {
                MessageBox.Show("保存图像成功!");
            }
        }

        #endregion

        
    }
}
