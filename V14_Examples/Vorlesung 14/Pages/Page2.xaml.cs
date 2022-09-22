namespace Vorlesung_14.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private async void Button_OnClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }
}