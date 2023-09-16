namespace Vorlesung_11.Model;

public sealed class User : IUser
{
    public string FirstName { get; set; } = UserDefaults.FirstName;

    public string LastName { get; set; } = UserDefaults.LastName;

    public int Age { get; set; } = UserDefaults.Age;
}