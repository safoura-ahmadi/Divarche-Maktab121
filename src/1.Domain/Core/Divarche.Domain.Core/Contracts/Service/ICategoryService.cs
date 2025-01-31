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
        Task<List<GetCategoryForHomePageDto>> GetCategoriesForHomePage(CancellationToken cancellationToken);
        Task<List<CategoryDto>> GetParentCategories(CancellationToken cancellationToken);
        Task<List<CategoryDto>> GetChildCategories(int parentId, CancellationToken cancellationToken);
        Task<GetDataForCreateAdvDto> GetDataForCreateAdv(int childId, CancellationToken cancellationToken);
    }
}
