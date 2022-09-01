using System.ComponentModel;

namespace Vorlesung_09.Pages.XAML.TypeConverter;

[TypeConverter(typeof(LocationConverter))]
public class Location
{
    public double Latitude { get; set; }

    public double Longitude { get; set; }
}
