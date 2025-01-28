using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Http;

namespace Divarcheh.Domain.Core.Contracts.Service;
public interface IUserService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    Task<bool> Create(UserDto model, CancellationToken cancellationToken);
    UserDto GetById(int id);
    Task<bool> Update(UserDto model, CancellationToken cancellationToken);
}