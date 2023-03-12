namespace FishingTournamentApp.Contracts;

public class User
{
    public long IdNumber { get; set; }

    public string UserName { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Password { get; set; }

    public Image ProfilePicture { get; set; }

}