using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.AppService;
public interface IUserAppService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    bool Create(CreateUserDto model);
}