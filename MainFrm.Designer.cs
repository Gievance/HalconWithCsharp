namespace HalconWithCsharp_CarCard
{
    partial class MainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            hwmc = new HalconDotNet.HSmartWindowControl();
            groupBox2 = new GroupBox();
            propertyGrid = new PropertyGrid();
            groupBox3 = new GroupBox();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hwmc);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(817, 824);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "窗口显示";
            // 
            // hwmc
            // 
            hwmc.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            hwmc.AutoValidate = AutoValidate.EnableAllowFocusChange;
            hwmc.HDoubleClickToFitContent = true;
            hwmc.HDrawingObjectsModifier = HalconDotNet.HSmartWindowControl.DrawingObjectsModifier.None;
            hwmc.HImagePart = new Rectangle(-185, -123, 1010, 726);
            hwmc.HKeepAspectRatio = true;
            hwmc.HMoveContent = true;
            hwmc.HZoomContent = HalconDotNet.HSmartWindowControl.ZoomContent.WheelForwardZoomsIn;
            hwmc.Location = new Point(7, 41);
            hwmc.Margin = new Padding(0);
            hwmc.Name = "hwmc";
            hwmc.Size = new Size(809, 777);
            hwmc.TabIndex = 0;
            hwmc.WindowSize = new Size(809, 777);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(propertyGrid);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox2.Location = new Point(817, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(750, 824);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "属性栏";
            // 
            // propertyGrid
            // 
            propertyGrid.BackColor = SystemColors.Control;
            propertyGrid.Location = new Point(6, 38);
            propertyGrid.Name = "propertyGrid";
            propertyGrid.Size = new Size(397, 770);
            propertyGrid.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn8);
            groupBox3.Controls.Add(btn7);
            groupBox3.Controls.Add(btn6);
            groupBox3.Controls.Add(btn5);
            groupBox3.Controls.Add(btn4);
            groupBox3.Controls.Add(btn3);
            groupBox3.Controls.Add(btn2);
            groupBox3.Controls.Add(btn1);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.Font = new Font("Microsoft YaHei UI", 12F);
            groupBox3.Location = new Point(1225, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(342, 824);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "选项";
            // 
            // btn8
            // 
            btn8.Location = new Point(8, 514);
            btn8.Name = "btn8";
            btn8.Size = new Size(326, 60);
            btn8.TabIndex = 7;
            btn8.Text = "提取目标";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(8, 448);
            btn7.Name = "btn7";
            btn7.Size = new Size(326, 60);
            btn7.TabIndex = 6;
            btn7.Text = "仿射变换";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(8, 382);
            btn6.Name = "btn6";
            btn6.Size = new Size(326, 60);
            btn6.TabIndex = 5;
            btn6.Text = "形态学处理";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(9, 310);
            btn5.Name = "btn5";
            btn5.Size = new Size(326, 60);
            btn5.TabIndex = 4;
            btn5.Text = "区域选择";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(9, 244);
            btn4.Name = "btn4";
            btn4.Size = new Size(326, 60);
            btn4.TabIndex = 3;
            btn4.Text = "区域砍断";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(9, 178);
            btn3.Name = "btn3";
            btn3.Size = new Size(326, 60);
            btn3.TabIndex = 2;
            btn3.Text = "阈值处理";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(9, 112);
            btn2.Name = "btn2";
            btn2.Size = new Size(326, 60);
            btn2.TabIndex = 1;
            btn2.Text = "灰度化处理";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(9, 46);
            btn1.Name = "btn1";
            btn1.Size = new Size(326, 60);
            btn1.TabIndex = 0;
            btn1.Text = "图像采集";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 824);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MainFrm";
            Text = "车牌矫正系统";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private HalconDotNet.HSmartWindowControl hwmc;
        private GroupBox groupBox2;
        private PropertyGrid propertyGrid;
        private GroupBox groupBox3;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
    }
}
