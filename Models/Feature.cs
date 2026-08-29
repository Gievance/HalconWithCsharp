using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.ComponentModel.TypeConverter;
namespace HalconWithCsharp_CarCard.Models
{
    public class Feature
    {
        [Category("区域选择")]
        [DisplayName("特征操作")]
        [TypeConverter(typeof(FeatureConverter))]
        public string feature { get; set; } = "area";

        [Category("区域选择")]
        [DisplayName("区域操作")]
        [TypeConverter(typeof(OperatorConverter))]
        public string opera { get; set; } = "and";

        [Category("区域选择")]
        [DisplayName("最小值")]
        public int minval { get; set; } = 350000;

        [Category("区域选择")]
        [DisplayName("最大值")]
        public int maxval { get; set; } = 360000;
    }

    public class OperatorConverter:StringConverter
    {
        public override bool GetStandardValuesSupported(ITypeDescriptorContext? context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext? context)
        {
            return true;
        }

        public override StandardValuesCollection? GetStandardValues(ITypeDescriptorContext? context)
        {
            var list = new List<string> { "and", "or"};
            return new StandardValuesCollection(list);
        }
    }
}
