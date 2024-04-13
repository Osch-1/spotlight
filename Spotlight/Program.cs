using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

SpotlightDbContext dbContext = new();

// Создание сущностей
// CreatePlay( dbContext );

// Получение сущностей
Theater theater = dbContext.Set<Theater>()
                                  // Говорим EF, что при выборе из таблицы Theater
                                  // Также необходимо включить в выборку все Play, которые относятся к Theater
                                  .Include( t => t.Plays )
                                  .FirstOrDefault( t => t.Id == 1 );
// Создаем Сущность Play 
Play newPlay = new( "Завершающее выступление", "Герасимов", DateTime.UtcNow.AddMinutes( 10 ), DateTime.UtcNow.AddMinutes( 15 ) );
theater.Plays.Add( newPlay );

// Сохраняем изменения в базе данных
dbContext.SaveChanges();

Console.WriteLine( "finish work" );

void CreatePlay( SpotlightDbContext dbContext )
{
    // Создаем сущности в памяти и связываем их между собой
    Theater theater = new( "gogole meet", "****", "89271286440", DateTime.Parse( "2012-11-11" ) );
    Play play = new( "В честь субботнего отдыха", "Нехваток времени в четверг", DateTime.UtcNow, DateTime.UtcNow );
    theater.Plays.Add( play );

    // Добавляем сущности в контекст базы данных
    dbContext.Set<Theater>().Add( theater );

    // Отправляем изменения из контекста приложения в СУБД
    dbContext.SaveChanges();
}