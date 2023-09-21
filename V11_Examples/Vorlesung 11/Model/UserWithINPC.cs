namespace Vorlesung_11.Model;

using System.ComponentModel;

public sealed class UserWithINPC : IUser, INotifyPropertyChanged
{
    private string _firstName = UserDefaults.FirstName;
    private string _lastName = UserDefaults.LastName;
    private int _age = UserDefaults.Age;
    
    public string FirstName
    {
        get => _firstName;
        set
        {
            if (_firstName != value)
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }
    }

    public string LastName
    {
        get => _lastName;
        set
        {
            if (_lastName != value)
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }
    }

    public int Age
    {
        get => _age;
        set
        {
            if (_age != value)
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
        }
    }

    #region INotifyPropertyChanged

    public event PropertyChangedEventHandler PropertyChanged;

    private void OnPropertyChanged(string propertyName)
    {
        var eventArgs = new PropertyChangedEventArgs(propertyName);
        PropertyChanged?.Invoke(this, eventArgs);
    }

    #endregion
}