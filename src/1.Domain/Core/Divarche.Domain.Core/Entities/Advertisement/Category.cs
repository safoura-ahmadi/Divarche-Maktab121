using Divarcheh.Domain.Core.Entities.BaseEntities;

namespace Divarcheh.Domain.Core.Entities.Advertisement;

public class Category
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    public int? ParentId { get; set; }
    public string? ImagePath { get; set; }

    #endregion

    #region NavigationProperties
    public List<Advertisement> Advertisements { get; set; }
    public List<Category> SubCategories { get; set; }
    public Category? ParentCategory { get; set; }
    #endregion
}