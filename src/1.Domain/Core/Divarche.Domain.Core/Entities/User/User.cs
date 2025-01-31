using Divarcheh.Domain.Core.Entities.BaseEntities;
using Microsoft.AspNetCore.Identity;

namespace Divarcheh.Domain.Core.Entities.User;

public class User : IdentityUser<int>
{
    #region Properties
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Mobile { get; set; }
    public string? Address { get; set; }
    public DateTime RegisterAt { get; set; }
    public int CityId { get; set; }
    public int RoleId { get; set; }
    public string? ImagePath { get; set; }
    #endregion

    #region NavigationProperties

    public List<Advertisement.Advertisement> UserAdvertisements { get; set; }
    public List<UsersFavoriteAdvertisements> FavoriteAdvertisements { get; set; }
    public City City { get; set; }
    public Role Role { get; set; }
    #endregion
}