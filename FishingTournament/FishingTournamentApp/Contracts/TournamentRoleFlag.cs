namespace FishingTournamentApp.Contracts;
[Flags]
public enum TournamentRoleFlag
{
    Judge = 0b_0001,

    Angler = 0b_0010,

    Director = 0b_0100,

    AnglerDirector = Angler | Director,

    All = Angler | Director | Judge,
}