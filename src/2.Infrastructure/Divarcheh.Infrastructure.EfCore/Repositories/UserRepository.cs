using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Dto.User;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
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
                Role =u.Role.Title,
                ImagePath = u.Image == null ? null : u.Image.Path
            }).ToList();

        return users;
    }

    public bool Create(CreateUserDto model)
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
            user.RoleId = model.RoleId;
            user.Password = model.Password;
            user.RegisterAt = DateTime.Now;
            user.Address = model.Address;

            user.Image.Path = model.ImagePath;

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return true;
        }
        catch (Exception)
        {

            return false;
        }

    }
}