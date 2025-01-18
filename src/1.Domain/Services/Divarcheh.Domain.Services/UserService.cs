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
    public bool Create(UserDto model) => _userRepository.Create(model);

    public string UploadImageProfile(IFormFile FormFile)
    {
        string filePath;
        string fileName;
        if (FormFile != null)
        {
            fileName = Guid.NewGuid().ToString() +
                       ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');
            filePath = Path.Combine("wwwroot/Images/Profiles", fileName);
            try
            {
                using (var stream = System.IO.File.Create(filePath))
                {
                     FormFile.CopyTo(stream);
                }
            }
            catch
            {
                throw new Exception("Upload files operation failed");
            }
            return $"/Images/Profiles/{fileName}";
        }
        else
            fileName = "";

        return fileName;
    }

    public UserDto GetById(int id) => _userRepository.GetById(id);
    public bool Update(UserDto model) => _userRepository.Update(model);
}