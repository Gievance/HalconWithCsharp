using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalconWithCsharp.AdhesiveBead
{
    /// <summary>
    /// 日志工具类
    /// </summary>
    public sealed class LogTool
    {

        private static ListView sys_log;
        private static bool isInitialized = false;

        public static void Info(string log)
        {
            AddLog(0, log);
        }

        public static void Warning(string log)
        {
            AddLog(1, log);
        }

        public static void Error(string log)
        {
            AddLog(2, log);
        }


        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="index">ico下标  1info 2警告 3异常</param>
        /// <param name="log">消息</param>
        private static void AddLog(int index, string log)
        {
            /*
             1. main函数启动的时候是ui线程，打印的日志不用走委托
             
             2. 如果点击了按钮，然后执行逻辑(则还是ui线程)，然后打印日志.不用走委托.
             LogUtil.Info("直接打印日志");

             3. 如果点击了按钮，然后开启了异步线程(则不是ui线程)，然后打印日志，就需要走委托。
             Task.Run(() => {
                LogUtil.Info("异步线程打印的日志");
             });
             */
            //从非 UI 线程调用时，使用 Invoke 方法来保证在 UI 线程上执行更新操作，从而避免跨线程访问控件的问题。
            if (sys_log.InvokeRequired)//如果当前线程不是 UI 线程，那么这个属性返回 true
            {
                sys_log.Invoke(new Action(() =>
                {
                    ListViewItem listViewItem = new ListViewItem(" " + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + " ", index);
                    listViewItem.SubItems.Add(log);
                    sys_log.Items.Insert(0, listViewItem);
                }));
            }
            else
            {
                ListViewItem listViewItem = new ListViewItem(" " + DateTime.Now.ToString("yyyyMMdd HH:mm:ss") + " ", index);
                listViewItem.SubItems.Add(log);
                sys_log.Items.Insert(0, listViewItem);
            }
        }

        // 初始化时传入 ListView
        public static void Initialize(ListView logListView)
        {
            if (isInitialized)
            {
                throw new InvalidOperationException("LogUtil已初始化。");
            }
            sys_log = logListView;

            // 创建图标
            ImageList logIco = new ImageList();
            logIco.ColorDepth = ColorDepth.Depth32Bit;
            logIco.ImageSize = new Size(16, 16); // 根据图标大小调整
            logIco.TransparentColor = Color.Magenta; // 设置透明色
            //Application.StartupPath
            string directoryPath = @"..\..\..\icons\"; // 相对路径
            string[] filenames =  { "info.ico", "warning.ico", "error.ico" };
            // 遍历文件并将图标添加到 ImageList 中
            foreach (string filename in filenames)
            {
                string filePath = Path.Combine(directoryPath, filename);
                if (File.Exists(filePath))
                {
                    using (Icon icon = new Icon(filePath))
                    {
                        Bitmap bitmap = icon.ToBitmap();
                        logIco.Images.Add(bitmap);
                    }
                }
                else
                {
                    Console.WriteLine($"文件不存在：{filePath}");
                }
            }
            // 将 ImageList 控件添加到控件中
            // 例如，可以将 ImageList 与 ListBox 或 ComboBox 结合使用
            sys_log.SmallImageList = logIco;


            // 设置日志相关信息
            sys_log.Items.Clear();
            // 设置 ListView 的视图模式为 Details
            sys_log.View = View.Details;
            // 设置 ListView 的全选模式
            sys_log.FullRowSelect = true;
            // 设置 ListView 的网格线
            sys_log.GridLines = true;
            // 添加第一列（时间）
            var timeColumn = new ColumnHeader();
            timeColumn.Text = "时间";
            timeColumn.Width = 220; // 设置列宽
            //timeColumn.TextAlign = HorizontalAlignment.Center;// 居中显示标题
            sys_log.Columns.Add(timeColumn);
            // 添加第二列（文本）
            var textColumn = new ColumnHeader();
            textColumn.Text = "文本";
            textColumn.Width = sys_log.Width - sys_log.Columns[0].Width; // 设置列宽
            //textColumn.TextAlign = HorizontalAlignment.Center; // 居中显示标题
            sys_log.Columns.Add(textColumn);
            // 隐藏列标题(不用写下面两行就隐藏成功了，写了有几率导致列宽不生效。)
            sys_log.HeaderStyle = ColumnHeaderStyle.None;// 隐藏所有列标题

            sys_log.MouseDoubleClick += sys_log_MouseDoubleClick;
            isInitialized = true;
        }

        /// <summary>
        /// 通过这个事件，可以双击左键复制日志文本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void sys_log_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView listview = (ListView)sender;
            ListViewItem lstrow = listview.GetItemAt(e.X, e.Y);
            ListViewItem.ListViewSubItem lstcol = lstrow.GetSubItemAt(e.X, e.Y);
            string strText = lstcol.Text;
            try
            {
                Clipboard.SetDataObject(strText);
                //string info = string.Format("内容【{0}】已经复制到剪贴板", strText);
                //ReaLTaiizor.Controls.MaterialSnackBar SnackBarMessage = new ReaLTaiizor.Controls.MaterialSnackBar(info, "OK", true);
                //SnackBarMessage.Show(this);
                //MessageBox.Show(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===============================  单例  ======================
        private LogTool()
        {
        }
         

        //private static readonly object _lock = new object();
        //private static LogUtil _instance = null;

        /* 我们直接通过 Initialize 方法就初始化了我们想要的动作，然后直接调用静态方法打日志。不需要手动创建LogUtil对象了。
         public static LogUtil Instance    //单例
         {
             get
             {
                 if (_instance == null)
                 {
                     lock (_lock)
                     {
                         if (_instance == null)
                         {
                             _instance = new LogUtil();
                         }
                     }
                 }
                 return _instance;
             }
         }*/
    }
}
