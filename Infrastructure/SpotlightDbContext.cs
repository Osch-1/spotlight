using Infrastructure.Foundation.Database.EntityConfiguration;
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

        // говорим что будем использовать sql server и указываем строку подключения
        // при этом база данных на момент начала работы может не существовать
        optionsBuilder.UseSqlServer( "Server=localhost\\SQLEXPRESS;Database=Spotlight;Trusted_Connection=True;TrustServerCertificate=True;" );
    }

    // Здесь передаем конфигурации сущностей <-> таблиц
    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        base.OnModelCreating( modelBuilder );

        modelBuilder.ApplyConfiguration( new ActorConfiguration() );
        modelBuilder.ApplyConfiguration( new PlayConfiguration() );
        modelBuilder.ApplyConfiguration( new TheaterConfiguration() );
    }
}