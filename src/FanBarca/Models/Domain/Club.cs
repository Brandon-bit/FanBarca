using System.ComponentModel.DataAnnotations;

namespace FanBarca.Models.Domain;

public class Club
{
    [Key]
    [Required]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }   
}