namespace Divarcheh.Domain.Core.Dto.HomePage;

public class GetCategoryForHomePageDto
{
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public string? ImagePath { get; set; }
    public int AdvertisementCount { get; set; }
}