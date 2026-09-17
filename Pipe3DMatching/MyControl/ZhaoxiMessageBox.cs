using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalconWithCsharp.Pipe3DMatching.MyControl
{
    /// <summary>
    /// 朝夕自定义的对话框
    /// </summary>
    public class ZhaoxiMessageBox : Form
    {
        private Button okButton;
        // Define the LinkLabel
        private LinkLabel fileLinkLabel;
        // Define the close button area
        private Rectangle closeButtonRect;

        // 存储鼠标按下的位置
        private Point mouseOffset;
        private bool isDragging = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Messagee { get; set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Path { get; set; }

        public ZhaoxiMessageBox(Form owner, bool showLabel=false)
        {
            // 设置对话框大小
            this.Size = new Size(300, 150);
            this.StartPosition = FormStartPosition.Manual; // 设置为手动定位
            this.FormBorderStyle = FormBorderStyle.None; // 移除默认边框
            this.TopMost = true; // 确保对话框在最前面

            // 计算对话框的中心位置并设置
            int x = owner.Left + (owner.Width - this.Width) / 2;
            int y = owner.Top + (owner.Height - this.Height) / 2;
            this.Location = new Point(x, y);

            // 设置对话框的父窗体
            this.Owner = owner;

            if (showLabel)
            {
                // Add the LinkLabel for opening file
                fileLinkLabel = new LinkLabel();
                fileLinkLabel.Text = "点击这里打开文件";
                fileLinkLabel.Location = new Point(20, 80); // Positioning it below the message
                fileLinkLabel.LinkClicked += FileLinkLabel_LinkClicked;
                this.Controls.Add(fileLinkLabel);

            }
            else 
            {
                // 添加确定按钮
                okButton = new Button();
                okButton.Text = "确定";
                okButton.Size = new Size(75, 30);
                okButton.Location = new Point((this.Width - okButton.Width) / 2, this.Height - okButton.Height - 20);
                okButton.Click += OkButton_Click;
                this.Controls.Add(okButton);
            }
            

            // 添加鼠标事件处理
            this.MouseDown += CustomMessageBox_MouseDown;
            this.MouseMove += CustomMessageBox_MouseMove;
            this.MouseUp += CustomMessageBox_MouseUp;

            // Mouse click event to handle close button click
            this.MouseClick += CustomMessageBox_MouseClick;

            this.Load += ZhaoxiMessageBox_Load;
        }

        private void ZhaoxiMessageBox_Load(object sender, EventArgs e)
        {
            SetDialogSize();
        }

        // 基于消息的内容设置对话框大小
        private void SetDialogSize()
        {
            // Measure the message string width
            using (Graphics g = this.CreateGraphics())
            {
                SizeF messageSize = g.MeasureString(Messagee, new Font("Arial", 10));
                int width = (int)messageSize.Width + 40; // Add some padding
                int height = (int)messageSize.Height + 60; // Adjust height based on the message height

                // Set a minimum width and height
                if (width < 300)
                    width = 300;
                if (height < 150)
                    height = 150;

                this.Size = new Size(width, height);
            }

            // Recalculate the position based on the new size
            int x = this.Owner.Left + (this.Owner.Width - this.Width) / 2;
            int y = this.Owner.Top + (this.Owner.Height - this.Height) / 2;
            this.Location = new Point(x, y);
        }

        // 处理点击确定按钮事件
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 点击右上角关闭
        private void CustomMessageBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (closeButtonRect.Contains(e.Location))
            {
                // 点击右上角关闭标识关闭对话框
                this.Close(); 
            }
        }

        private void FileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create OpenFileDialog to choose a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Path;
            openFileDialog.ShowDialog();
        }

        // 处理鼠标按下事件，记录鼠标偏移
        private void CustomMessageBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseOffset = new Point(e.X, e.Y); // 记录鼠标按下的位置
            }
        }

        // 处理鼠标移动事件，拖动窗体
        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // 计算新的窗体位置
                Point newLocation = this.Location;
                newLocation.X += e.X - mouseOffset.X;
                newLocation.Y += e.Y - mouseOffset.Y;
                this.Location = newLocation;
            }
        }

        // 处理鼠标松开事件，停止拖动
        private void CustomMessageBox_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        // 重写 Paint 方法绘制自定义标题栏
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            // 绘制蓝色背景条
            g.FillRectangle(Brushes.DodgerBlue, 0, 0, this.Width, 40); // 蓝色条的高度为 40px

            // 绘制标题文本
            using (Font titleFont = new Font("Arial", 12, FontStyle.Bold))
            {
                g.DrawString("提示", titleFont, Brushes.White, new PointF(20, 10));
            }

            // 绘制提示信息
            using (Font messageFont = new Font("Arial", 10))
            {
                g.DrawString(Messagee, messageFont, Brushes.Black, new PointF(20, 50));
            }

            // 绘制右上角的关闭字符串
            using (Font closeFont = new Font("Arial", 12, FontStyle.Bold))
            {
                string closeText = "X";
                SizeF closeSize = g.MeasureString(closeText, closeFont);
                closeButtonRect = new Rectangle(this.Width - (int)closeSize.Width - 10, 10, (int)closeSize.Width, (int)closeSize.Height);
                g.DrawString(closeText, closeFont, Brushes.White, closeButtonRect);
            }
        }
    }
}
