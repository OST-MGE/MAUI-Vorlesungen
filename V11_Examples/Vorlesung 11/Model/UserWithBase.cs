namespace Vorlesung_11.Model;

public sealed class UserWithBase : BindableBase, IUser
{
    private string _firstName = UserDefaults.FirstName;
    private string _lastName = UserDefaults.LastName;
    private int _age = UserDefaults.Age;

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