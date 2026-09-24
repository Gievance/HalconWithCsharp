using System;
using System.Collections.Generic;
using System.Text;

namespace HalconWithCsharp.GenericTools
{
    public class MyTools
    {
        /// <summary>
        /// 从OpenFile对话框中获取选中文件路径
        /// </summary>
        /// <param name="initialPath">初始路径</param>
        /// <param name="filterFile">文件筛选</param>
        /// <returns></returns>
        public static string GetOpenFilePath(string initialPath,string filterFile = "txt")
        {

            string ret_string = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                
                ofd.Title = "选择要打开的文件";
                if (initialPath == null || initialPath.IsWhiteSpace())
                {
                    ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                }
                else
                {
                    ofd.InitialDirectory = initialPath;
                }

                ofd.Filter = $"待定|*.{filterFile}";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ret_string = ofd.FileName;
                }
            }
            return ret_string;
        }

        /// <summary>
        /// 从OpenFile对话框中获取 多个 选中文件路径
        /// </summary>
        /// <param name="initialPath">初始路径</param>
        /// <param name="filterFile">文件筛选</param>
        /// <returns></returns>
        public static List<string> GetOpenFilePaths(string initialPath, string filterFile="txt")
        {

            List<string> ret_string=new List<string>();
            using (OpenFileDialog ofd = new OpenFileDialog())
            {

                ofd.Title = "选择要打开的文件";
                ofd.Multiselect = true;
                if (initialPath == null || initialPath.IsWhiteSpace())
                {
                    ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                }
                else
                {
                    ofd.InitialDirectory = initialPath;
                }

                ofd.Filter = $"待定|*.{filterFile}";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ret_string.AddRange(ofd.FileNames);
                }
            }
            return ret_string;
        }


        public static void SimpMessageBox(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK);
        }
    }
}
