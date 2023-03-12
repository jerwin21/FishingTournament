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
            var tournament = tournamentFrame.BindingContext;
            Navigation.PushAsync(new UserTournamentView(new UserTournamentViewModel((UserTournament)tournament)));
        }

        Console.Write("lessseeee");


    }
}