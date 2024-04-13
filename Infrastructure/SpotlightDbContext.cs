using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class SpotlightDbContext : DbContext
{
    public SpotlightDbContext()
        : base()
    {        
    }

    protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
    {
        base.OnConfiguring( optionsBuilder );

        optionsBuilder.UseSqlServer( "Server=localhost\\SQLEXPRESS;Database=Spotlight;Trusted_Connection=True;TrustServerCertificate=True;" );
    }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        base.OnModelCreating( modelBuilder );

        modelBuilder.ApplyConfiguration( new ActorConfiguration() );
        modelBuilder.ApplyConfiguration( new PlayConfiguration() );
        modelBuilder.ApplyConfiguration( new TheaterConfiguration() );
    }
}
