using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;

namespace Divarcheh.Domain.AppServices
{
    public class CategoryAppService(ICategoryService categoryService) : ICategoryAppService
    {
        public List<GetCategoryForHomePageDto> GetCategoriesForHomePage()
            => categoryService.GetCategoriesForHomePage();

        public List<CategoryDto> GetParentCategories()
            => categoryService.GetParentCategories();

        public List<CategoryDto> GetChildCategories(int parentId)
            => categoryService.GetChildCategories(parentId);

        public Task<string> GetTitleForCreateAdv(int childId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
