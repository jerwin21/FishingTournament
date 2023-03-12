using FishingTournamentApp.Contracts;
using FishingTournamentApp.ViewModels;

namespace FishingTournamentApp.Views;

public partial class MyTournamentsView : ContentPage
{
    public MyTournamentsView(MyTournamentsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    public void RolePickerSelectionChanged(object sender, EventArgs eventArgs)
    {

        if (BindingContext is MyTournamentsViewModel vm && sender is Picker myPicker)
        {
            vm.RolePickerSelectedIndexChanged(myPicker.SelectedItem);
        }

        Console.Write("balls");
    }

    public void StatusPickerSelectionChanged(object sender, EventArgs eventArgs)
    {

        if (BindingContext is MyTournamentsViewModel vm && sender is Picker myPicker)
        {
            vm.RolePickerSelectedIndexChanged(myPicker.SelectedItem);
        }

        Console.Write("balls");
    }


    public void OnTournamentChosen(object sender, TappedEventArgs e)
    {
        if (sender is Frame tournamentFrame)
        {
            if(tournamentFrame.BindingContext is UserTournament userTournament)
                Navigation.PushAsync(new UserTournamentView(new UserTournamentViewModel(userTournament)));
        }
    }
}