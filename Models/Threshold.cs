using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace HalconWithCsharp_CarCard.Models
{
    public class Threshold
    {
        [DisplayName("最小灰度值")]
        public int mingray { get; set; } = 0;
        [DisplayName("最大灰度值")]
        public int maxgray { get; set; } = 80;
    }
}
