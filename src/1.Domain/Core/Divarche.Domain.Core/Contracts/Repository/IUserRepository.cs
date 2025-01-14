using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.Repository;
public interface IUserRepository
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    bool Create(CreateUserDto model);
}
