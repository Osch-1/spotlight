using Domain.Entities;

namespace Domain.Repositories;

public interface IRepository
{
    Task<Actor?> Get( int id );

    void Add( Actor actor );

    void Delete( Actor actor );
}