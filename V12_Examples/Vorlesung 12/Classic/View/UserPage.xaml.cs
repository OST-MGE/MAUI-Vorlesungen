using Vorlesung_12.Classic.Model;
using Vorlesung_12.Classic.ViewModel;

namespace Vorlesung_12.Classic.View;

public partial class UserPage : ContentPage
{
	public UserPage()
	{
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