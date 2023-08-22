using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FanBarca.Models.Domain;

public class DatabaseContext : IdentityDbContext<ApplicationUser>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder); 
        
        builder.Entity<Country>()
            .HasMany(e => e.PlayersList)
            .WithOne(e => e.Country)
            .HasForeignKey(e => e.CountryId)
            .IsRequired();

        builder.Entity<Club>()
            .HasMany(e => e.PreviousPlayersList)
            .WithOne(e => e.PreviousClub)
            .HasForeignKey(e => e.PreviousClubId)
            .IsRequired();

        builder.Entity<Club>()
            .HasMany(e => e.NextPlayersList)
            .WithOne(e => e.NextClub)
            .HasForeignKey(e => e.NextClubId)
            .IsRequired();
        
        builder.Entity<Position>()
            .HasMany(e => e.PlayersList)
            .WithOne(e => e.Position)
            .HasForeignKey(e => e.PositionId)
            .IsRequired();  
    }

    public DbSet<Country> Countries { get; set; }   
    public DbSet<Club> Clubs { get; set; }
    public DbSet<Position> Positions { get; set; }  
    public DbSet<Player> Players { get; set; }  
}