namespace FishingTournamentApp.Contracts;

public class UserTournament
{
    public long UserId { get; set; }

    public Tournament Tournament { get; set; }

    public TournamentRoleFlag Role { get; set; }
}