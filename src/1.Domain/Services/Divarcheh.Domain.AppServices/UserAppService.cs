using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;

namespace Divarcheh.Domain.AppServices;
public class UserAppService : IUserAppService
{
    private readonly IUserService _userService;

    public UserAppService(IUserService userService)
    {
        _userService = userService;
    }

    public int GetCount() => _userService.GetCount();
}