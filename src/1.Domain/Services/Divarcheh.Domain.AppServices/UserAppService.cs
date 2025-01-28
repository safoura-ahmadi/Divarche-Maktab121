using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.User;

namespace Divarcheh.Domain.AppServices;
public class UserAppService : IUserAppService
{
    private readonly IUserService _userService;
    private readonly IBaseDataService _baseDataService;
    public UserAppService(IUserService userService, IBaseDataService baseDataService)
    {
        _userService = userService;
        _baseDataService = baseDataService;
    }

    public int GetCount() => _userService.GetCount();
    public List<UserSummaryDto> GetAll() => _userService.GetAll();

    public async Task<bool> Create(UserDto model,CancellationToken cancellationToken)
    {
        if (model.ProfileImgFile is not null)
        {
            model.ImagePath = await _baseDataService.UploadImage(model.ProfileImgFile! , "Profiles" , cancellationToken);
        }

        return  await _userService.Create(model, cancellationToken);
    }

    public UserDto GetById(int id) => _userService.GetById(id);
    public async Task<bool> Update(UserDto model ,CancellationToken cancellationToken)
    {
        if (model.ProfileImgFile is not null)
        {
            model.ImagePath =  await _baseDataService.UploadImage(model.ProfileImgFile!, "Profiles", cancellationToken);
        }

        return await _userService.Update(model,cancellationToken);
    }
}