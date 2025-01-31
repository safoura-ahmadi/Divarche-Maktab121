using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Http;

namespace Divarcheh.Domain.Core.Contracts.Service;
public interface IUserService
{
    Task<int> GetCount(CancellationToken cancellationToken);
    Task<List<UserSummaryDto>> GetAll(CancellationToken cancellationToken);
    Task<bool> Create(UserDto model, CancellationToken cancellationToken);
    Task<UserDto> GetById(int id, CancellationToken cancellationToken);
    Task<bool> Update(UserDto model, CancellationToken cancellationToken);
}