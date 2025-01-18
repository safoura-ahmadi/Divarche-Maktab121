using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.AppService;
public interface IUserAppService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    bool Create(UserDto model);
    UserDto GetById(int id);
    public bool Update(UserDto model);
}