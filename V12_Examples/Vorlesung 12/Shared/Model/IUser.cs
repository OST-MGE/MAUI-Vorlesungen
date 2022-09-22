namespace Vorlesung_12.Shared.Model;

public interface IUser
{
    string FirstName { get; set; }

    string LastName { get; set; }

    int Age { get; set; }
}