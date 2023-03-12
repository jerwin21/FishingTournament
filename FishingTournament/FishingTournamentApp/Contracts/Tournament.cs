namespace FishingTournamentApp.Contracts;

public class Tournament
{
    public long TournamentId { get; set; }

    public string Title { get; set; }

    public DateTime TournamentStartDateTime { get; set; }

    public DateTime TournamentEndDateTime { get; set; }

    public DateTime TournamentRegistrationStartDateTime { get; set; }

    public DateTime TournamentRegistrationEndDateTime { get; set; }

    public string Location { get; set; }

    public string Rules { get; set; }

    public User Director { get; set; }


    public List<User> Judges { get; set; }
    
    public Image TournamentImage { get; set; }

}