using Vorlesung_09.Pages.XAML;

namespace Vorlesung_09;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ShowWindow<TPage>() where TPage : Page, new() => Navigation.PushAsync(new TPage());

    private void XamlVersusCSharp_OnClicked(object sender, EventArgs e) => ShowWindow<XamlVersusCSharp>();

    private void XamlFeatures_OnClicked(object sender, EventArgs e) => ShowWindow<XamlFeatures>();
}
