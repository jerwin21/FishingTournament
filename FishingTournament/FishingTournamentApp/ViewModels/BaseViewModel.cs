using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FishingTournamentApp.ViewModels;

public class BaseViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private bool _IsLoading;
    private string _Title;

    public bool IsLoading
    {
        get => _IsLoading;
        set
        {
            if(_IsLoading == value)
                return;

            _IsLoading = value;
            OnPropertyChanged();
        }
    }

    public string Title
    {
        get => _Title;
        set
        {
            if(_Title == value)
                return;

            _Title = value;
            OnPropertyChanged();
        }
    }


    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}