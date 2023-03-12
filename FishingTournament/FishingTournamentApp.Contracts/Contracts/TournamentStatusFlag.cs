namespace FishingTournamentApp.Contracts;

[Flags]
public enum TournamentStatusFlag
{
    Past = 0b_0001,

    Active = 0b_0010,

    Future = 0b_0100,

    Any = Past | Active | Future,
    
}