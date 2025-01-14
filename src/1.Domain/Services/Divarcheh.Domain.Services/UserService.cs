using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Contracts.Service;

namespace Divarcheh.Domain.Services;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public int GetCount() => _userRepository.GetCount();


}