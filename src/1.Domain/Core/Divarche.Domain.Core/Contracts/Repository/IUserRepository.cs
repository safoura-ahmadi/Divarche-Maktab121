using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.Repository;
public interface IUserRepository
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    UserDto GetById(int id);
    bool Create(UserDto model);

    bool Update(UserDto model);

}
