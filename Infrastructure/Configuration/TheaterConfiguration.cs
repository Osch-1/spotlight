using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

internal class TheaterConfiguration : IEntityTypeConfiguration<Theater>
{
    public void Configure( EntityTypeBuilder<Theater> builder )
    {
        builder.ToTable( nameof( Theater ) )
               .HasKey( t => t.Id );

        builder.Property( t => t.Name )
               .HasMaxLength( 100 )
               .IsRequired();

        builder.Property( t => t.Address )
               .HasMaxLength( 100 )
               .IsRequired();

        builder.Property( t => t.PhoneNumber )
               .HasMaxLength( 100 )
               .IsRequired();

        builder.Property( t => t.OpeningDate )
               .IsRequired();

        // Задаем связь между сущностями Theater и Play
        // Вид связи 1 to N
        builder.HasMany( t => t.Plays )
               .WithOne(/*p => p.Theater*/)
               .HasForeignKey( p => p.TheaterId );
    }
}
