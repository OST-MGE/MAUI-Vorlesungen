namespace Vorlesung_09.Pages.XAML.TypeConverter;

public class LocationControl : Label
{
    public Location Center
    {
        set => Text = $"{value.Latitude} / {value.Longitude}";
    }
}
