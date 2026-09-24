using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace HalconWithCsharp.DLWithClassification_Battery.Control
{
    public class WGroupBox : GroupBox
    {
        private Color _backgroundColor = ColorTranslator.FromHtml("#006CBE");
        private string _customTitle = "WGroupBox";
        private ContentAlignment _titleAlignment = ContentAlignment.TopLeft;
        private Font _titleFont = new Font("Arial", 12, FontStyle.Regular);
        private int _titlePaddingVertical = 5; // 标题上下内边距，可属性暴露

        #region 属性（支持设计器）
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(typeof(Color), "#006CBE")]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set { _backgroundColor = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("")]
        public string CustomTitle
        {
            get => _customTitle;
            set { _customTitle = value; Invalidate(); }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(ContentAlignment.TopLeft)]
        public ContentAlignment TitleAlignment
        {
            get => _titleAlignment;
            set { _titleAlignment = value; Invalidate(); }
        }

        /// <summary>
        /// 标题字体，设计器可直接修改，修改后标题栏高度自动变化
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Font TitleFont
        {
            get => _titleFont;
            set
            {
                if (_titleFont != null) _titleFont.Dispose();
                _titleFont = value ?? new Font("Arial", 12, FontStyle.Bold);
                Invalidate();
            }
        }

        /// <summary>
        /// 标题文字上下内边距，控制标题栏留白大小
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(10)]
        public int TitlePaddingVertical
        {
            get => _titlePaddingVertical;
            set { _titlePaddingVertical = value; Invalidate(); }
        }
        #endregion

        // 根据字体和文字计算【顶部标题栏高度】
        private int CalcTitleBarHeight()
        {
            if (string.IsNullOrEmpty(_customTitle))
                return 10; // 无标题时标题栏高度0

            Size textSize = TextRenderer.MeasureText(_customTitle, _titleFont);
            // 文字高度 + 上下边距
            return textSize.Height + _titlePaddingVertical * 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            string text = _customTitle;
            Color titleBackColor = _backgroundColor;
            int titleBarHeight = CalcTitleBarHeight();

            // 判断：对齐是顶部模式，才绘制顶部标题背景条
            bool isTopTitle = _titleAlignment == ContentAlignment.TopLeft ||
                              _titleAlignment == ContentAlignment.TopCenter ||
                              _titleAlignment == ContentAlignment.TopRight;

            if (isTopTitle && titleBarHeight > 0)
            {
                Rectangle titleRect = new Rectangle(0, 0, this.Width, titleBarHeight);
                using (Brush titleBackBrush = new SolidBrush(titleBackColor))
                {
                    e.Graphics.FillRectangle(titleBackBrush, titleRect);
                }
            }

            Color titleTextColor = Color.White;
            Point titleLocation = GetTitleLocation(_titleFont, text, titleBarHeight);
            TextRenderer.DrawText(e.Graphics, text, _titleFont, titleLocation, titleTextColor);

            Rectangle borderRect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
            using (Pen pen = new Pen(Color.Gray, 1))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, borderRect);
            }

            Rectangle contentRect = new Rectangle(0, titleBarHeight, this.Width, this.Height - titleBarHeight);
            e.Graphics.SetClip(contentRect);


            // 裁剪内容区域：如果是顶部标题，内容区域从标题栏下方开始
            //Rectangle contentRect;
            //if (isTopTitle)
            //{
            //    contentRect = new Rectangle(0, titleBarHeight, this.Width, this.Height - titleBarHeight);
            //}
            //else
            //{
            //    // Bottom系列对齐，标题不占顶部条，内容区域占满整个控件
            //    contentRect = new Rectangle(0, 0, this.Width, this.Height);
            //}
            //e.Graphics.SetClip(contentRect);

            //base.OnPaint(e);
        }

        private Point GetTitleLocation(Font titleFont, string titleText, int titleBarHeight)
        {
            int x = 0, y = 0;
            Size textSize = TextRenderer.MeasureText(titleText, titleFont);

            switch (_titleAlignment)
            {
                case ContentAlignment.TopLeft:
                    x = 10;
                    y = (titleBarHeight - textSize.Height) / 2;
                    break;
                case ContentAlignment.TopCenter:
                    x = (this.Width - textSize.Width) / 2;
                    y = (titleBarHeight - textSize.Height) / 2;
                    break;
                case ContentAlignment.TopRight:
                    x = this.Width - textSize.Width - 10;
                    y = (titleBarHeight - textSize.Height) / 2;
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

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }

        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            this.Padding = new Padding(0, 0, 0, 0);
            Invalidate();
        }

        // 释放字体资源，防止GDI泄漏！
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _titleFont?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}