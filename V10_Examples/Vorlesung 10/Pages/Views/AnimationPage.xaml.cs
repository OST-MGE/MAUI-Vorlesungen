namespace Vorlesung_10.Pages.Views;

public partial class AnimationPage : ContentPage
{
	public AnimationPage()
	{
		InitializeComponent();
	}

    private async void StartAnimation_OnClicked(object sender, EventArgs e)
    {
        async Task AnimateAsync(int offsetX, int offsetY, double scale, double opacity)
        {
            const int duration = 750;

            await Task.WhenAll
            (
                GhostLabel.TranslateTo(GhostLabel.X + offsetX, GhostLabel.Y + offsetY, duration),
                GhostLabel.RotateTo(360, duration),
                GhostLabel.ScaleTo(scale, duration),
                GhostLabel.FadeTo(opacity, duration)
            );

            GhostLabel.Rotation = 0;
        }

        try
        {
            StartButton.IsEnabled = false;

            await AnimateAsync(100, 100, 1.5, 0.7);
            await AnimateAsync(-100, 100, 0.5, 0.4);
            await AnimateAsync(0, 0, 1.0, 1.0);
        }
        finally
        {
            StartButton.IsEnabled = true;
        }
    }
}