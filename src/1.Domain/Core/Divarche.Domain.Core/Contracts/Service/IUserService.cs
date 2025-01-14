using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.Service;
public interface IUserService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    bool Create(CreateUserDto model);
}