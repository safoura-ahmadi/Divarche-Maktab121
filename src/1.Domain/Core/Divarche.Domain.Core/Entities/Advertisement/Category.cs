using Divarche.Domain.Core.Entities.BaseEntities;

namespace Divarche.Domain.Core.Entities.Advertisement;

public class Category
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    public int ParentId { get; set; }
    #endregion

    #region NavigationProperties
    public List<Image> Images { get; set; }
    public List<Advertisement> Advertisements { get; set; }
    public List<Category> SubCategories { get; set; }
    #endregion
}