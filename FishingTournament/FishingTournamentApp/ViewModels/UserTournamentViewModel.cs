using FishingTournamentApp.Contracts;

namespace FishingTournamentApp.ViewModels;

public class UserTournamentViewModel : BaseViewModel
{
    private UserTournament _userUserTournament;

    public UserTournamentViewModel(UserTournament userUserTournament)
    {
        _userUserTournament = userUserTournament;
    }

    public UserTournament UserTournament
    {
        get => _userUserTournament;
        set
        {
            if(_userUserTournament == value) return;
            
            _userUserTournament = value;
            OnPropertyChanged();
        }
    }
}