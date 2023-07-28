namespace Vorlesung_10.Pages.Resources;

public partial class ResourcesPage : ContentPage
{
	public ResourcesPage()
	{
		InitializeComponent();
	}

    private void UpdateResource_OnClicked(object sender, EventArgs eventArgs)
    {
        Resources["OSTBrush"] = new SolidColorBrush(Colors.DarkBlue);
    }
}