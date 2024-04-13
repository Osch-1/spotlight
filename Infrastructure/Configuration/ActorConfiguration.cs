using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

internal class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure( EntityTypeBuilder<Actor> builder )
    {
        // Привязываемся к таблица
        // Задаем какое свойство будет являться PrimaryKey
        builder.ToTable( nameof( Actor ) )
               .HasKey( a => a.Id );

        builder.Property( a => a.Name )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( a => a.Surname )
               .HasMaxLength( 50 )
               .IsRequired();

        builder.Property( a => a.PhoneNumber )
               .HasMaxLength( 50 )
               .IsRequired();

        // datetime2
        builder.Property( a => a.DateOfBirth )
               .IsRequired();

        builder.Ignore( a => a.FullName );
    }
}
