namespace Vorlesung_14;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

    private async void MenuItem1_OnClicked(object sender, EventArgs e) => await Current.GoToAsync("//fo1/tab2");

    private async void MenuItem2_OnClicked(object sender, EventArgs e) => await Current.GoToAsync("..");
}
