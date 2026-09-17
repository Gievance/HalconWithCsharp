using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
namespace HalconWithCsharp.Pipe3DMatching.MyControl
{
    /// <summary>
    /// 朝夕自定义GroupBox
    /// </summary>
    public class ZhaoxiGroupBox : GroupBox
    {
        private Color _backgroundColor = ColorTranslator.FromHtml("#006CBE"); // 默认背景颜色
        private string _customTitle = ""; // 默认标题
        private ContentAlignment _titleAlignment = ContentAlignment.TopLeft; // 默认标题位置为左上角
        private int _titleHeight = 70; // 标题背景条的高度

        // 设置背景颜色
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "#006CBE")]
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; this.Invalidate(); } // 更新背景颜色并重新绘制
        }

        // 设置自定义标题文本
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("GroupBox")]
        public string CustomTitle
        {
            get { return _customTitle; }
            set { _customTitle = value; this.Invalidate(); } // 更新标题文本并重新绘制
        }

        // 设置标题位置
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(ContentAlignment.BottomLeft)]
        public ContentAlignment TitleAlignment
        {
            get { return _titleAlignment; }
            set { _titleAlignment = value; this.Invalidate(); } // 更新标题位置并重新绘制
        }




        // 重写 OnPaint 方法
        protected override void OnPaint(PaintEventArgs e)
        {
            // 获取标题文本
            string text = _customTitle;

            // 设置标题背景颜色和区域
            Color titleBackColor = _backgroundColor;

            // 计算标题背景区域 (宽度适配控件，保持固定高度)
            Rectangle titleRect = new Rectangle(0, 0, this.Width, _titleHeight);

            // 填充标题背景
            using (Brush titleBackBrush = new SolidBrush(titleBackColor))
            {
                e.Graphics.FillRectangle(titleBackBrush, titleRect);
            }

            // 设置标题文本的颜色
            Color titleTextColor = Color.White;

            // 设置标题字体
            using (Font titleFont = new Font("Arial", 12, FontStyle.Bold))
            {
                // 计算标题文本的位置
                Point titleLocation = GetTitleLocation(titleFont, text, _titleHeight);

                // 绘制标题文本
                TextRenderer.DrawText(e.Graphics, text, titleFont, titleLocation, titleTextColor);
            }

            // 设置裁剪区域，只让子控件的内容区域绘制
            Rectangle contentRect = new Rectangle(0, _titleHeight, this.Width, this.Height - _titleHeight);
            e.Graphics.SetClip(contentRect);

            // 绘制控件的内容区域，子控件等内容，确保标题区域不被覆盖
            base.OnPaint(e);
        }


        // 获取标题位置
        private Point GetTitleLocation(Font titleFont, string titleText, int titleHeight)
        {
            int x = 0, y = 0;

            // 根据标题对齐方式计算位置
            Size textSize = TextRenderer.MeasureText(titleText, titleFont);
            switch (_titleAlignment)
            {
                case ContentAlignment.TopLeft:
                    x = 10;
                    y = (titleHeight - textSize.Height) / 2;
                    break;
                case ContentAlignment.TopCenter:
                    x = (this.Width - textSize.Width) / 2;
                    y = (titleHeight - textSize.Height) / 2;
                    break;
                case ContentAlignment.TopRight:
                    x = this.Width - textSize.Width - 10;
                    y = (titleHeight - textSize.Height) / 2;
                    break;
                case ContentAlignment.BottomLeft:
                    x = 10;
                    y = this.Height - textSize.Height - 10;
                    break;
                case ContentAlignment.BottomCenter:
                    x = (this.Width - textSize.Width) / 2;
                    y = this.Height - textSize.Height - 10;
                    break;
                case ContentAlignment.BottomRight:
                    x = this.Width - textSize.Width - 10;
                    y = this.Height - textSize.Height - 10;
                    break;
            }

            return new Point(x, y);
        }

        // 重写 OnSizeChanged 以确保控件尺寸更改时正确绘制
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Invalidate(); // 强制重新绘制控件
        }

        // 重写 OnLayout 以确保设计时能够正确显示
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            this.Invalidate(); // 强制重新绘制控件
        }
    }

}
