namespace HalconWithCsharp.HKCamera
{
    partial class HKFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            pic = new PictureBox();
            groupBox2 = new GroupBox();
            btn_Closedevice = new Button();
            btn_Opendevice = new Button();
            cbdevices = new ComboBox();
            btn_showDevice = new Button();
            groupBox3 = new GroupBox();
            btn_SetParam = new Button();
            btn_GetParam = new Button();
            cbformat = new ComboBox();
            tb3 = new TextBox();
            tb2 = new TextBox();
            tb1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            rb2 = new RadioButton();
            rb1 = new RadioButton();
            btn_stopVideo = new Button();
            btn_capVideo = new Button();
            btn_stopCap = new Button();
            btn_CapImage = new Button();
            groupBox5 = new GroupBox();
            cbIformat = new ComboBox();
            label5 = new Label();
            btn_saveImage = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(pic);
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(718, 826);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "图像显示";
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(3, 34);
            pic.Name = "pic";
            pic.Size = new Size(712, 789);
            pic.TabIndex = 0;
            pic.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btn_Closedevice);
            groupBox2.Controls.Add(btn_Opendevice);
            groupBox2.Controls.Add(cbdevices);
            groupBox2.Controls.Add(btn_showDevice);
            groupBox2.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox2.Location = new Point(732, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(551, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "初始化";
            // 
            // btn_Closedevice
            // 
            btn_Closedevice.Location = new Point(289, 131);
            btn_Closedevice.Name = "btn_Closedevice";
            btn_Closedevice.Size = new Size(253, 43);
            btn_Closedevice.TabIndex = 3;
            btn_Closedevice.Text = "关闭设备";
            btn_Closedevice.UseVisualStyleBackColor = true;
            btn_Closedevice.Click += btn_Closedevice_Click;
            // 
            // btn_Opendevice
            // 
            btn_Opendevice.Location = new Point(15, 131);
            btn_Opendevice.Name = "btn_Opendevice";
            btn_Opendevice.Size = new Size(268, 43);
            btn_Opendevice.TabIndex = 2;
            btn_Opendevice.Text = "打开设备";
            btn_Opendevice.UseVisualStyleBackColor = true;
            btn_Opendevice.Click += btn_Opendevice_Click;
            // 
            // cbdevices
            // 
            cbdevices.FormattingEnabled = true;
            cbdevices.Location = new Point(15, 83);
            cbdevices.Name = "cbdevices";
            cbdevices.Size = new Size(527, 39);
            cbdevices.TabIndex = 1;
            // 
            // btn_showDevice
            // 
            btn_showDevice.Location = new Point(15, 37);
            btn_showDevice.Name = "btn_showDevice";
            btn_showDevice.Size = new Size(527, 38);
            btn_showDevice.TabIndex = 0;
            btn_showDevice.Text = "显示可用设备";
            btn_showDevice.UseVisualStyleBackColor = true;
            btn_showDevice.Click += btn_showDevice_Click;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(btn_SetParam);
            groupBox3.Controls.Add(btn_GetParam);
            groupBox3.Controls.Add(cbformat);
            groupBox3.Controls.Add(tb3);
            groupBox3.Controls.Add(tb2);
            groupBox3.Controls.Add(tb1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox3.Location = new Point(732, 207);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(549, 298);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "参数数据";
            // 
            // btn_SetParam
            // 
            btn_SetParam.Location = new Point(308, 236);
            btn_SetParam.Name = "btn_SetParam";
            btn_SetParam.Size = new Size(219, 43);
            btn_SetParam.TabIndex = 8;
            btn_SetParam.Text = "修改参数";
            btn_SetParam.UseVisualStyleBackColor = true;
            btn_SetParam.Click += btn_SetParam_Click;
            // 
            // btn_GetParam
            // 
            btn_GetParam.Location = new Point(33, 236);
            btn_GetParam.Name = "btn_GetParam";
            btn_GetParam.Size = new Size(219, 43);
            btn_GetParam.TabIndex = 4;
            btn_GetParam.Text = "获取参数";
            btn_GetParam.UseVisualStyleBackColor = true;
            btn_GetParam.Click += btn_GetParam_Click;
            // 
            // cbformat
            // 
            cbformat.FormattingEnabled = true;
            cbformat.Location = new Point(186, 182);
            cbformat.Name = "cbformat";
            cbformat.Size = new Size(356, 39);
            cbformat.TabIndex = 7;
            // 
            // tb3
            // 
            tb3.Location = new Point(186, 136);
            tb3.Name = "tb3";
            tb3.Size = new Size(356, 38);
            tb3.TabIndex = 6;
            // 
            // tb2
            // 
            tb2.Location = new Point(186, 91);
            tb2.Name = "tb2";
            tb2.Size = new Size(356, 38);
            tb2.TabIndex = 5;
            // 
            // tb1
            // 
            tb1.Location = new Point(186, 42);
            tb1.Name = "tb1";
            tb1.Size = new Size(356, 38);
            tb1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 187);
            label4.Name = "label4";
            label4.Size = new Size(134, 31);
            label4.TabIndex = 3;
            label4.Text = "像素格式：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 141);
            label3.Name = "label3";
            label3.Size = new Size(110, 31);
            label3.TabIndex = 2;
            label3.Text = "帧速率：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 1;
            label2.Text = "增益值：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 46);
            label1.Name = "label1";
            label1.Size = new Size(134, 31);
            label1.TabIndex = 0;
            label1.Text = "曝光时间：";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox4.Controls.Add(rb2);
            groupBox4.Controls.Add(rb1);
            groupBox4.Controls.Add(btn_stopVideo);
            groupBox4.Controls.Add(btn_capVideo);
            groupBox4.Controls.Add(btn_stopCap);
            groupBox4.Controls.Add(btn_CapImage);
            groupBox4.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox4.Location = new Point(732, 520);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(549, 185);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "图像采集";
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(349, 39);
            rb2.Name = "rb2";
            rb2.Size = new Size(135, 35);
            rb2.TabIndex = 15;
            rb2.TabStop = true;
            rb2.Text = "触发采集";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb_CheckedChanged;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(72, 39);
            rb1.Name = "rb1";
            rb1.Size = new Size(135, 35);
            rb1.TabIndex = 14;
            rb1.TabStop = true;
            rb1.Text = "连续采集";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb_CheckedChanged;
            // 
            // btn_stopVideo
            // 
            btn_stopVideo.Location = new Point(308, 133);
            btn_stopVideo.Name = "btn_stopVideo";
            btn_stopVideo.Size = new Size(219, 43);
            btn_stopVideo.TabIndex = 12;
            btn_stopVideo.Text = "停止录像";
            btn_stopVideo.UseVisualStyleBackColor = true;
            btn_stopVideo.Click += btn_stopVideo_Click;
            // 
            // btn_capVideo
            // 
            btn_capVideo.Location = new Point(33, 134);
            btn_capVideo.Name = "btn_capVideo";
            btn_capVideo.Size = new Size(219, 43);
            btn_capVideo.TabIndex = 11;
            btn_capVideo.Text = "开始录像";
            btn_capVideo.UseVisualStyleBackColor = true;
            btn_capVideo.Click += btn_capVideo_Click;
            // 
            // btn_stopCap
            // 
            btn_stopCap.Location = new Point(308, 80);
            btn_stopCap.Name = "btn_stopCap";
            btn_stopCap.Size = new Size(219, 43);
            btn_stopCap.TabIndex = 10;
            btn_stopCap.Text = "停止采集";
            btn_stopCap.UseVisualStyleBackColor = true;
            btn_stopCap.Click += btn_stopCap_Click;
            // 
            // btn_CapImage
            // 
            btn_CapImage.Location = new Point(33, 80);
            btn_CapImage.Name = "btn_CapImage";
            btn_CapImage.Size = new Size(219, 43);
            btn_CapImage.TabIndex = 9;
            btn_CapImage.Text = "开始采集";
            btn_CapImage.UseVisualStyleBackColor = true;
            btn_CapImage.Click += btn_CapImage_Click;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox5.Controls.Add(cbIformat);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(btn_saveImage);
            groupBox5.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox5.Location = new Point(731, 709);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(549, 113);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "保存图像";
            // 
            // cbIformat
            // 
            cbIformat.FormattingEnabled = true;
            cbIformat.Location = new Point(171, 46);
            cbIformat.Name = "cbIformat";
            cbIformat.Size = new Size(210, 39);
            cbIformat.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 49);
            label5.Name = "label5";
            label5.Size = new Size(141, 31);
            label5.TabIndex = 17;
            label5.Text = "保存格式： ";
            // 
            // btn_saveImage
            // 
            btn_saveImage.Location = new Point(387, 43);
            btn_saveImage.Name = "btn_saveImage";
            btn_saveImage.Size = new Size(140, 43);
            btn_saveImage.TabIndex = 16;
            btn_saveImage.Text = "保存";
            btn_saveImage.UseVisualStyleBackColor = true;
            btn_saveImage.Click += btn_saveImage_Click;
            // 
            // HKFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 837);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "HKFrm";
            Text = "海康工业相机采集";
            Load += HKFrm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pic;
        private GroupBox groupBox2;
        private Button btn_Closedevice;
        private Button btn_Opendevice;
        private ComboBox cbdevices;
        private Button btn_showDevice;
        private GroupBox groupBox3;
        private TextBox tb1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_SetParam;
        private Button btn_GetParam;
        private ComboBox cbformat;
        private TextBox tb3;
        private TextBox tb2;
        private GroupBox groupBox4;
        private RadioButton rb2;
        private RadioButton rb1;
        private Button btn_stopVideo;
        private Button btn_capVideo;
        private Button btn_stopCap;
        private Button btn_CapImage;
        private GroupBox groupBox5;
        private ComboBox cbIformat;
        private Label label5;
        private Button btn_saveImage;
    }
}