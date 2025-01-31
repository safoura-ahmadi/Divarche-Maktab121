using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Identity;

namespace Divarcheh.Domain.Core.Contracts.AppService;
public interface IUserAppService
{
    Task<int> GetCount(CancellationToken cancellationToken);
    Task<List<UserSummaryDto>> GetAll(CancellationToken cancellationToken);
    Task<IdentityResult> Register(UserDto model, CancellationToken cancellationToken);
    Task<UserDto> GetById(int id, CancellationToken cancellationToken);
    Task<bool> Update(UserDto model, CancellationToken cancellationToken);
    Task<IdentityResult> Login(string username, string password);
}