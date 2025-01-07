namespace Divarche.Domain.Core.Entities.BaseEntities;

public class City
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    #endregion

    #region NavigationProperties
    public List<User> Users { get; set; }
    public List<Advertisement.Advertisement> Advertisements { get; set; }
    #endregion
}

