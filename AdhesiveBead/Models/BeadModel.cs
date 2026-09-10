using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel;

namespace HalconWithCsharp.AdhesiveBead.Models
{
    public class BeadModel
    {
        [DisplayName("宽度")]
        [Category("模版参数")]
        public int thickness { get; set; }
        [DisplayName("容忍度")]
        [Category("模版参数")]
        public int tolerance { get; set; }
        [DisplayName("位置容忍度")]
        [Category("模版参数")]
        public int pos_tolerance { get; set; }
    }
}
