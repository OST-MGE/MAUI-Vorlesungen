namespace Vorlesung_12;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ShowPageInCurrentWindow<TPage>() where TPage : Page, new() => Navigation.PushAsync(new TPage());

    private void Classic_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<Classic.View.UserPage>();

    private void Pierced_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<Pierced.View.UserPage>();
}
