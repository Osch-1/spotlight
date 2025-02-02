// создание Актера

// изменение Актера


/*
 # Создание пользователя и сохранение в базу данных
SpotlightDbContext dbContext = new();
IRepository repository = new ActorRepository( dbContext );
IUnitOfWork uow = new UnitOfWork( dbContext );

string? name = Console.ReadLine();
string? surname = Console.ReadLine();
string dateTimeStr = Console.ReadLine()!;
DateTime dateOfBirth = DateTime.ParseExact( dateTimeStr, "yyyy-MM-dd", CultureInfo.InvariantCulture );

Actor actor = new( name, surname, "87635517229", dateOfBirth );

repository.Add( actor );
await uow.CommitAsync();
*/

/*
# Изменение имени существуюшего Актера - операция Update
SpotlightDbContext dbContext = new();
IRepository repository = new ActorRepository( dbContext );
IUnitOfWork uow = new UnitOfWork( dbContext );

string idStr = Console.ReadLine()!;
int id = int.Parse( idStr );

Actor? actor = await repository.Get( id );
if ( actor is null )
{
    Console.WriteLine( $"No Actor with id: {idStr}" );
    return;
}

string newName = Console.ReadLine()!;
actor.SetName( newName );
await uow.CommitAsync();
 */

/*
# Удаление сущности по Id
SpotlightDbContext dbContext = new();
IRepository repository = new ActorRepository( dbContext );
IUnitOfWork uow = new UnitOfWork( dbContext );

string idStr = Console.ReadLine()!;
int id = int.Parse( idStr );

Actor? actor = await repository.Get( id );
if ( actor is null )
{
    Console.WriteLine( $"No Actor with id: {idStr}" );
    return;
}

repository.Delete( actor );

await uow.CommitAsync();
 */