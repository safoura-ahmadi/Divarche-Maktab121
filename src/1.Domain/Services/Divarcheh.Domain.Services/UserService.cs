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

    public async Task< int>GetCount(CancellationToken cancellationToken) =>await _userRepository.GetCount(cancellationToken);
    public async Task<List<UserSummaryDto>> GetAll(CancellationToken cancellationToken) => await _userRepository.GetAll(cancellationToken);
    public async Task<bool> Create(UserDto model,CancellationToken cancellationToken) 
        => await _userRepository.Create(model,cancellationToken);

    public async Task<UserDto> GetById(int id, CancellationToken cancellationToken) => await _userRepository.GetById(id, cancellationToken);
    public async Task<bool> Update(UserDto model,CancellationToken cancellationToken) 
        => await _userRepository.Update(model,cancellationToken);
}