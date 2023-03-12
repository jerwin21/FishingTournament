namespace FishingTournamentApp.Contracts;

public class MyTournamentFilterDescription
{
    public TournamentRoleFlag TournamentRole { get; set; }

    public string RoleString => TournamentRole.ToString();

    public TournamentStatusFlag TournamentStatus { get; set; }

    public string StatusName => TournamentStatus.ToString();
}