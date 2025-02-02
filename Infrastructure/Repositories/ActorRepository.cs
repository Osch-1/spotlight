using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ActorRepository : IRepository
{
    private readonly SpotlightDbContext _dbContext;

    public ActorRepository( SpotlightDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public async Task<Actor?> Get( int id )
    {
        return await _dbContext.Set<Actor>().FirstOrDefaultAsync( x => x.Id == id );
    }

    public void Add( Actor actor )
    {
        _dbContext.Add( actor );
    }

    public void Delete( Actor actor )
    {
        _dbContext.Set<Actor>().Remove( actor );
    }
}
