namespace HalconWithCsharp.DLWithClassification_Battery
{
    partial class DLBattery
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            wGroupBox4 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            cbx_loadModel = new ComboBox();
            label1 = new Label();
            wGroupBox2 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            btn_preprocess = new Button();
            btn_storagePath = new Button();
            btn_samplePath = new Button();
            tb_storagePath = new TextBox();
            tb_samplePath = new TextBox();
            tb_maxgrey = new TextBox();
            tb_mingrey = new TextBox();
            tb_channels = new TextBox();
            tb_imageheight = new TextBox();
            tb_imagewidth = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            wGroupBox1 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            hswm = new HalconDotNet.HSmartWindowControl();
            tabPage2 = new TabPage();
            wGroupBox6 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            btn_loadModel = new Button();
            tb_selModel = new TextBox();
            label17 = new Label();
            tb_trainPSeed = new TextBox();
            label16 = new Label();
            tb_trainPBatch = new TextBox();
            label15 = new Label();
            tb_trainValP = new TextBox();
            label14 = new Label();
            tb_trainTrainP = new TextBox();
            label13 = new Label();
            tb_trainPLr = new TextBox();
            label12 = new Label();
            tb_trainPEvalEpoch = new TextBox();
            label11 = new Label();
            tb_trainPEpochs = new TextBox();
            label10 = new Label();
            btn_trainModel = new Button();
            label9 = new Label();
            btn_LoadDs = new Button();
            wGroupBox5 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            hswmtrain = new HalconDotNet.HSmartWindowControl();
            tabPage3 = new TabPage();
            wGroupBox8 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            btn_EvalExe = new Button();
            btn_3_model = new Button();
            tb_3_model = new TextBox();
            label20 = new Label();
            cbx_data = new ComboBox();
            label19 = new Label();
            cbx_metric = new ComboBox();
            label18 = new Label();
            wGroupBox7 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            hswmeval = new HalconDotNet.HSmartWindowControl();
            tabPage4 = new TabPage();
            wGroupBox11 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            tb_Time = new TextBox();
            tb_Score = new TextBox();
            tb_retClass = new TextBox();
            label25 = new Label();
            label24 = new Label();
            label23 = new Label();
            wGroupBox10 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            hswmInfer = new HalconDotNet.HSmartWindowControl();
            wGroupBox9 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            btn_4_selData = new Button();
            btn_4_selModel = new Button();
            tb2 = new TextBox();
            tb1 = new TextBox();
            btn_4_ExeInfer = new Button();
            label22 = new Label();
            label21 = new Label();
            wGroupBox3 = new HalconWithCsharp.DLWithClassification_Battery.Control.WGroupBox();
            rtb = new RichTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            wGroupBox4.SuspendLayout();
            wGroupBox2.SuspendLayout();
            wGroupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            wGroupBox6.SuspendLayout();
            wGroupBox5.SuspendLayout();
            tabPage3.SuspendLayout();
            wGroupBox8.SuspendLayout();
            wGroupBox7.SuspendLayout();
            tabPage4.SuspendLayout();
            wGroupBox11.SuspendLayout();
            wGroupBox10.SuspendLayout();
            wGroupBox9.SuspendLayout();
            wGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(880, 494);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(wGroupBox4);
            tabPage1.Controls.Add(wGroupBox2);
            tabPage1.Controls.Add(wGroupBox1);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(872, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "预处理数据";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // wGroupBox4
            // 
            wGroupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wGroupBox4.Controls.Add(cbx_loadModel);
            wGroupBox4.Controls.Add(label1);
            wGroupBox4.CustomTitle = "模型";
            wGroupBox4.Location = new Point(558, 3);
            wGroupBox4.Name = "wGroupBox4";
            wGroupBox4.Padding = new Padding(0);
            wGroupBox4.Size = new Size(311, 72);
            wGroupBox4.TabIndex = 2;
            wGroupBox4.TabStop = false;
            wGroupBox4.Text = "wGroupBox4";
            wGroupBox4.TitleFont = new Font("宋体", 12F);
            wGroupBox4.TitlePaddingVertical = 5;
            // 
            // cbx_loadModel
            // 
            cbx_loadModel.FormattingEnabled = true;
            cbx_loadModel.Location = new Point(96, 35);
            cbx_loadModel.Name = "cbx_loadModel";
            cbx_loadModel.Size = new Size(196, 25);
            cbx_loadModel.TabIndex = 1;
            cbx_loadModel.SelectedIndexChanged += cbx_loadModel_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(15, 37);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "选择模型：";
            // 
            // wGroupBox2
            // 
            wGroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wGroupBox2.Controls.Add(btn_preprocess);
            wGroupBox2.Controls.Add(btn_storagePath);
            wGroupBox2.Controls.Add(btn_samplePath);
            wGroupBox2.Controls.Add(tb_storagePath);
            wGroupBox2.Controls.Add(tb_samplePath);
            wGroupBox2.Controls.Add(tb_maxgrey);
            wGroupBox2.Controls.Add(tb_mingrey);
            wGroupBox2.Controls.Add(tb_channels);
            wGroupBox2.Controls.Add(tb_imageheight);
            wGroupBox2.Controls.Add(tb_imagewidth);
            wGroupBox2.Controls.Add(label8);
            wGroupBox2.Controls.Add(label7);
            wGroupBox2.Controls.Add(label6);
            wGroupBox2.Controls.Add(label5);
            wGroupBox2.Controls.Add(label4);
            wGroupBox2.Controls.Add(label3);
            wGroupBox2.Controls.Add(label2);
            wGroupBox2.CustomTitle = "预处理参数";
            wGroupBox2.Location = new Point(559, 81);
            wGroupBox2.Name = "wGroupBox2";
            wGroupBox2.Padding = new Padding(0);
            wGroupBox2.Size = new Size(310, 377);
            wGroupBox2.TabIndex = 1;
            wGroupBox2.TabStop = false;
            wGroupBox2.Text = "wGroupBox2";
            wGroupBox2.TitleFont = new Font("宋体", 12F);
            wGroupBox2.TitlePaddingVertical = 5;
            // 
            // btn_preprocess
            // 
            btn_preprocess.BackColor = SystemColors.Highlight;
            btn_preprocess.Font = new Font("Microsoft YaHei UI", 15F);
            btn_preprocess.ForeColor = SystemColors.Control;
            btn_preprocess.Location = new Point(69, 307);
            btn_preprocess.Name = "btn_preprocess";
            btn_preprocess.Size = new Size(196, 38);
            btn_preprocess.TabIndex = 18;
            btn_preprocess.Text = "执行预处理";
            btn_preprocess.UseVisualStyleBackColor = false;
            btn_preprocess.Click += btn_preprocess_Click;
            // 
            // btn_storagePath
            // 
            btn_storagePath.BackColor = SystemColors.MenuHighlight;
            btn_storagePath.Font = new Font("Microsoft YaHei UI", 12F);
            btn_storagePath.ForeColor = SystemColors.Control;
            btn_storagePath.Location = new Point(247, 244);
            btn_storagePath.Name = "btn_storagePath";
            btn_storagePath.Size = new Size(60, 31);
            btn_storagePath.TabIndex = 17;
            btn_storagePath.Text = "选择";
            btn_storagePath.UseVisualStyleBackColor = false;
            btn_storagePath.Click += btn_storagePath_Click;
            // 
            // btn_samplePath
            // 
            btn_samplePath.BackColor = SystemColors.MenuHighlight;
            btn_samplePath.Font = new Font("Microsoft YaHei UI", 12F);
            btn_samplePath.ForeColor = SystemColors.Control;
            btn_samplePath.Location = new Point(247, 206);
            btn_samplePath.Name = "btn_samplePath";
            btn_samplePath.Size = new Size(60, 31);
            btn_samplePath.TabIndex = 16;
            btn_samplePath.Text = "选择";
            btn_samplePath.UseVisualStyleBackColor = false;
            btn_samplePath.Click += btn_samplePath_Click;
            // 
            // tb_storagePath
            // 
            tb_storagePath.Location = new Point(111, 248);
            tb_storagePath.Name = "tb_storagePath";
            tb_storagePath.Size = new Size(133, 23);
            tb_storagePath.TabIndex = 15;
            // 
            // tb_samplePath
            // 
            tb_samplePath.Location = new Point(111, 210);
            tb_samplePath.Name = "tb_samplePath";
            tb_samplePath.Size = new Size(133, 23);
            tb_samplePath.TabIndex = 14;
            // 
            // tb_maxgrey
            // 
            tb_maxgrey.Location = new Point(111, 174);
            tb_maxgrey.Name = "tb_maxgrey";
            tb_maxgrey.Size = new Size(133, 23);
            tb_maxgrey.TabIndex = 13;
            // 
            // tb_mingrey
            // 
            tb_mingrey.Location = new Point(111, 137);
            tb_mingrey.Name = "tb_mingrey";
            tb_mingrey.Size = new Size(133, 23);
            tb_mingrey.TabIndex = 12;
            // 
            // tb_channels
            // 
            tb_channels.Location = new Point(111, 104);
            tb_channels.Name = "tb_channels";
            tb_channels.Size = new Size(133, 23);
            tb_channels.TabIndex = 11;
            // 
            // tb_imageheight
            // 
            tb_imageheight.Location = new Point(111, 71);
            tb_imageheight.Name = "tb_imageheight";
            tb_imageheight.Size = new Size(133, 23);
            tb_imageheight.TabIndex = 10;
            // 
            // tb_imagewidth
            // 
            tb_imagewidth.Location = new Point(111, 38);
            tb_imagewidth.Name = "tb_imagewidth";
            tb_imagewidth.Size = new Size(133, 23);
            tb_imagewidth.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F);
            label8.Location = new Point(15, 250);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 8;
            label8.Text = "存储路径：";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F);
            label7.Location = new Point(15, 212);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 7;
            label7.Text = "样本路径：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F);
            label6.Location = new Point(15, 173);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 6;
            label6.Text = "最大灰度：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F);
            label5.Location = new Point(15, 138);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 5;
            label5.Text = "最小灰度：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F);
            label4.Location = new Point(15, 104);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 4;
            label4.Text = "通道数：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F);
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(90, 21);
            label3.TabIndex = 3;
            label3.Text = "图像高度：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.Location = new Point(15, 38);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "图像宽度：";
            // 
            // wGroupBox1
            // 
            wGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wGroupBox1.Controls.Add(hswm);
            wGroupBox1.CustomTitle = "显示窗口";
            wGroupBox1.Location = new Point(3, 3);
            wGroupBox1.Name = "wGroupBox1";
            wGroupBox1.Padding = new Padding(0);
            wGroupBox1.Size = new Size(549, 465);
            wGroupBox1.TabIndex = 0;
            wGroupBox1.TabStop = false;
            wGroupBox1.TitleFont = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            wGroupBox1.TitlePaddingVertical = 5;
            // 
            // hswm
            // 
            hswm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hswm.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hswm.Dock = DockStyle.Bottom;
            hswm.HDoubleClickToFitContent = true;
            hswm.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hswm.HImagePart = new Rectangle(-26, 31, 683, 410);
            hswm.HKeepAspectRatio = true;
            hswm.HMoveContent = true;
            hswm.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hswm.Location = new Point(0, 27);
            hswm.Margin = new Padding(0);
            hswm.Name = "hswm";
            hswm.Size = new Size(549, 438);
            hswm.TabIndex = 0;
            hswm.WindowSize = new Size(549, 438);
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(wGroupBox6);
            tabPage2.Controls.Add(wGroupBox5);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(872, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "模型训练";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // wGroupBox6
            // 
            wGroupBox6.Controls.Add(btn_loadModel);
            wGroupBox6.Controls.Add(tb_selModel);
            wGroupBox6.Controls.Add(label17);
            wGroupBox6.Controls.Add(tb_trainPSeed);
            wGroupBox6.Controls.Add(label16);
            wGroupBox6.Controls.Add(tb_trainPBatch);
            wGroupBox6.Controls.Add(label15);
            wGroupBox6.Controls.Add(tb_trainValP);
            wGroupBox6.Controls.Add(label14);
            wGroupBox6.Controls.Add(tb_trainTrainP);
            wGroupBox6.Controls.Add(label13);
            wGroupBox6.Controls.Add(tb_trainPLr);
            wGroupBox6.Controls.Add(label12);
            wGroupBox6.Controls.Add(tb_trainPEvalEpoch);
            wGroupBox6.Controls.Add(label11);
            wGroupBox6.Controls.Add(tb_trainPEpochs);
            wGroupBox6.Controls.Add(label10);
            wGroupBox6.Controls.Add(btn_trainModel);
            wGroupBox6.Controls.Add(label9);
            wGroupBox6.Controls.Add(btn_LoadDs);
            wGroupBox6.CustomTitle = "训练参数设置";
            wGroupBox6.Dock = DockStyle.Right;
            wGroupBox6.Location = new Point(539, 3);
            wGroupBox6.Name = "wGroupBox6";
            wGroupBox6.Padding = new Padding(0);
            wGroupBox6.Size = new Size(330, 458);
            wGroupBox6.TabIndex = 1;
            wGroupBox6.TabStop = false;
            wGroupBox6.Text = "wGroupBox6";
            wGroupBox6.TitleFont = new Font("Arial", 12F);
            wGroupBox6.TitlePaddingVertical = 5;
            // 
            // btn_loadModel
            // 
            btn_loadModel.BackColor = SystemColors.HotTrack;
            btn_loadModel.Font = new Font("Microsoft YaHei UI", 12F);
            btn_loadModel.ForeColor = SystemColors.Control;
            btn_loadModel.Location = new Point(254, 80);
            btn_loadModel.Name = "btn_loadModel";
            btn_loadModel.Size = new Size(62, 35);
            btn_loadModel.TabIndex = 19;
            btn_loadModel.Text = "选择";
            btn_loadModel.UseVisualStyleBackColor = false;
            btn_loadModel.Click += btn_loadModel_Click;
            // 
            // tb_selModel
            // 
            tb_selModel.Enabled = false;
            tb_selModel.Location = new Point(101, 87);
            tb_selModel.Multiline = true;
            tb_selModel.Name = "tb_selModel";
            tb_selModel.Size = new Size(147, 23);
            tb_selModel.TabIndex = 18;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft YaHei UI", 12F);
            label17.Location = new Point(23, 87);
            label17.Name = "label17";
            label17.Size = new Size(90, 21);
            label17.TabIndex = 17;
            label17.Text = "所选模型：";
            // 
            // tb_trainPSeed
            // 
            tb_trainPSeed.Location = new Point(167, 256);
            tb_trainPSeed.Name = "tb_trainPSeed";
            tb_trainPSeed.Size = new Size(149, 23);
            tb_trainPSeed.TabIndex = 16;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft YaHei UI", 12F);
            label16.Location = new Point(23, 257);
            label16.Name = "label16";
            label16.Size = new Size(122, 21);
            label16.TabIndex = 15;
            label16.Text = "设置随机种子：";
            // 
            // tb_trainPBatch
            // 
            tb_trainPBatch.Location = new Point(167, 224);
            tb_trainPBatch.Name = "tb_trainPBatch";
            tb_trainPBatch.Size = new Size(149, 23);
            tb_trainPBatch.TabIndex = 14;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft YaHei UI", 12F);
            label15.Location = new Point(23, 225);
            label15.Name = "label15";
            label15.Size = new Size(122, 21);
            label15.TabIndex = 13;
            label15.Text = "设置批次大小：";
            // 
            // tb_trainValP
            // 
            tb_trainValP.Location = new Point(202, 337);
            tb_trainValP.Name = "tb_trainValP";
            tb_trainValP.Size = new Size(114, 23);
            tb_trainValP.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 12F);
            label14.Location = new Point(23, 338);
            label14.Name = "label14";
            label14.Size = new Size(173, 21);
            label14.TabIndex = 11;
            label14.Text = "验证集比例(1-100%)：";
            // 
            // tb_trainTrainP
            // 
            tb_trainTrainP.Location = new Point(202, 297);
            tb_trainTrainP.Name = "tb_trainTrainP";
            tb_trainTrainP.Size = new Size(114, 23);
            tb_trainTrainP.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 12F);
            label13.Location = new Point(23, 298);
            label13.Name = "label13";
            label13.Size = new Size(173, 21);
            label13.TabIndex = 9;
            label13.Text = "训练集比例(1-100%)：";
            // 
            // tb_trainPLr
            // 
            tb_trainPLr.Location = new Point(167, 192);
            tb_trainPLr.Name = "tb_trainPLr";
            tb_trainPLr.Size = new Size(149, 23);
            tb_trainPLr.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 12F);
            label12.Location = new Point(23, 193);
            label12.Name = "label12";
            label12.Size = new Size(106, 21);
            label12.TabIndex = 7;
            label12.Text = "设置学习率：";
            // 
            // tb_trainPEvalEpoch
            // 
            tb_trainPEvalEpoch.Location = new Point(167, 160);
            tb_trainPEvalEpoch.Name = "tb_trainPEvalEpoch";
            tb_trainPEvalEpoch.Size = new Size(149, 23);
            tb_trainPEvalEpoch.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 12F);
            label11.Location = new Point(23, 161);
            label11.Name = "label11";
            label11.Size = new Size(122, 21);
            label11.TabIndex = 5;
            label11.Text = "设置评估周期：";
            // 
            // tb_trainPEpochs
            // 
            tb_trainPEpochs.Location = new Point(167, 127);
            tb_trainPEpochs.Name = "tb_trainPEpochs";
            tb_trainPEpochs.Size = new Size(149, 23);
            tb_trainPEpochs.TabIndex = 4;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 12F);
            label10.Location = new Point(23, 128);
            label10.Name = "label10";
            label10.Size = new Size(138, 21);
            label10.TabIndex = 3;
            label10.Text = "设置训练总周期：";
            // 
            // btn_trainModel
            // 
            btn_trainModel.BackColor = SystemColors.HotTrack;
            btn_trainModel.Font = new Font("Microsoft YaHei UI", 12F);
            btn_trainModel.ForeColor = SystemColors.Control;
            btn_trainModel.Location = new Point(81, 392);
            btn_trainModel.Name = "btn_trainModel";
            btn_trainModel.Size = new Size(181, 35);
            btn_trainModel.TabIndex = 2;
            btn_trainModel.Text = "训练模型";
            btn_trainModel.UseVisualStyleBackColor = false;
            btn_trainModel.Click += btn_trainModel_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 12F);
            label9.Location = new Point(23, 49);
            label9.Name = "label9";
            label9.Size = new Size(106, 21);
            label9.TabIndex = 1;
            label9.Text = "选择数据集：";
            // 
            // btn_LoadDs
            // 
            btn_LoadDs.BackColor = SystemColors.HotTrack;
            btn_LoadDs.Font = new Font("Microsoft YaHei UI", 12F);
            btn_LoadDs.ForeColor = SystemColors.Control;
            btn_LoadDs.Location = new Point(125, 42);
            btn_LoadDs.Name = "btn_LoadDs";
            btn_LoadDs.Size = new Size(191, 35);
            btn_LoadDs.TabIndex = 0;
            btn_LoadDs.Text = "选择数据集";
            btn_LoadDs.UseVisualStyleBackColor = false;
            btn_LoadDs.Click += btn_LoadDs_Click;
            // 
            // wGroupBox5
            // 
            wGroupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            wGroupBox5.Controls.Add(hswmtrain);
            wGroupBox5.CustomTitle = "训练窗口";
            wGroupBox5.Location = new Point(5, 3);
            wGroupBox5.Name = "wGroupBox5";
            wGroupBox5.Padding = new Padding(0);
            wGroupBox5.Size = new Size(528, 455);
            wGroupBox5.TabIndex = 0;
            wGroupBox5.TabStop = false;
            wGroupBox5.Text = "wGroupBox5";
            wGroupBox5.TitleFont = new Font("Arial", 12F);
            wGroupBox5.TitlePaddingVertical = 5;
            // 
            // hswmtrain
            // 
            hswmtrain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hswmtrain.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hswmtrain.BackColor = Color.Black;
            hswmtrain.Dock = DockStyle.Bottom;
            hswmtrain.HDoubleClickToFitContent = true;
            hswmtrain.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hswmtrain.HImagePart = new Rectangle(-10, 40, 658, 397);
            hswmtrain.HKeepAspectRatio = true;
            hswmtrain.HMoveContent = true;
            hswmtrain.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hswmtrain.Location = new Point(0, 31);
            hswmtrain.Margin = new Padding(0);
            hswmtrain.Name = "hswmtrain";
            hswmtrain.Size = new Size(528, 424);
            hswmtrain.TabIndex = 0;
            hswmtrain.WindowSize = new Size(528, 424);
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(wGroupBox8);
            tabPage3.Controls.Add(wGroupBox7);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(872, 464);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "模型评估";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // wGroupBox8
            // 
            wGroupBox8.Controls.Add(btn_EvalExe);
            wGroupBox8.Controls.Add(btn_3_model);
            wGroupBox8.Controls.Add(tb_3_model);
            wGroupBox8.Controls.Add(label20);
            wGroupBox8.Controls.Add(cbx_data);
            wGroupBox8.Controls.Add(label19);
            wGroupBox8.Controls.Add(cbx_metric);
            wGroupBox8.Controls.Add(label18);
            wGroupBox8.CustomTitle = "评估设置";
            wGroupBox8.Dock = DockStyle.Right;
            wGroupBox8.Location = new Point(538, 0);
            wGroupBox8.Name = "wGroupBox8";
            wGroupBox8.Padding = new Padding(0);
            wGroupBox8.Size = new Size(334, 464);
            wGroupBox8.TabIndex = 1;
            wGroupBox8.TabStop = false;
            wGroupBox8.Text = "wGroupBox8";
            wGroupBox8.TitleFont = new Font("Arial", 12F);
            wGroupBox8.TitlePaddingVertical = 5;
            // 
            // btn_EvalExe
            // 
            btn_EvalExe.BackColor = SystemColors.Highlight;
            btn_EvalExe.Font = new Font("Microsoft YaHei UI", 12F);
            btn_EvalExe.ForeColor = SystemColors.Control;
            btn_EvalExe.Location = new Point(83, 270);
            btn_EvalExe.Name = "btn_EvalExe";
            btn_EvalExe.Size = new Size(166, 42);
            btn_EvalExe.TabIndex = 8;
            btn_EvalExe.Text = "进行评估";
            btn_EvalExe.UseVisualStyleBackColor = false;
            btn_EvalExe.Click += btn_EvalExe_Click;
            // 
            // btn_3_model
            // 
            btn_3_model.BackColor = SystemColors.Highlight;
            btn_3_model.Font = new Font("Microsoft YaHei UI", 11F);
            btn_3_model.ForeColor = SystemColors.Control;
            btn_3_model.Location = new Point(119, 87);
            btn_3_model.Name = "btn_3_model";
            btn_3_model.Size = new Size(193, 34);
            btn_3_model.TabIndex = 7;
            btn_3_model.Text = "选择";
            btn_3_model.UseVisualStyleBackColor = false;
            btn_3_model.Click += btn_3_model_Click;
            // 
            // tb_3_model
            // 
            tb_3_model.Enabled = false;
            tb_3_model.Location = new Point(119, 59);
            tb_3_model.Name = "tb_3_model";
            tb_3_model.Size = new Size(193, 23);
            tb_3_model.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft YaHei UI", 12F);
            label20.Location = new Point(14, 202);
            label20.Name = "label20";
            label20.Size = new Size(90, 21);
            label20.TabIndex = 5;
            label20.Text = "评估数据：";
            // 
            // cbx_data
            // 
            cbx_data.FormattingEnabled = true;
            cbx_data.Items.AddRange(new object[] { "验证集", "测试集" });
            cbx_data.Location = new Point(119, 199);
            cbx_data.Name = "cbx_data";
            cbx_data.Size = new Size(193, 25);
            cbx_data.TabIndex = 4;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft YaHei UI", 12F);
            label19.Location = new Point(14, 142);
            label19.Name = "label19";
            label19.Size = new Size(90, 21);
            label19.TabIndex = 3;
            label19.Text = "评估指标：";
            // 
            // cbx_metric
            // 
            cbx_metric.FormattingEnabled = true;
            cbx_metric.Items.AddRange(new object[] { "precision", "recall", "absolute_confusion_matrix", "relative_confusion_matrix" });
            cbx_metric.Location = new Point(119, 139);
            cbx_metric.Name = "cbx_metric";
            cbx_metric.Size = new Size(193, 25);
            cbx_metric.TabIndex = 2;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft YaHei UI", 12F);
            label18.Location = new Point(14, 61);
            label18.Name = "label18";
            label18.Size = new Size(90, 21);
            label18.TabIndex = 1;
            label18.Text = "选择模型：";
            // 
            // wGroupBox7
            // 
            wGroupBox7.Controls.Add(hswmeval);
            wGroupBox7.CustomTitle = "评估显示窗口";
            wGroupBox7.Dock = DockStyle.Left;
            wGroupBox7.Location = new Point(0, 0);
            wGroupBox7.Name = "wGroupBox7";
            wGroupBox7.Padding = new Padding(0);
            wGroupBox7.Size = new Size(532, 464);
            wGroupBox7.TabIndex = 0;
            wGroupBox7.TabStop = false;
            wGroupBox7.Text = "wGroupBox7";
            wGroupBox7.TitleFont = new Font("Arial", 12F);
            wGroupBox7.TitlePaddingVertical = 5;
            // 
            // hswmeval
            // 
            hswmeval.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hswmeval.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hswmeval.Dock = DockStyle.Bottom;
            hswmeval.HDoubleClickToFitContent = true;
            hswmeval.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hswmeval.HImagePart = new Rectangle(-12, 36, 664, 407);
            hswmeval.HKeepAspectRatio = true;
            hswmeval.HMoveContent = true;
            hswmeval.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hswmeval.Location = new Point(0, 29);
            hswmeval.Margin = new Padding(0);
            hswmeval.Name = "hswmeval";
            hswmeval.Size = new Size(532, 435);
            hswmeval.TabIndex = 0;
            hswmeval.WindowSize = new Size(532, 435);
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(wGroupBox11);
            tabPage4.Controls.Add(wGroupBox10);
            tabPage4.Controls.Add(wGroupBox9);
            tabPage4.Location = new Point(4, 26);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(872, 464);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "模型推理";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // wGroupBox11
            // 
            wGroupBox11.Controls.Add(tb_Time);
            wGroupBox11.Controls.Add(tb_Score);
            wGroupBox11.Controls.Add(tb_retClass);
            wGroupBox11.Controls.Add(label25);
            wGroupBox11.Controls.Add(label24);
            wGroupBox11.Controls.Add(label23);
            wGroupBox11.CustomTitle = "推断结果";
            wGroupBox11.Location = new Point(0, 176);
            wGroupBox11.Name = "wGroupBox11";
            wGroupBox11.Padding = new Padding(0);
            wGroupBox11.Size = new Size(320, 288);
            wGroupBox11.TabIndex = 1;
            wGroupBox11.TabStop = false;
            wGroupBox11.Text = "wGroupBox11";
            wGroupBox11.TitleFont = new Font("Arial", 12F);
            wGroupBox11.TitlePaddingVertical = 5;
            // 
            // tb_Time
            // 
            tb_Time.BackColor = Color.WhiteSmoke;
            tb_Time.BorderStyle = BorderStyle.None;
            tb_Time.Location = new Point(106, 195);
            tb_Time.Multiline = true;
            tb_Time.Name = "tb_Time";
            tb_Time.Size = new Size(201, 39);
            tb_Time.TabIndex = 5;
            // 
            // tb_Score
            // 
            tb_Score.BackColor = Color.WhiteSmoke;
            tb_Score.BorderStyle = BorderStyle.None;
            tb_Score.Location = new Point(106, 130);
            tb_Score.Multiline = true;
            tb_Score.Name = "tb_Score";
            tb_Score.Size = new Size(201, 39);
            tb_Score.TabIndex = 4;
            // 
            // tb_retClass
            // 
            tb_retClass.BackColor = Color.WhiteSmoke;
            tb_retClass.BorderStyle = BorderStyle.None;
            tb_retClass.Location = new Point(106, 65);
            tb_retClass.Multiline = true;
            tb_retClass.Name = "tb_retClass";
            tb_retClass.Size = new Size(201, 39);
            tb_retClass.TabIndex = 3;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft YaHei UI", 13F);
            label25.Location = new Point(15, 201);
            label25.Name = "label25";
            label25.Size = new Size(100, 24);
            label25.TabIndex = 2;
            label25.Text = "推断耗时：";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Microsoft YaHei UI", 13F);
            label24.Location = new Point(15, 135);
            label24.Name = "label24";
            label24.Size = new Size(100, 24);
            label24.TabIndex = 1;
            label24.Text = "推断分数：";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft YaHei UI", 13F);
            label23.Location = new Point(15, 71);
            label23.Name = "label23";
            label23.Size = new Size(100, 24);
            label23.TabIndex = 0;
            label23.Text = "推断类别：";
            // 
            // wGroupBox10
            // 
            wGroupBox10.Controls.Add(hswmInfer);
            wGroupBox10.CustomTitle = "推断结果显示窗口";
            wGroupBox10.Dock = DockStyle.Right;
            wGroupBox10.Location = new Point(326, 0);
            wGroupBox10.Name = "wGroupBox10";
            wGroupBox10.Padding = new Padding(0);
            wGroupBox10.Size = new Size(546, 464);
            wGroupBox10.TabIndex = 1;
            wGroupBox10.TabStop = false;
            wGroupBox10.Text = "wGroupBox10";
            wGroupBox10.TitleFont = new Font("Arial", 12F);
            wGroupBox10.TitlePaddingVertical = 5;
            // 
            // hswmInfer
            // 
            hswmInfer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hswmInfer.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hswmInfer.Dock = DockStyle.Bottom;
            hswmInfer.HDoubleClickToFitContent = true;
            hswmInfer.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hswmInfer.HImagePart = new Rectangle(-21, 35, 682, 409);
            hswmInfer.HKeepAspectRatio = true;
            hswmInfer.HMoveContent = true;
            hswmInfer.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hswmInfer.Location = new Point(0, 27);
            hswmInfer.Margin = new Padding(0);
            hswmInfer.Name = "hswmInfer";
            hswmInfer.Size = new Size(546, 437);
            hswmInfer.TabIndex = 0;
            hswmInfer.WindowSize = new Size(546, 437);
            // 
            // wGroupBox9
            // 
            wGroupBox9.Controls.Add(btn_4_selData);
            wGroupBox9.Controls.Add(btn_4_selModel);
            wGroupBox9.Controls.Add(tb2);
            wGroupBox9.Controls.Add(tb1);
            wGroupBox9.Controls.Add(btn_4_ExeInfer);
            wGroupBox9.Controls.Add(label22);
            wGroupBox9.Controls.Add(label21);
            wGroupBox9.CustomTitle = "推断设置";
            wGroupBox9.Location = new Point(0, 3);
            wGroupBox9.Name = "wGroupBox9";
            wGroupBox9.Padding = new Padding(0);
            wGroupBox9.Size = new Size(320, 167);
            wGroupBox9.TabIndex = 0;
            wGroupBox9.TabStop = false;
            wGroupBox9.Text = "wGroupBox9";
            wGroupBox9.TitleFont = new Font("Arial", 12F);
            wGroupBox9.TitlePaddingVertical = 5;
            // 
            // btn_4_selData
            // 
            btn_4_selData.BackColor = SystemColors.HotTrack;
            btn_4_selData.ForeColor = SystemColors.ControlLightLight;
            btn_4_selData.Location = new Point(264, 78);
            btn_4_selData.Name = "btn_4_selData";
            btn_4_selData.Size = new Size(53, 36);
            btn_4_selData.TabIndex = 6;
            btn_4_selData.Text = "选择";
            btn_4_selData.UseVisualStyleBackColor = false;
            btn_4_selData.Click += btn_4_selData_Click;
            // 
            // btn_4_selModel
            // 
            btn_4_selModel.BackColor = SystemColors.HotTrack;
            btn_4_selModel.ForeColor = SystemColors.ControlLightLight;
            btn_4_selModel.Location = new Point(264, 35);
            btn_4_selModel.Name = "btn_4_selModel";
            btn_4_selModel.Size = new Size(53, 36);
            btn_4_selModel.TabIndex = 5;
            btn_4_selModel.Text = "选择";
            btn_4_selModel.UseVisualStyleBackColor = false;
            btn_4_selModel.Click += btn_4_selModel_Click;
            // 
            // tb2
            // 
            tb2.Location = new Point(89, 84);
            tb2.Name = "tb2";
            tb2.ScrollBars = ScrollBars.Vertical;
            tb2.Size = new Size(169, 23);
            tb2.TabIndex = 4;
            // 
            // tb1
            // 
            tb1.Location = new Point(89, 42);
            tb1.Name = "tb1";
            tb1.Size = new Size(169, 23);
            tb1.TabIndex = 3;
            // 
            // btn_4_ExeInfer
            // 
            btn_4_ExeInfer.BackColor = SystemColors.HotTrack;
            btn_4_ExeInfer.ForeColor = SystemColors.ControlLightLight;
            btn_4_ExeInfer.Location = new Point(53, 120);
            btn_4_ExeInfer.Name = "btn_4_ExeInfer";
            btn_4_ExeInfer.Size = new Size(227, 36);
            btn_4_ExeInfer.TabIndex = 2;
            btn_4_ExeInfer.Text = "执行推断";
            btn_4_ExeInfer.UseVisualStyleBackColor = false;
            btn_4_ExeInfer.Click += btn_4_ExeInfer_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft YaHei UI", 12F);
            label22.Location = new Point(5, 86);
            label22.Name = "label22";
            label22.Size = new Size(90, 21);
            label22.TabIndex = 1;
            label22.Text = "推断数据：";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 12F);
            label21.Location = new Point(5, 41);
            label21.Name = "label21";
            label21.Size = new Size(90, 21);
            label21.TabIndex = 0;
            label21.Text = "推断模型：";
            // 
            // wGroupBox3
            // 
            wGroupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            wGroupBox3.Controls.Add(rtb);
            wGroupBox3.CustomTitle = "系统运行日志";
            wGroupBox3.Location = new Point(0, 494);
            wGroupBox3.Name = "wGroupBox3";
            wGroupBox3.Padding = new Padding(0);
            wGroupBox3.Size = new Size(877, 123);
            wGroupBox3.TabIndex = 3;
            wGroupBox3.TabStop = false;
            wGroupBox3.Text = "wGroupBox3";
            wGroupBox3.TitleFont = new Font("宋体", 12F);
            wGroupBox3.TitlePaddingVertical = 5;
            // 
            // rtb
            // 
            rtb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb.Location = new Point(0, 22);
            rtb.Name = "rtb";
            rtb.Size = new Size(877, 101);
            rtb.TabIndex = 0;
            rtb.Text = "";
            // 
            // DLBattery
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 620);
            Controls.Add(wGroupBox3);
            Controls.Add(tabControl1);
            Name = "DLBattery";
            Text = "电池分类深度学习项目";
            Load += DLBattery_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            wGroupBox4.ResumeLayout(false);
            wGroupBox4.PerformLayout();
            wGroupBox2.ResumeLayout(false);
            wGroupBox2.PerformLayout();
            wGroupBox1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            wGroupBox6.ResumeLayout(false);
            wGroupBox6.PerformLayout();
            wGroupBox5.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            wGroupBox8.ResumeLayout(false);
            wGroupBox8.PerformLayout();
            wGroupBox7.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            wGroupBox11.ResumeLayout(false);
            wGroupBox11.PerformLayout();
            wGroupBox10.ResumeLayout(false);
            wGroupBox9.ResumeLayout(false);
            wGroupBox9.PerformLayout();
            wGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Control.WGroupBox wGroupBox1;
        private Control.WGroupBox wGroupBox2;
        private Control.WGroupBox wGroupBox4;
        private HalconDotNet.HSmartWindowControl hswm;
        private Control.WGroupBox wGroupBox3;
        private RichTextBox rtb;
        private Label label1;
        private ComboBox cbx_loadModel;
        private Button btn_samplePath;
        private TextBox tb_storagePath;
        private TextBox tb_samplePath;
        private TextBox tb_maxgrey;
        private TextBox tb_mingrey;
        private TextBox tb_channels;
        private TextBox tb_imageheight;
        private TextBox tb_imagewidth;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_storagePath;
        private Button btn_preprocess;
        private Control.WGroupBox wGroupBox6;
        private Button btn_trainModel;
        private Label label9;
        private Button btn_LoadDs;
        private Control.WGroupBox wGroupBox5;
        private HalconDotNet.HSmartWindowControl hswmtrain;
        private TextBox tb_trainPSeed;
        private Label label16;
        private TextBox tb_trainPBatch;
        private Label label15;
        private TextBox tb_trainValP;
        private Label label14;
        private TextBox tb_trainTrainP;
        private Label label13;
        private TextBox tb_trainPLr;
        private Label label12;
        private TextBox tb_trainPEvalEpoch;
        private Label label11;
        private TextBox tb_trainPEpochs;
        private Label label10;
        private TextBox tb_selModel;
        private Label label17;
        private Button btn_loadModel;
        private Control.WGroupBox wGroupBox8;
        private Control.WGroupBox wGroupBox7;
        private Label label18;
        private HalconDotNet.HSmartWindowControl hswmeval;
        private Label label20;
        private ComboBox cbx_data;
        private Label label19;
        private ComboBox cbx_metric;
        private TextBox tb_3_model;
        private Button btn_3_model;
        private Button btn_EvalExe;
        private Control.WGroupBox wGroupBox9;
        private Control.WGroupBox wGroupBox11;
        private Control.WGroupBox wGroupBox10;
        private HalconDotNet.HSmartWindowControl hswmInfer;
        private Button btn_4_selData;
        private Button btn_4_selModel;
        private TextBox tb2;
        private TextBox tb1;
        private Button btn_4_ExeInfer;
        private Label label22;
        private Label label21;
        private TextBox tb_Time;
        private TextBox tb_Score;
        private TextBox tb_retClass;
        private Label label25;
        private Label label24;
        private Label label23;
    }
}