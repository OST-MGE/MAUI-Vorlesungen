using System.Collections.ObjectModel;
using Vorlesung_11.Model;

namespace Vorlesung_11.Pages;

public partial class DataBindingPage : ContentPage
{
    private readonly Func<IUser> _createUser;

    public DataBindingPage(Func<IUser> createUser)
    {
        InitializeComponent();

        _createUser = createUser;

        User = _createUser();
        Users = CreateUsers(20);

        BindingContext = this;
    }

    #region Properties for Bindings

    public IUser User { get; }

    public ObservableCollection<IUser> Users { get; }

    public IUser SelectedUser { get; set; }

    #endregion

    #region Private Helper Methods

    private ObservableCollection<IUser> CreateUsers(int count)
    {
        var oc = new ObservableCollection<IUser>();

        for (var i = 1; i <= count; i++)
        {
            var user = _createUser();
            user.FirstName = "John";
            user.LastName = $"Doe #{i}";
            user.Age = 20 + i;

            oc.Add(user);
        }

        return oc;
    }

    private void IncrementAge_OnClick(object sender, EventArgs e) => User.Age++;

    private void AddThomas_OnClicked(object sender, EventArgs e) => Users.Add(User);

    #endregion
}