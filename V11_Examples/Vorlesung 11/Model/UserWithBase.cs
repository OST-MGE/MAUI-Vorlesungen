namespace Vorlesung_11.Model;

public sealed class UserWithBase : BindableBase, IUser
{
    private string _firstName = "Thomas";
    private string _lastName = "Kaelin";
    private int _age = 38;

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