namespace FishingTournamentApp.Contracts;

public interface IUserTournamentManager
{
    public IEnumerable<UserTournament> GetUserTournaments();
}