using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
using Divarcheh.Domain.Core.Enum;

namespace Divarcheh.Domain.Core.Dto.User
{
    public class UserSummaryDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public string? Email { get; set; }
        public DateTime RegisterAt { get; set; }
        public string City { get; set; }
        public RoleEnum Role { get; set; }
        public string? ImagePath { get; set; }
    }
}
