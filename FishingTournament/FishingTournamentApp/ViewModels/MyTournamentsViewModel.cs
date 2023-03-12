using System.Collections.ObjectModel;
using FishingTournamentApp.Contracts;
using Syncfusion.Maui.DataSource.Extensions;

namespace FishingTournamentApp.ViewModels;

public partial class MyTournamentsViewModel
{
    public ObservableCollection<UserTournament> Tournaments { get; set;  }

    public MyTournamentFilterDescription FilterDescription { get; set; }

    public ObservableCollection<TournamentRoleFlag> RoleFlags { get; set; }

    public ObservableCollection<TournamentStatusFlag> StatusFlags { get; set; }

    public TournamentRoleFlag DefaultRoleFlag { get; set; } = TournamentRoleFlag.All;

    public TournamentStatusFlag DefaultStatusFlag { get; set; } = TournamentStatusFlag.Any;

    //TODO: eventually will need to bring in services/managers that will do the work of getting stuff from our db

    public MyTournamentsViewModel()
    {
        //TODO: once db and api are set up we should grab these from there
        Tournaments = new ObservableCollection<UserTournament>
        {
            new UserTournament
            {
                Tournament = new Tournament
                {
                    Title = "Test 1",
                    TournamentId = 123,
                    Location = "ur moms house",
                },
                Role = TournamentRoleFlag.Angler,
            },
            new UserTournament
            {
                Tournament = new Tournament
                {
                    Title = "Test 2",
                    TournamentId = 234,
                    Location = "ur dads house",
                },
                Role = TournamentRoleFlag.Director,
            }
        };

        FilterDescription = new MyTournamentFilterDescription
        {
            TournamentRole = TournamentRoleFlag.All,
            TournamentStatus = TournamentStatusFlag.Any,
        };


        RoleFlags = Enum.GetValues<TournamentRoleFlag>().ToObservableCollection();
        StatusFlags = Enum.GetValues<TournamentStatusFlag>().ToObservableCollection();


    }

    public void RolePickerSelectedIndexChanged(object item)
    {
        FilterDescription.TournamentRole = (TournamentRoleFlag)item;
    }


    #region Commands



    #endregion

    #region Methods

    public string ToTournamentStatusString(TournamentStatusFlag status)
    {
        return status.ToString();
    }

    public string ToTournamentRoleString(TournamentRoleFlag role)
    {
        return role.ToString();
    }

    #endregion
}