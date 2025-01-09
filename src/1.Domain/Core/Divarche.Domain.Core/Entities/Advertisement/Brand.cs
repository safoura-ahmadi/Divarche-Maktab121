namespace Divarcheh.Domain.Core.Entities.Advertisement;

public class Brand
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    #endregion

    #region NavigationProperties
    public List<Advertisement> Advertisements { get; set; }
    #endregion
}