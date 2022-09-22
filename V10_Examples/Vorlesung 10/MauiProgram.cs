namespace Vorlesung_10;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("FA6-Regular.otf", "FontAwesomeRegular");
                fonts.AddFont("FA6-Solid.otf", "FontAwesomeSolid");
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                fonts.AddFont("Roboto-Italic.ttf", "RobotoItalic");
                fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
            });

        return builder.Build();
    }
}
