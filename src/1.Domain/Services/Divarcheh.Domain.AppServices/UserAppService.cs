using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.User;
using Divarcheh.Domain.Core.Entities.User;
using Microsoft.AspNetCore.Identity;

namespace Divarcheh.Domain.AppServices;
public class UserAppService : IUserAppService
{
    private readonly IUserService _userService;
    private readonly IBaseDataService _baseDataService;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public UserAppService(IUserService userService, IBaseDataService baseDataService, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userService = userService;
        _baseDataService = baseDataService;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public int GetCount() => _userService.GetCount();
    public List<UserSummaryDto> GetAll() => _userService.GetAll();


    public async Task<IdentityResult> Register(UserDto model, CancellationToken cancellationToken)
    {
        var user = new User
        {
            UserName = model.UserName,
            Email = model.Email,
            Mobile = model.Mobile,
            CityId = model.CityId,
            RoleId = model.RoleId,
        };

        var result = await _userManager.CreateAsync(user, "123456");

        if (result.Succeeded)
        {
            if (model.ProfileImgFile is not null)
            {
                model.ImagePath = await _baseDataService.UploadImage(model.ProfileImgFile!, "Profiles", cancellationToken);
            }

            await _userManager.AddToRoleAsync(user, "Admin");
        }

        return result;
    }

    public UserDto GetById(int id) => _userService.GetById(id);
    public async Task<bool> Update(UserDto model, CancellationToken cancellationToken)
    {
        if (model.ProfileImgFile is not null)
        {
            model.ImagePath = await _baseDataService.UploadImage(model.ProfileImgFile!, "Profiles", cancellationToken);
        }

        return await _userService.Update(model, cancellationToken);
    }

    public async Task<IdentityResult> Login(string username, string password)
    {
        var result = await _signInManager.PasswordSignInAsync(username, password, true, false);
        return result.Succeeded ? IdentityResult.Success : IdentityResult.Failed();
    }
}