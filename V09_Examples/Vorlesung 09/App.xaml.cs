namespace Vorlesung_09;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        Helpers.Log(nameof(App), nameof(CreateWindow));

        var window = base.CreateWindow(activationState);

        window.Title = "Vorlesung 09";
        Helpers.SubscribeToLifecycleEvents(window);

        return window;
    }

    #region Lifecycle Events

    protected override void OnStart()
    {
        Helpers.Log(nameof(App), nameof(OnStart));
        base.OnStart();
    }

    protected override void OnResume()
    {
        Helpers.Log(nameof(App), nameof(OnResume));
        base.OnResume();
    }

    protected override void OnSleep()
    {
        Helpers.Log(nameof(App), nameof(OnSleep));
        base.OnSleep();
    }

    #endregion
}
