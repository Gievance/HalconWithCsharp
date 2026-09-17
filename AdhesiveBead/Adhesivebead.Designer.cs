using HalconWithCsharp.AdhesiveBead.MyControl;

namespace HalconWithCsharp.AdhesiveBead
{
    partial class Adhesivebead
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
            zhaoxiGroupBox1 = new HalconWithCsharp.AdhesiveBead.MyControl.ZhaoxiGroupBox();
            hswm = new HalconDotNet.HSmartWindowControl();
            zhaoxiGroupBox2 = new HalconWithCsharp.AdhesiveBead.MyControl.ZhaoxiGroupBox();
            panel = new Panel();
            proBeanModel = new PropertyGrid();
            btn_preBead = new Button();
            btn_action = new Button();
            btn_loadDetImage = new Button();
            btn_drawBeadPos = new Button();
            btn_drawBeadWidth = new Button();
            btn_createBeadModel = new Button();
            btn_drawBead = new Button();
            btn_createModel = new Button();
            btn_getRefRegion = new Button();
            btn_loadRefImage = new Button();
            zhaoxiGroupBox3 = new HalconWithCsharp.AdhesiveBead.MyControl.ZhaoxiGroupBox();
            logview = new ListView();
            zhaoxiGroupBox1.SuspendLayout();
            zhaoxiGroupBox2.SuspendLayout();
            panel.SuspendLayout();
            zhaoxiGroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // zhaoxiGroupBox1
            // 
            zhaoxiGroupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zhaoxiGroupBox1.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox1.Controls.Add(hswm);
            zhaoxiGroupBox1.CustomTitle = "";
            zhaoxiGroupBox1.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox1.ForeColor = SystemColors.Control;
            zhaoxiGroupBox1.Location = new Point(9, 0);
            zhaoxiGroupBox1.Name = "zhaoxiGroupBox1";
            zhaoxiGroupBox1.Size = new Size(1315, 772);
            zhaoxiGroupBox1.TabIndex = 0;
            zhaoxiGroupBox1.TabStop = false;
            zhaoxiGroupBox1.Text = "点胶质量检测可视化区域";
            zhaoxiGroupBox1.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // hswm
            // 
            hswm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hswm.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hswm.Dock = DockStyle.Fill;
            hswm.HDoubleClickToFitContent = true;
            hswm.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hswm.HImagePart = new Rectangle(-495, -103, 1630, 686);
            hswm.HKeepAspectRatio = true;
            hswm.HMoveContent = true;
            hswm.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hswm.Location = new Point(3, 34);
            hswm.Margin = new Padding(0);
            hswm.Name = "hswm";
            hswm.Size = new Size(1309, 735);
            hswm.TabIndex = 0;
            hswm.WindowSize = new Size(1309, 735);
            // 
            // zhaoxiGroupBox2
            // 
            zhaoxiGroupBox2.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox2.Controls.Add(panel);
            zhaoxiGroupBox2.Controls.Add(btn_createModel);
            zhaoxiGroupBox2.Controls.Add(btn_getRefRegion);
            zhaoxiGroupBox2.Controls.Add(btn_loadRefImage);
            zhaoxiGroupBox2.CustomTitle = "";
            zhaoxiGroupBox2.Dock = DockStyle.Right;
            zhaoxiGroupBox2.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox2.ForeColor = SystemColors.Control;
            zhaoxiGroupBox2.Location = new Point(1330, 0);
            zhaoxiGroupBox2.Name = "zhaoxiGroupBox2";
            zhaoxiGroupBox2.Size = new Size(381, 936);
            zhaoxiGroupBox2.TabIndex = 1;
            zhaoxiGroupBox2.TabStop = false;
            zhaoxiGroupBox2.Text = "操作区域";
            zhaoxiGroupBox2.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // panel
            // 
            panel.Controls.Add(proBeanModel);
            panel.Controls.Add(btn_preBead);
            panel.Controls.Add(btn_action);
            panel.Controls.Add(btn_loadDetImage);
            panel.Controls.Add(btn_drawBeadPos);
            panel.Controls.Add(btn_drawBeadWidth);
            panel.Controls.Add(btn_createBeadModel);
            panel.Controls.Add(btn_drawBead);
            panel.Location = new Point(16, 232);
            panel.Name = "panel";
            panel.Size = new Size(340, 692);
            panel.TabIndex = 11;
            // 
            // proBeanModel
            // 
            proBeanModel.BackColor = SystemColors.Control;
            proBeanModel.HelpVisible = false;
            proBeanModel.Location = new Point(7, 152);
            proBeanModel.Name = "proBeanModel";
            proBeanModel.Size = new Size(326, 273);
            proBeanModel.TabIndex = 11;
            // 
            // btn_preBead
            // 
            btn_preBead.BackColor = SystemColors.Highlight;
            btn_preBead.FlatStyle = FlatStyle.Flat;
            btn_preBead.Location = new Point(169, 12);
            btn_preBead.Name = "btn_preBead";
            btn_preBead.Size = new Size(153, 75);
            btn_preBead.TabIndex = 10;
            btn_preBead.Text = "采用预定以参考胶路";
            btn_preBead.UseVisualStyleBackColor = false;
            btn_preBead.Click += btn_preBead_Click;
            // 
            // btn_action
            // 
            btn_action.BackColor = SystemColors.Highlight;
            btn_action.FlatStyle = FlatStyle.Flat;
            btn_action.Location = new Point(7, 631);
            btn_action.Name = "btn_action";
            btn_action.Size = new Size(326, 53);
            btn_action.TabIndex = 8;
            btn_action.Text = "执行胶路质量检测";
            btn_action.UseVisualStyleBackColor = false;
            btn_action.Click += btn_action_Click;
            // 
            // btn_loadDetImage
            // 
            btn_loadDetImage.BackColor = SystemColors.Highlight;
            btn_loadDetImage.FlatStyle = FlatStyle.Flat;
            btn_loadDetImage.Location = new Point(7, 572);
            btn_loadDetImage.Name = "btn_loadDetImage";
            btn_loadDetImage.Size = new Size(326, 53);
            btn_loadDetImage.TabIndex = 7;
            btn_loadDetImage.Text = "加载检测图";
            btn_loadDetImage.UseVisualStyleBackColor = false;
            btn_loadDetImage.Click += btn_loadDetImage_Click;
            // 
            // btn_drawBeadPos
            // 
            btn_drawBeadPos.BackColor = SystemColors.Highlight;
            btn_drawBeadPos.FlatStyle = FlatStyle.Flat;
            btn_drawBeadPos.Location = new Point(7, 502);
            btn_drawBeadPos.Name = "btn_drawBeadPos";
            btn_drawBeadPos.Size = new Size(326, 53);
            btn_drawBeadPos.TabIndex = 6;
            btn_drawBeadPos.Text = "绘制胶路偏移范围轮廓";
            btn_drawBeadPos.UseVisualStyleBackColor = false;
            btn_drawBeadPos.Click += btn_drawBeadPos_Click;
            // 
            // btn_drawBeadWidth
            // 
            btn_drawBeadWidth.BackColor = SystemColors.Highlight;
            btn_drawBeadWidth.FlatStyle = FlatStyle.Flat;
            btn_drawBeadWidth.Location = new Point(7, 443);
            btn_drawBeadWidth.Name = "btn_drawBeadWidth";
            btn_drawBeadWidth.Size = new Size(326, 53);
            btn_drawBeadWidth.TabIndex = 5;
            btn_drawBeadWidth.Text = "绘制胶宽范围轮廓";
            btn_drawBeadWidth.UseVisualStyleBackColor = false;
            btn_drawBeadWidth.Click += btn_drawBeadWidth_Click;
            // 
            // btn_createBeadModel
            // 
            btn_createBeadModel.BackColor = SystemColors.Highlight;
            btn_createBeadModel.FlatStyle = FlatStyle.Flat;
            btn_createBeadModel.Location = new Point(7, 93);
            btn_createBeadModel.Name = "btn_createBeadModel";
            btn_createBeadModel.Size = new Size(326, 53);
            btn_createBeadModel.TabIndex = 4;
            btn_createBeadModel.Text = "创建胶路参考模版";
            btn_createBeadModel.UseVisualStyleBackColor = false;
            btn_createBeadModel.Click += btn_createBeadModel_Click;
            // 
            // btn_drawBead
            // 
            btn_drawBead.BackColor = SystemColors.Highlight;
            btn_drawBead.FlatStyle = FlatStyle.Flat;
            btn_drawBead.Location = new Point(17, 12);
            btn_drawBead.Name = "btn_drawBead";
            btn_drawBead.Size = new Size(146, 75);
            btn_drawBead.TabIndex = 3;
            btn_drawBead.Text = "绘制参考胶路区域轮廓";
            btn_drawBead.UseVisualStyleBackColor = false;
            btn_drawBead.Click += btn_drawBead_Click;
            // 
            // btn_createModel
            // 
            btn_createModel.BackColor = SystemColors.Highlight;
            btn_createModel.FlatStyle = FlatStyle.Flat;
            btn_createModel.Location = new Point(23, 173);
            btn_createModel.Name = "btn_createModel";
            btn_createModel.Size = new Size(326, 53);
            btn_createModel.TabIndex = 2;
            btn_createModel.Text = "创建检测区域模版";
            btn_createModel.UseVisualStyleBackColor = false;
            btn_createModel.Click += btn_createModel_Click;
            // 
            // btn_getRefRegion
            // 
            btn_getRefRegion.BackColor = SystemColors.Highlight;
            btn_getRefRegion.FlatStyle = FlatStyle.Flat;
            btn_getRefRegion.Location = new Point(23, 114);
            btn_getRefRegion.Name = "btn_getRefRegion";
            btn_getRefRegion.Size = new Size(326, 53);
            btn_getRefRegion.TabIndex = 1;
            btn_getRefRegion.Text = "获取检测区域";
            btn_getRefRegion.UseVisualStyleBackColor = false;
            btn_getRefRegion.Click += btn_getRefRegion_Click;
            // 
            // btn_loadRefImage
            // 
            btn_loadRefImage.BackColor = SystemColors.Highlight;
            btn_loadRefImage.FlatStyle = FlatStyle.Flat;
            btn_loadRefImage.Location = new Point(23, 55);
            btn_loadRefImage.Name = "btn_loadRefImage";
            btn_loadRefImage.Size = new Size(326, 53);
            btn_loadRefImage.TabIndex = 0;
            btn_loadRefImage.Text = "加载参考图像";
            btn_loadRefImage.UseVisualStyleBackColor = false;
            btn_loadRefImage.Click += btn_loadRefImage_Click;
            // 
            // zhaoxiGroupBox3
            // 
            zhaoxiGroupBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zhaoxiGroupBox3.BackgroundColor = Color.FromArgb(0, 108, 190);
            zhaoxiGroupBox3.Controls.Add(logview);
            zhaoxiGroupBox3.CustomTitle = "";
            zhaoxiGroupBox3.Font = new Font("Microsoft YaHei UI", 12F);
            zhaoxiGroupBox3.ForeColor = SystemColors.Control;
            zhaoxiGroupBox3.Location = new Point(11, 778);
            zhaoxiGroupBox3.Name = "zhaoxiGroupBox3";
            zhaoxiGroupBox3.Size = new Size(1313, 158);
            zhaoxiGroupBox3.TabIndex = 2;
            zhaoxiGroupBox3.TabStop = false;
            zhaoxiGroupBox3.Text = "运行日志";
            zhaoxiGroupBox3.TitleAlignment = ContentAlignment.TopLeft;
            // 
            // logview
            // 
            logview.Dock = DockStyle.Fill;
            logview.Location = new Point(3, 34);
            logview.Name = "logview";
            logview.Size = new Size(1307, 121);
            logview.TabIndex = 0;
            logview.UseCompatibleStateImageBehavior = false;
            // 
            // Adhesivebead
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1711, 936);
            Controls.Add(zhaoxiGroupBox3);
            Controls.Add(zhaoxiGroupBox2);
            Controls.Add(zhaoxiGroupBox1);
            Name = "Adhesivebead";
            Text = "胶路质量检测";
            Load += Adhesivebead_Load;
            zhaoxiGroupBox1.ResumeLayout(false);
            zhaoxiGroupBox2.ResumeLayout(false);
            panel.ResumeLayout(false);
            zhaoxiGroupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ZhaoxiGroupBox zhaoxiGroupBox1;
        private ZhaoxiGroupBox zhaoxiGroupBox2;
        private Button btn_drawBeadWidth;
        private Button btn_createBeadModel;
        private Button btn_drawBead;
        private Button btn_createModel;
        private Button btn_getRefRegion;
        private Button btn_loadRefImage;
        private ZhaoxiGroupBox zhaoxiGroupBox3;
        private Button btn_preBead;
        private Button btn_action;
        private Button btn_loadDetImage;
        private Button btn_drawBeadPos;
        private HalconDotNet.HSmartWindowControl hswm;
        private ListView logview;
        private Panel panel;
        private PropertyGrid proBeanModel;
    }
}