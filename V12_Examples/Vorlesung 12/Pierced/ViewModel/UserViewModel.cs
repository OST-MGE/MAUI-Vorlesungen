using System.ComponentModel;
using Vorlesung_12.Pierced.Model;
using Vorlesung_12.Shared.Model;
using Vorlesung_12.Shared.ViewModel;

namespace Vorlesung_12.Pierced.ViewModel;

public class UserViewModel : BindableBase
{
    private IUser _user;

    public UserViewModel(User user)
    {
        User = user;

        user.PropertyChanged += DoOnUserPropertyChanged;

        DecreaseAgeCommand = new RelayCommand(OnDecreaseAge, CanDecreaseAge);
        IncreaseAgeCommand = new RelayCommand(OnIncreaseAge, CanIncreaseAge);
    }
    
    #region Properties for Bindings

    public IUser User
    {
        get => _user;
        private set => SetProperty(ref _user, value);
    }

    #endregion

    #region Commands for Bindings

    public RelayCommand DecreaseAgeCommand { get; }

    public RelayCommand IncreaseAgeCommand { get; }

    #endregion

    #region Private Methods

    private void DoOnUserPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName != nameof(IUser.Age))
            return;

        DecreaseAgeCommand.RaiseCanExecuteChanged();
        IncreaseAgeCommand.RaiseCanExecuteChanged();
    }

    private void OnDecreaseAge()
    {
        User.Age--;
        DecreaseAgeCommand.RaiseCanExecuteChanged();
        IncreaseAgeCommand.RaiseCanExecuteChanged();
    }

    private bool CanDecreaseAge() => User.Age > 0;

    private void OnIncreaseAge()
    {
        User.Age++;
        DecreaseAgeCommand.RaiseCanExecuteChanged();
        IncreaseAgeCommand.RaiseCanExecuteChanged();
    }

    private bool CanIncreaseAge() => User.Age < 125;

    #endregion
}