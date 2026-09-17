using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HalconWithCsharp.Pipe3DMatching.Models
{
    public class PreProcess
    {
        [Category("01_子采样"), DisplayName("采样方法")]
        public string sampleMethod { get; set; } = "accurate";

        [Category("01_子采样"), DisplayName("采样距离")]
        public float sampleDistance { get; set; } = 0.5f;

        [Category("01_子采样"), DisplayName("扩展参数名")]
        public string sampleParamName { get; set; } ="min_num_points";

        [Category("01_子采样"), DisplayName("扩展参数值")]
        public string sampleParamValue { get; set; } = "5";

        [Category("02_平滑"), DisplayName("平滑方法")]
        public string smoothMethod { get; set; } = "mls";

        [Category("02_平滑"), DisplayName("扩展参数名")]
        public string smoothParamName { get; set; } = "mls_force_inwards";

        [Category("02_平滑"), DisplayName("扩展参数值")]
        public string smoothParamValue { get; set; } = "true";

        [Category("03_三角化"), DisplayName("三角化方法")]
        public string triangleMethod { get; set; } = "greedy";

        [Category("03_三角化"), DisplayName("扩展参数名")]
        public string triangleParamName { get; set; } = "";

        [Category("03_三角化"), DisplayName("扩展参数值")]
        public string triangleParamValue { get; set; } = "";

    }
}
