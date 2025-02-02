using Application;

namespace Infrastructure.Foundation;

public class UnitOfWork : IUnitOfWork
{
    private readonly SpotlightDbContext _dbContext;

    public UnitOfWork( SpotlightDbContext dbContext )
    {
        _dbContext = dbContext;
    }

    public async Task CommitAsync()
    {
        _ = await _dbContext.SaveChangesAsync();
    }
}
