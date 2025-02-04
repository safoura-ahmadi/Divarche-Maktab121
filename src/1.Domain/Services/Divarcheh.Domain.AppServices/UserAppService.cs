using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.User;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Divarcheh.Domain.AppServices;
public class UserAppService : IUserAppService
{
    private readonly IUserService _userService;
    private readonly IBaseDataService _baseDataService;


    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IPasswordHasher<User> _passwordHasher;

    public UserAppService(IUserService userService, IBaseDataService baseDataService, UserManager<User> userManager, SignInManager<User> signInManager, IPasswordHasher<User> passwordHasher)
    {
        _userService = userService;
        _baseDataService = baseDataService;
        _userManager = userManager;
        _signInManager = signInManager;
        _passwordHasher = passwordHasher;
    }

    public int GetCount() => _userService.GetCount();
    public List<UserSummaryDto> GetAll() => _userService.GetAll();


    public async Task<IdentityResult> Register(UserDto model, CancellationToken cancellationToken)
    {
        string role = string.Empty;


        var user = new User
        {
            UserName = model.UserName,
            Email = model.Email,
            Mobile = model.Mobile,
            CityId = model.CityId,
            RoleId = model.RoleId,
        };

        if (model.RoleId == 1) role = "Admin";
        if (model.RoleId == 2) role = "user";

        var result = await _userManager.CreateAsync(user, model.Password);


        if (result.Succeeded)
        {
            if (model.ProfileImgFile is not null)
            {
                model.ImagePath = await _baseDataService.UploadImage(model.ProfileImgFile!, "Profiles", cancellationToken);
            }

            await _userManager.AddToRoleAsync(user, role);
            await _signInManager.PasswordSignInAsync(user.UserName, model.Password, true, false);

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

    public async Task<IdentityResult> Login(string username, string password, bool rememberMe)
    {
        var result = await _signInManager.PasswordSignInAsync(username, password, rememberMe, false);

        return result.Succeeded ? IdentityResult.Success : IdentityResult.Failed();
    }
}