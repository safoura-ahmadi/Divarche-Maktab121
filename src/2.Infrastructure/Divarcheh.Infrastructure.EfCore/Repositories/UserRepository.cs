using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Infrastructure.EfCore.Common;

namespace Divarcheh.Infrastructure.EfCore.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public int GetCount() => _dbContext.Users.Count();
}