namespace Vorlesung_10.Pages.Theming;

public partial class ThemingPage : ContentPage
{
	public ThemingPage()
	{
		InitializeComponent();

        LoadThemeBasedOnOperatingSystem();

        Application.Current.RequestedThemeChanged += (_, _) =>
        {
            LoadThemeBasedOnOperatingSystem();
        };
    }

    private void LoadThemeBasedOnOperatingSystem()
    {
        var activeTheme = Application.Current.RequestedTheme;
        var isLightThemeActive = activeTheme == AppTheme.Light;

        if (isLightThemeActive)
            ActivateTheme<LightTheme>();
        else
            ActivateTheme<DarkTheme>();
    }

    private void DarkTheme_OnClicked(object sender, EventArgs e) => ActivateTheme<DarkTheme>();

    private void LightTheme_OnClicked(object sender, EventArgs e) => ActivateTheme<LightTheme>();

    private void ActivateTheme<TTheme>() where TTheme : ResourceDictionary, new()
    {
        var mergedDictionaries = Resources.MergedDictionaries;

        if (mergedDictionaries == null)
            return;

        mergedDictionaries.Clear();
        mergedDictionaries.Add(new TTheme());

        ActiveThemeLabel.Text = $"Aktives Theme: {typeof(TTheme).Name}";
    }
}