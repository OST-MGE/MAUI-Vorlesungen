using System.ComponentModel;
using System.Globalization;

namespace Vorlesung_09.Pages.XAML.TypeConverter;

public class LocationConverter : System.ComponentModel.TypeConverter
{
    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        var valueAsString = (string) value;
        var valueArray = valueAsString.Split(',');

        return new Location
        {
            Latitude = Convert.ToDouble(valueArray[0]),
            Longitude = Convert.ToDouble(valueArray[1])
        };
    }
}
