using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.AppServices;
public class UserAppService : IUserAppService
{
    private readonly IUserService _userService;

    public UserAppService(IUserService userService)
    {
        _userService = userService;
    }

    public int GetCount() => _userService.GetCount();
    public List<UserSummaryDto> GetAll() => _userService.GetAll();

    public bool Create(UserDto model)
    {
        if (model.ProfileImgFile is not null)
        {
            model.ImagePath = _userService.UploadImageProfile(model.ProfileImgFile!);
        }

        return _userService.Create(model);
    }

    public UserDto GetById(int id) => _userService.GetById(id);
    public bool Update(UserDto model)
    {
        if (model.ProfileImgFile is not null)
        {
            model.ImagePath = _userService.UploadImageProfile(model.ProfileImgFile!);
        }

        return _userService.Update(model);
    }
}