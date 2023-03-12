using FishingTournamentApp.Contracts;

namespace FishingTournamentApp.Services.Managers;
/// <summary>
/// The purpose of this class is to manage calls to resources and engines regarding a user's tournaments.
/// For example, grabbing a user's registered tournaments from the database, filtering down a user's tournament etc
/// </summary>
public class UserTournamentManager : IUserTournamentManager
{
    public IEnumerable<UserTournament> GetUserTournaments()
    {
        return new List<UserTournament>
        {
            new()
            {
                Tournament = new Tournament
                {
                    Title = "Test 1",
                    TournamentId = 123,
                    Location = "ur moms house",
                },
                Role = TournamentRoleFlag.Angler,
            },
            new()
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
    }
}