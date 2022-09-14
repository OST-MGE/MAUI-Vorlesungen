using Vorlesung_11.Pages;

namespace Vorlesung_11;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        window.Title = "Vorlesung 11";

        return window;
    }
}
