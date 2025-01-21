using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divarcheh.Domain.Core.Contracts.Service
{
    public interface ICategoryService
    {
        public List<GetCategoryForHomePageDto> GetCategoriesForHomePage();
        public List<CategoryDto> GetParentCategories();
        public List<CategoryDto> GetChildCategories(int parentId);
    }
}
