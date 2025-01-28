using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;

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
    public async Task<bool> Create(UserDto model,CancellationToken cancellationToken) 
        => await _userRepository.Create(model,cancellationToken);

    public UserDto GetById(int id) => _userRepository.GetById(id);
    public async Task<bool> Update(UserDto model,CancellationToken cancellationToken) 
        => await _userRepository.Update(model,cancellationToken);
}