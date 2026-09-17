namespace HalconWithCsharp.Pipe3DMatching
{
    partial class PipeFrm
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
            zhaoxiGroupBox4 = new ZXCustomControlLib.ZhaoxiGroupBox();
            rtbLog = new RichTextBox();
            zhaoxiGroupBox1 = new ZXCustomControlLib.ZhaoxiGroupBox();
            hswm = new HalconDotNet.HSmartWindowControl();
            zhaoxiGroupBox2 = new ZXCustomControlLib.ZhaoxiGroupBox();
            procGrid = new PropertyGrid();
            zhaoxiGroupBox3 = new ZXCustomControlLib.ZhaoxiGroupBox();
            groupBox2 = new GroupBox();
            btn_exeSurfaceMatch = new Button();
            btn_LoadMatching = new Button();
            btn_createSurface = new Button();
            btn_PreProcess = new Button();
            groupBox1 = new GroupBox();
            btn_Register = new Button();
            btn_LoadPoint = new Button();
            btn_exePair = new Button();
            zhaoxiGroupBox4.SuspendLayout();
            zhaoxiGroupBox1.SuspendLayout();
            zhaoxiGroupBox2.SuspendLayout();
            zhaoxiGroupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // zhaoxiGroupBox4
            // 
            zhaoxiGroupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zhaoxiGroupBox4.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox4.Controls.Add(rtbLog);
            zhaoxiGroupBox4.CustomTitle = "";
            zhaoxiGroupBox4.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox4.ForeColor = SystemColors.ButtonHighlight;
            zhaoxiGroupBox4.Location = new Point(6, 456);
            zhaoxiGroupBox4.Margin = new Padding(2);
            zhaoxiGroupBox4.Name = "zhaoxiGroupBox4";
            zhaoxiGroupBox4.Padding = new Padding(2);
            zhaoxiGroupBox4.Size = new Size(1072, 157);
            zhaoxiGroupBox4.TabIndex = 3;
            zhaoxiGroupBox4.TabStop = false;
            zhaoxiGroupBox4.Text = "运行日志";
            zhaoxiGroupBox4.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // rtbLog
            // 
            rtbLog.Dock = DockStyle.Fill;
            rtbLog.Location = new Point(2, 23);
            rtbLog.Margin = new Padding(2);
            rtbLog.Name = "rtbLog";
            rtbLog.Size = new Size(1068, 132);
            rtbLog.TabIndex = 0;
            rtbLog.Text = "";
            // 
            // zhaoxiGroupBox1
            // 
            zhaoxiGroupBox1.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox1.Controls.Add(hswm);
            zhaoxiGroupBox1.CustomTitle = "";
            zhaoxiGroupBox1.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox1.ForeColor = SystemColors.ButtonHighlight;
            zhaoxiGroupBox1.Location = new Point(6, 2);
            zhaoxiGroupBox1.Margin = new Padding(2);
            zhaoxiGroupBox1.Name = "zhaoxiGroupBox1";
            zhaoxiGroupBox1.Padding = new Padding(2);
            zhaoxiGroupBox1.Size = new Size(573, 450);
            zhaoxiGroupBox1.TabIndex = 4;
            zhaoxiGroupBox1.TabStop = false;
            zhaoxiGroupBox1.Text = "显示窗口";
            zhaoxiGroupBox1.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // hswm
            // 
            hswm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hswm.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hswm.Dock = DockStyle.Fill;
            hswm.HDoubleClickToFitContent = true;
            hswm.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hswm.HImagePart = new Rectangle(-37, 45, 712, 389);
            hswm.HKeepAspectRatio = true;
            hswm.HMoveContent = true;
            hswm.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hswm.Location = new Point(2, 23);
            hswm.Margin = new Padding(0);
            hswm.Name = "hswm";
            hswm.Size = new Size(569, 425);
            hswm.TabIndex = 0;
            hswm.WindowSize = new Size(569, 425);
            // 
            // zhaoxiGroupBox2
            // 
            zhaoxiGroupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            zhaoxiGroupBox2.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox2.Controls.Add(procGrid);
            zhaoxiGroupBox2.CustomTitle = "";
            zhaoxiGroupBox2.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox2.ForeColor = SystemColors.ButtonHighlight;
            zhaoxiGroupBox2.Location = new Point(583, 2);
            zhaoxiGroupBox2.Margin = new Padding(2);
            zhaoxiGroupBox2.Name = "zhaoxiGroupBox2";
            zhaoxiGroupBox2.Padding = new Padding(2);
            zhaoxiGroupBox2.Size = new Size(272, 385);
            zhaoxiGroupBox2.TabIndex = 5;
            zhaoxiGroupBox2.TabStop = false;
            zhaoxiGroupBox2.Text = "参数设置";
            zhaoxiGroupBox2.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // procGrid
            // 
            procGrid.BackColor = SystemColors.Control;
            procGrid.Dock = DockStyle.Fill;
            procGrid.Location = new Point(2, 23);
            procGrid.Margin = new Padding(2);
            procGrid.Name = "procGrid";
            procGrid.Size = new Size(268, 360);
            procGrid.TabIndex = 0;
            // 
            // zhaoxiGroupBox3
            // 
            zhaoxiGroupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            zhaoxiGroupBox3.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox3.Controls.Add(groupBox2);
            zhaoxiGroupBox3.Controls.Add(groupBox1);
            zhaoxiGroupBox3.CustomTitle = "";
            zhaoxiGroupBox3.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox3.ForeColor = SystemColors.ButtonHighlight;
            zhaoxiGroupBox3.Location = new Point(858, 2);
            zhaoxiGroupBox3.Margin = new Padding(2);
            zhaoxiGroupBox3.Name = "zhaoxiGroupBox3";
            zhaoxiGroupBox3.Padding = new Padding(2);
            zhaoxiGroupBox3.Size = new Size(218, 450);
            zhaoxiGroupBox3.TabIndex = 6;
            zhaoxiGroupBox3.TabStop = false;
            zhaoxiGroupBox3.Text = "选项界面";
            zhaoxiGroupBox3.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_exeSurfaceMatch);
            groupBox2.Controls.Add(btn_LoadMatching);
            groupBox2.Controls.Add(btn_createSurface);
            groupBox2.Controls.Add(btn_PreProcess);
            groupBox2.Location = new Point(3, 176);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(210, 246);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "表面匹配";
            // 
            // btn_exeSurfaceMatch
            // 
            btn_exeSurfaceMatch.BackColor = SystemColors.Highlight;
            btn_exeSurfaceMatch.Location = new Point(14, 202);
            btn_exeSurfaceMatch.Margin = new Padding(2);
            btn_exeSurfaceMatch.Name = "btn_exeSurfaceMatch";
            btn_exeSurfaceMatch.Size = new Size(192, 40);
            btn_exeSurfaceMatch.TabIndex = 6;
            btn_exeSurfaceMatch.Text = "表面匹配操作";
            btn_exeSurfaceMatch.UseVisualStyleBackColor = false;
            btn_exeSurfaceMatch.Click += btn_exeSurfaceMatch_Click;
            // 
            // btn_LoadMatching
            // 
            btn_LoadMatching.BackColor = SystemColors.Highlight;
            btn_LoadMatching.Location = new Point(12, 143);
            btn_LoadMatching.Margin = new Padding(2);
            btn_LoadMatching.Name = "btn_LoadMatching";
            btn_LoadMatching.Size = new Size(192, 40);
            btn_LoadMatching.TabIndex = 5;
            btn_LoadMatching.Text = "加载待匹配点云数据";
            btn_LoadMatching.UseVisualStyleBackColor = false;
            btn_LoadMatching.Click += btn_LoadMatching_Click;
            // 
            // btn_createSurface
            // 
            btn_createSurface.BackColor = SystemColors.Highlight;
            btn_createSurface.Location = new Point(14, 90);
            btn_createSurface.Margin = new Padding(2);
            btn_createSurface.Name = "btn_createSurface";
            btn_createSurface.Size = new Size(192, 40);
            btn_createSurface.TabIndex = 4;
            btn_createSurface.Text = "制作3D表面匹配模版";
            btn_createSurface.UseVisualStyleBackColor = false;
            btn_createSurface.Click += btn_createSurface_Click;
            // 
            // btn_PreProcess
            // 
            btn_PreProcess.BackColor = SystemColors.Highlight;
            btn_PreProcess.Location = new Point(12, 33);
            btn_PreProcess.Margin = new Padding(2);
            btn_PreProcess.Name = "btn_PreProcess";
            btn_PreProcess.Size = new Size(192, 40);
            btn_PreProcess.TabIndex = 3;
            btn_PreProcess.Text = "3D对象预处理";
            btn_PreProcess.UseVisualStyleBackColor = false;
            btn_PreProcess.Click += btn_PreProcess_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_Register);
            groupBox1.Controls.Add(btn_LoadPoint);
            groupBox1.Location = new Point(3, 32);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(214, 140);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "管道重建";
            // 
            // btn_Register
            // 
            btn_Register.BackColor = SystemColors.Highlight;
            btn_Register.Location = new Point(12, 86);
            btn_Register.Margin = new Padding(2);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(192, 40);
            btn_Register.TabIndex = 1;
            btn_Register.Text = "配准操作";
            btn_Register.UseVisualStyleBackColor = false;
            btn_Register.Click += btn_Register_Click;
            // 
            // btn_LoadPoint
            // 
            btn_LoadPoint.BackColor = SystemColors.Highlight;
            btn_LoadPoint.Location = new Point(12, 35);
            btn_LoadPoint.Margin = new Padding(2);
            btn_LoadPoint.Name = "btn_LoadPoint";
            btn_LoadPoint.Size = new Size(192, 40);
            btn_LoadPoint.TabIndex = 0;
            btn_LoadPoint.Text = "加载参考点云";
            btn_LoadPoint.UseVisualStyleBackColor = false;
            btn_LoadPoint.Click += btn_LoadPoint_Click;
            // 
            // btn_exePair
            // 
            btn_exePair.Anchor = AnchorStyles.Top;
            btn_exePair.Location = new Point(656, 402);
            btn_exePair.Name = "btn_exePair";
            btn_exePair.Size = new Size(134, 40);
            btn_exePair.TabIndex = 7;
            btn_exePair.Text = "功能";
            btn_exePair.UseVisualStyleBackColor = true;
            btn_exePair.Click += btn_exePair_Click;
            // 
            // PipeFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 620);
            Controls.Add(btn_exePair);
            Controls.Add(zhaoxiGroupBox3);
            Controls.Add(zhaoxiGroupBox2);
            Controls.Add(zhaoxiGroupBox1);
            Controls.Add(zhaoxiGroupBox4);
            Name = "PipeFrm";
            Text = "管道3D重建与表面匹配";
            FormClosing += FrmClosing;
            FormClosed += FrmClosed;
            Load += PipeFrm_Load;
            zhaoxiGroupBox4.ResumeLayout(false);
            zhaoxiGroupBox1.ResumeLayout(false);
            zhaoxiGroupBox2.ResumeLayout(false);
            zhaoxiGroupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ZXCustomControlLib.ZhaoxiGroupBox zhaoxiGroupBox4;
        private RichTextBox rtbLog;
        private ZXCustomControlLib.ZhaoxiGroupBox zhaoxiGroupBox1;
        private HalconDotNet.HSmartWindowControl hswm;
        private ZXCustomControlLib.ZhaoxiGroupBox zhaoxiGroupBox2;
        private PropertyGrid procGrid;
        private ZXCustomControlLib.ZhaoxiGroupBox zhaoxiGroupBox3;
        private Button btn_Register;
        private Button btn_LoadPoint;
        private Button btn_exeSurfaceMatch;
        private Button btn_LoadMatching;
        private Button btn_createSurface;
        private Button btn_PreProcess;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_exePair;
    }
}