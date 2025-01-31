using Divarcheh.Domain.Core.Contracts.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;

namespace Divarcheh.Domain.AppServices
{
    public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
    {
        public async Task< List<GetCategoryForHomePageDto>> GetCategoriesForHomePage(CancellationToken cancellationToken)
             => await categoryRepository.GetCategoriesForHomePage(cancellationToken);

        public async Task< List<CategoryDto>> GetParentCategories(CancellationToken cancellationToken)
             => await categoryRepository.GetParentCategories(cancellationToken);

        public async Task< List<CategoryDto>> GetChildCategories(int parentId,CancellationToken cancellationToken)
            => await categoryRepository.GetChildCategories(parentId,cancellationToken);

        public async Task<GetDataForCreateAdvDto> GetDataForCreateAdv(int childId, CancellationToken cancellationToken)
        {
           return await categoryRepository.GetDataForCreateAdv(childId, cancellationToken);
        }
    }
}
