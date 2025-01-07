﻿using Divarche.Domain.Core.Entities.BaseEntities;

namespace Divarche.Domain.Core.Entities.User;

public class User
{
    #region Properties
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Mobile { get; set; }
    public string? Email { get; set; }
    public string? Address { get; set; }
    public DateTime RegisterAt { get; set; }
    public int CityId { get; set; }
    public int RoleId { get; set; }
    public int ImageId { get; set; }

    #endregion

    #region NavigationProperties

    public List<Advertisement.Advertisement> UserAdvertisements { get; set; }
    public List<Advertisement.Advertisement> FavoriteAdvertisements { get; set; }
    public City City { get; set; }
    public Role Role { get; set; }
    public Image Image { get; set; }
    #endregion
}