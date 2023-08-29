using Microsoft.AspNetCore.Identity;

namespace FanBarca.Models.Domain;

public class LoadDatabase
{
    public static async Task InsertData(
        DatabaseContext context, 
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager
    )
    {
        if(!roleManager.Roles.Any())
        {
            await roleManager.CreateAsync(new IdentityRole("ADMIN"));
        }

        if(!userManager.Users.Any())    
        {
            var user = new ApplicationUser
            {
                Name = "Brandon Juarez",
                Email = "brandonsalinas792@gmail.com",
                UserName = "brandon.juarez"
            };

            await userManager.CreateAsync(user, "@Bjjs270799");
            await userManager.AddToRoleAsync(user, "ADMIN");
        }

        if(!context.Positions.Any())
        {
            await context.Positions.AddRangeAsync(
                new Position { Name = "Portero", ShortName = "POR" },
                new Position { Name = "Defensa Central", ShortName = "DFC" },
                new Position { Name = "Lateral Izquierdo", ShortName = "LI" },
                new Position { Name = "Lateral Derecho", ShortName = "LD" },
                new Position { Name = "Mediocampista", ShortName = "MC" },
                new Position { Name = "Delantero", ShortName = "DEL" }
            );

            await context.SaveChangesAsync();
        }

        if(!context.Countries.Any())
        {
            await context.Countries.AddRangeAsync(
                new Country { Name = "España", ShortName = "ESP" },
                new Country { Name = "Argentina", ShortName = "ARG" },
                new Country { Name = "Holanda", ShortName = "HOL" },
                new Country { Name = "Polonia", ShortName = "POL" },
                new Country { Name = "Francia", ShortName = "FRA" }
            );

            await context.SaveChangesAsync();
        }

        if(!context.Clubs.Any())
        {
            await context.Clubs.AddRangeAsync(
                new Club { Name = "Liverpool" },
                new Club { Name = "Borussia Dortmund"},
                new Club { Name = "Bayern Munchen"},
                new Club { Name = "Manchester City"}
            );

            await context.SaveChangesAsync();
        }
    }
}