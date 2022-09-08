using Vorlesung_09.Pages.GUI;
using Vorlesung_09.Pages.XAML;

namespace Vorlesung_09;

public partial class MainPage : ContentPage
{
    private int _windowCounter;

    public MainPage()
    {
        InitializeComponent();
    }

    private void ShowPageInCurrentWindow<TPage>() where TPage : Page, new() => Navigation.PushAsync(new TPage());

    private void ShowPageInNewWindow<TPage>(string title = null) where TPage : Page, new()
    {
        title ??= $"Fenster #{++_windowCounter}";

        var window = new Window(new TPage())
        {
            Title = title
        };

        Helpers.SubscribeToLifecycleEvents(window);
        Application.Current.OpenWindow(window);
    }

    private void XamlVersusCSharp_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<XamlVersusCSharp>();

    private void XamlFeatures_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<XamlFeatures>();

    private void OpenWindow_OnClicked(object sender, EventArgs e) => ShowPageInNewWindow<XamlFeatures>();

    private void TabbedPage_OnClicked(object sender, EventArgs e) => ShowPageInNewWindow<Pages.GUI.TabbedPage>("Tabbed Page");

    private void FlyoutPage_OnClicked(object sender, EventArgs e) => ShowPageInNewWindow<Pages.GUI.FlyoutPage>("Flyout Page");

    private void Layouts_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<LayoutsPage>();

    private void Controls_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<ControlsPage>();
}
