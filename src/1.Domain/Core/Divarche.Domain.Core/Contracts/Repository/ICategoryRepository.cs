using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;

namespace Divarcheh.Domain.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        public List<GetCategoryForHomePageDto> GetCategoriesForHomePage();
        public List<CategoryDto> GetParentCategories();
        public List<CategoryDto> GetChildCategories(int parentId);
    }
}
