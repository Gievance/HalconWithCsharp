using System.ComponentModel;
namespace HalconWithCsharp_CarCard.Models
{
    public class FeatureConverter:StringConverter
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
            var list = new List<string> { "area", "row","column","width","height"};
            return new StandardValuesCollection(list);
        }
    }
}