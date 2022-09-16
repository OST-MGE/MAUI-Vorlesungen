using Vorlesung_13.I18n;
using Vorlesung_13.Threading;

namespace Vorlesung_13;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ShowPageInCurrentWindow<TPage>() where TPage : Page, new() => Navigation.PushAsync(new TPage());

    private void Threading_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<ThreadingPage>();

    private void I18n_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<I18nPage>();
}

