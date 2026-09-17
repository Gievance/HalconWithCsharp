using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace HalconWithCsharp.Pipe3DMatching.Models
{
    public class Register
    {
        [Category("局部配准"),DisplayName("配准方式")]
        public string method { get; set; } = "matching";

        [Category("局部配准"),DisplayName("配准参数名")]
        public string GenParamName { get; set; } = "default_parameters";
        
        [Category("局部配准"),DisplayName("配准参数值")]
        public string GenParamValue { get; set; } = "accurate";


        [Browsable(false)]
        [Category("局部配准-阈值"), DisplayName("最小点数")]
        public int minPoint { get; set; } = 0;
        [Browsable(false)]
        [Category("局部配准-阈值"), DisplayName("最大点数")]
        public int maxPoint { get; set; } = 20000;

        [Category("局部配准-筛选"), DisplayName("最小云点数")]
        public int PointNum { get; set; } = 20000;
        [Category("局部配准-筛选"), DisplayName("匹配得分")]
        public float MatchScore { get; set; } = 0.8f;

    }
}
