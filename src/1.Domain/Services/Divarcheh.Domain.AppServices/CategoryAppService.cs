using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;

namespace Divarcheh.Domain.AppServices
{
    public class CategoryAppService(ICategoryService categoryService) : ICategoryAppService
    {
        public async Task<List<GetCategoryForHomePageDto>> GetCategoriesForHomePage(CancellationToken cancellationToken)
            => await categoryService.GetCategoriesForHomePage(cancellationToken);

        public async Task<List<CategoryDto>> GetParentCategories(CancellationToken cancellationToken)
            => await categoryService.GetParentCategories(cancellationToken);

        public async Task<List<CategoryDto>> GetChildCategories(int parentId, CancellationToken cancellationToken)
            => await categoryService.GetChildCategories(parentId, cancellationToken);

        public Task<string> GetTitleForCreateAdv(int childId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
