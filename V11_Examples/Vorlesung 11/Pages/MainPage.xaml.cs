using Vorlesung_11.Model;

namespace Vorlesung_11.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void ShowDataBindingPage(object sender, Func<IUser> createUser)
    {
        var page = new DataBindingPage(createUser)
        {
            Title = ((Button)sender).Text
        };

        Navigation.PushAsync(page);
    }

    private void POCO_OnClicked(object sender, EventArgs e) => ShowDataBindingPage(sender, () => new User());
    
    private void INPC_OnClicked(object sender, EventArgs e) => ShowDataBindingPage(sender, () => new UserWithINPC());
    
    private void BB_OnClicked(object sender, EventArgs e) => ShowDataBindingPage(sender, () => new UserWithBase());
}

