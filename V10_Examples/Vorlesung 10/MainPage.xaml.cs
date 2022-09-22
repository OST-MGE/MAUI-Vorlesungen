using Vorlesung_10.Pages.Resources;
using Vorlesung_10.Pages.Styles;
using Vorlesung_10.Pages.Theming;
using Vorlesung_10.Pages.Views;

namespace Vorlesung_10;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ShowPageInCurrentWindow<TPage>() where TPage : Page, new() => Navigation.PushAsync(new TPage());

    private void Images_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<ImagePage>();

    private void Fonts_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<FontPage>();

    private void Brushes_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<BrushPage>();

    private void Borders_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<BorderPage>();

    private void Animation_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<AnimationPage>();

    private void PlatformDifferences_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<PlatformDifferencesPage>();

    private void Resources_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<ResourcesPage>();

    private void Styles_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<StylesPage>();

    private void Theming_OnClicked(object sender, EventArgs e) => ShowPageInCurrentWindow<ThemingPage>();
}

