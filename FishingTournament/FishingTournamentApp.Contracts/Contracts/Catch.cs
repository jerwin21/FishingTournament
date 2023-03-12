namespace FishingTournamentApp.Contracts;

public class Catch
{
    public string Species { get; set; }

    public long EnteredLength { get; set; }

    public long AcceptedLength { get; set; }

    public Image CatchPhoto { get; set; }

    public long PenaltyDeduction { get; set; } = 0;
}