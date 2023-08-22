namespace FanBarca.Models.Domain;

public class Player
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int CountryId { get; set; }  
    public Country? Country { get; set; }  
    public int PositionId { get; set; }
    public Position? Position { get; set; }
    public int PreviousClubId { get; set; } 
    public Club? PreviousClub { get; set; }
    public int NextClubId { get; set; }
    public Club? NextClub { get; set; } 
    public string? FirstSeason { get; set; }    
    public string? LastSeason { get; set; } 
    public string? Image { get; set; }
}