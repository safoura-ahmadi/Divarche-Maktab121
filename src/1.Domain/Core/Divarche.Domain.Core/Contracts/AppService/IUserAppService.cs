using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.AppService;
public interface IUserAppService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    Task<bool> Create(UserDto model,CancellationToken cancellationToken);
    UserDto GetById(int id);
    Task<bool> Update(UserDto model,CancellationToken cancellationToken);
}