using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Identity;

namespace Divarcheh.Domain.Core.Contracts.AppService;
public interface IUserAppService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    Task<IdentityResult> Register(UserDto model,CancellationToken cancellationToken);
    UserDto GetById(int id);
    Task<bool> Update(UserDto model,CancellationToken cancellationToken);
    Task<IdentityResult> Login(string username, string password,bool rememberMe);
}