using Divarcheh.Domain.Core.Entities.BaseEntities;

namespace Divarcheh.Domain.Core.Entities.Advertisement;

public class Category
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    public int? ParentId { get; set; }
    #endregion

    #region NavigationProperties
    public Image Image { get; set; }
    public List<Advertisement> Advertisements { get; set; }
    public List<Category> SubCategories { get; set; }
    public Category? ParentCategory { get; set; }
    #endregion
}