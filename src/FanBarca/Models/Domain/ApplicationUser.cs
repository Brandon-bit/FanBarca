using Microsoft.AspNetCore.Identity;

namespace FanBarca.Models.Domain;

public class ApplicationUser : IdentityUser
{
    public string? Name { get; set; }       
}