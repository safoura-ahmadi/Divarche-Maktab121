using Divarche.Domain.Core.Entities.Advertisement;

namespace Divarche.Domain.Core.Entities.BaseEntities;

public class Image
{
    #region Properties
    public int Id { get; set; }
    public string Path { get; set; }
    #endregion

    #region NavigationProperties
    public int AdvertisementId { get; set; }
    public Advertisement Advertisement { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }
    #endregion
}