using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Core.Contracts.Repository;
public interface IUserRepository
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    UserDto GetById(int id);
    Task<bool> Create(UserDto model,CancellationToken cancellationToken);

    Task<bool> Update(UserDto model, CancellationToken cancellationToken);

}
