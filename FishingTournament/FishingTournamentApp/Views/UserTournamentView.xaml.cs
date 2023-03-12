using FishingTournamentApp.ViewModels;

namespace FishingTournamentApp.Views;

public partial class UserTournamentView : ContentPage
{
    public UserTournamentView(UserTournamentViewModel userTournamentViewModel)
    {
        InitializeComponent();

        BindingContext = userTournamentViewModel;
    }
}