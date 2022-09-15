using Vorlesung_12.Shared.Model;
using Vorlesung_12.Shared.ViewModel;

namespace Vorlesung_12.Pierced.Model;

public class User : BindableBase, IUser
{
    private string _firstName = string.Empty;
    private string _lastName = string.Empty;
    private int _age;

    public string FirstName
    {
        get => _firstName;
        set => SetProperty(ref _firstName, value);
    }

    public string LastName
    {
        get => _lastName;
        set => SetProperty(ref _lastName, value);
    }

    public int Age
    {
        get => _age;
        set => SetProperty(ref _age, value);
    }
}