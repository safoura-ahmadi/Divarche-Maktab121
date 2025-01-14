using Divarcheh.Domain.Core.Entities.Advertisement;

namespace Divarcheh.Domain.Core.Entities.BaseEntities;

public class Image
{
    #region Properties
    public int Id { get; set; }
    public string Path { get; set; }
    #endregion

    #region NavigationProperties
    public int AdvertisementId { get; set; }
    public Advertisement.Advertisement Advertisement { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public User.User User { get; set; }
    public int UserId { get; set; }
    #endregion
}