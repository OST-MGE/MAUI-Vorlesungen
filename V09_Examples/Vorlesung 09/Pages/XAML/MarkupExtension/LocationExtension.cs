namespace Vorlesung_09.Pages.XAML.MarkupExtension;

public class LocationExtension : IMarkupExtension<string>
{
    public string Latitude { get; set; }

    public string Longitude { get; set; }

    public string ProvideValue(IServiceProvider serviceProvider) => Latitude + " / " + Longitude;

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
}