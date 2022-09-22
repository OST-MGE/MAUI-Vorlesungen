namespace Vorlesung_11.Model;

using System.ComponentModel;
using System.Runtime.CompilerServices;

public abstract class BindableBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string name = null)
    {
        if (Equals(field, value))
            return false;

        field = value;
        OnPropertyChanged(name);
        return true;
    }

    protected virtual void OnPropertyChanged(string name = null)
    {
        var eventArgs = new PropertyChangedEventArgs(name);
        PropertyChanged?.Invoke(this, eventArgs);
    }
}