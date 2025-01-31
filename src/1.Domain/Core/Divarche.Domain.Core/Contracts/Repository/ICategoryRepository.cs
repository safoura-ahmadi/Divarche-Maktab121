using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;

namespace Divarcheh.Domain.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        Task< List<GetCategoryForHomePageDto>> GetCategoriesForHomePage(CancellationToken cancellationToken);
        Task< List<CategoryDto>> GetParentCategories(CancellationToken cancellationToken);
        Task<List<CategoryDto>> GetChildCategories( int parentId, CancellationToken cancellationToken);
        Task<GetDataForCreateAdvDto> GetDataForCreateAdv(int childId,CancellationToken cancellationToken);
    }
}
