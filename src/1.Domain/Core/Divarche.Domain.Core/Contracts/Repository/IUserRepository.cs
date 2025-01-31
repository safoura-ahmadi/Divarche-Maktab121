using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.Repository;
public interface IUserRepository
{
    Task<int> GetCount(CancellationToken cancellationToken);
    Task<List<UserSummaryDto>> GetAll(CancellationToken cancellationTokenw);
    Task<UserDto> GetById(int id, CancellationToken cancellationToken);
    Task<bool> Create(UserDto model, CancellationToken cancellationToken);

    Task<bool> Update(UserDto model, CancellationToken cancellationToken);

}
