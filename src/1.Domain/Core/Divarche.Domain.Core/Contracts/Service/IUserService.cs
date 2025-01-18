using Divarcheh.Domain.Core.Dto.User;
using Microsoft.AspNetCore.Http;

namespace Divarcheh.Domain.Core.Contracts.Service;
public interface IUserService
{
    int GetCount();
    List<UserSummaryDto> GetAll();
    bool Create(UserDto model);
    string UploadImageProfile(IFormFile FormFile);
    UserDto GetById(int id);
    public bool Update(UserDto model);
}