using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.Services;
public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public int GetCount() => _userRepository.GetCount();
    public List<UserSummaryDto> GetAll() => _userRepository.GetAll();
    public bool Create(CreateUserDto model) => _userRepository.Create(model);
}