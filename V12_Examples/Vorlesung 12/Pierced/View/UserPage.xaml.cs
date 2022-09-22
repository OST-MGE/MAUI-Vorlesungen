using Vorlesung_12.Pierced.Model;
using Vorlesung_12.Pierced.ViewModel;

namespace Vorlesung_12.Pierced.View;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
		InitializeComponent();

        InitializeComponent();

        var user = new User
        {
            FirstName = "Thomas",
            LastName = "Kälin",
            Age = 38
        };

        BindingContext = new UserViewModel(user);
    }
}