using Divarcheh.Domain.Core.Entities.Advertisement;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;

namespace Divarcheh.Domain.Core.Dto.User
{
    public class CreateUserDto
    {
        #region Properties
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int CityId { get; set; }
        public int RoleId { get; set; }
        public string? ImagePath { get; set; }
        #endregion

    }
}
