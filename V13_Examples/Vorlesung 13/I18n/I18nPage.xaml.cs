using System.Globalization;

namespace Vorlesung_13.I18n;

public partial class I18nPage : ContentPage
{
    private const string KeyDE = "de";
    private const string KeyEN = "en";

    public I18nPage()
	{
        if (!IsLanguageInitialized)
        {
            SetResxTranslations(KeyDE);
        }

        SetResourceTranslations(ActiveLanguage);

        InitializeComponent();
    }

    private static bool IsLanguageInitialized => RESX.Translations.Culture != null;

    private static string ActiveLanguage => RESX.Translations.Culture.TwoLetterISOLanguageName;

    private static void SetResxTranslations(string key)
    {
        RESX.Translations.Culture = new CultureInfo(key);
    }

    private void SetResourceTranslations(string key)
    {
        const string assemblyName = "Vorlesung 13";
        var typeName = $"Vorlesung_13.I18n.Resources.Translations_{key.ToUpperInvariant()}";

        // ReSharper disable once PossibleNullReferenceException
        var rd = (ResourceDictionary)Activator.CreateInstance(assemblyName, typeName).Unwrap();

        foreach (var rdKey in rd.Keys)
        {
            Resources[rdKey] = rd[rdKey];
        }
    }

    private void ButtonDE_OnClicked(object sender, EventArgs e)
    {
        SetResourceTranslations(KeyDE);
        SetResxTranslations(KeyDE);
    }

    private void ButtonEN_OnClicked(object sender, EventArgs e)
    {
        SetResourceTranslations(KeyEN);
        SetResxTranslations(KeyEN);
    }
}