using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Dto.User;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
using Divarcheh.Domain.Core.Enum;
using Divarcheh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;

namespace Divarcheh.Infrastructure.EfCore.Repositories;

public class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public int GetCount() => _dbContext.Users.Count();
    public List<UserSummaryDto> GetAll()
    {
        var users = _dbContext.Users
            .Select(u => new UserSummaryDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                UserName = u.UserName,
                Mobile = u.Mobile,
                Email = u.Email,
                RegisterAt = u.RegisterAt,
                City = u.City.Title,
                Role = (RoleEnum)u.RoleId,
                ImagePath = u.ImagePath
            }).ToList();

        return users;
    }

    public UserDto GetById(int id)
    {
        var user = _dbContext.Users
            .Include(x => x.City)
            .FirstOrDefault(x => x.Id == id);

        if (user is null) throw new Exception("user not found");

        var result = new UserDto();

        result.Id = user.Id;
        result.FirstName = user.FirstName;
        result.LastName = user.LastName;
        result.UserName = user.UserName;
        result.Mobile = user.Mobile;
        result.Email = user.Email;
        result.Address = user.Address;
        result.CityId = user.City.Id;
        result.Role = (RoleEnum)user.RoleId;
        result.ImagePath = user.ImagePath;

        return result;

    }

    public async Task<bool> Create(UserDto model, CancellationToken cancellationToken)
    {
        try
        {
            var user = new User();

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.UserName = model.UserName;
            user.Mobile = model.Mobile;
            user.Email = model.Email;
            user.CityId = model.CityId;
            user.RegisterAt = DateTime.Now;
            user.Address = model.Address;

            user.ImagePath = model.ImagePath;

            await _dbContext.Users.AddAsync(user, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return true;
        }
        catch (Exception)
        {

            return false;
        }

    }

    public async Task<bool> Update(UserDto model, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Include(x => x.City)
            .FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);

        if (user is null) return false;

        user.FirstName = model.FirstName;
        user.LastName = model.LastName;
        user.UserName = model.UserName;
        user.Mobile = model.Mobile;
        user.Email = model.Email;
        user.CityId = model.CityId;
        user.Address = model.Address;
        user.ImagePath = model.ImagePath ?? user.ImagePath;

        await _dbContext.SaveChangesAsync(cancellationToken);
        return true;
    }
}