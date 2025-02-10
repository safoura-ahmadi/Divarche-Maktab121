using Divarcheh.Domain.Core.Entities.BaseEntities;
using Microsoft.AspNetCore.Identity;

namespace Divarcheh.Domain.Core.Entities.User;

public class User : IdentityUser<int>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string Mobile { get; set; }
    public string? Address { get; set; }
    public DateTime RegisterAt { get; set; }
    public int CityId { get; set; }
    public int RoleId { get; set; }
    public string? ImagePath { get; set; }
    public City City { get; set; }
    public Visitor? Visitor { get; set; }
    public Advertiser? Advertiser { get; set; }

    public List<Advertisement.Advertisement> UserAdvertisements { get; set; }

    public List<UsersFavoriteAdvertisements> FavoriteAdvertisements { get; set; }

}

public class Visitor
{
    public int Id { get; set; }
    public int VisitCount { get; set; }
    public DateTime LastVisit { get; set; }
}

public class Advertiser
{
    public int Id { get; set; }
    public int Balance { get; set; }
}
