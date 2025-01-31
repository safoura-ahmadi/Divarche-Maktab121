using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Dto.HomePage;
using Divarcheh.Infrastructure.EfCore.Common;
using Microsoft.EntityFrameworkCore;

namespace Divarcheh.Infrastructure.EfCore.Repositories
{
    public class CategoryRepository(AppDbContext appDbContext) : ICategoryRepository
    {
        public async Task<List<GetCategoryForHomePageDto>> GetCategoriesForHomePage(CancellationToken cancellationToken)
        {
            var categories = await appDbContext
                .Categories.Include(x => x.Advertisements)
                .Select(x => new GetCategoryForHomePageDto
                {
                    CategoryId = x.Id,
                    Title = x.Title,
                    ImagePath = x.ImagePath,
                    AdvertisementCount = x.Advertisements.Count
                }).ToListAsync(cancellationToken);

            return categories;
        }

        public async Task<List<CategoryDto>> GetParentCategories(CancellationToken cancellationToken)
        {
            var categories = await appDbContext.Categories
                .Where(x => x.ParentId == null)
                .Select(x => new CategoryDto()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImagePath = x.ImagePath
                }).ToListAsync(cancellationToken);

            return categories;
        }

        public async Task<List<CategoryDto>> GetChildCategories(int parentId, CancellationToken cancellationToken)
        {
            var categories = await appDbContext.Categories
                .Where(x => x.ParentId == parentId)
                .Select(x => new CategoryDto()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImagePath = x.ImagePath
                }).ToListAsync(cancellationToken);

            return categories;
        }

        public async Task<GetDataForCreateAdvDto> GetDataForCreateAdv(int childId, CancellationToken cancellationToken)
        {
            var item = await appDbContext.Categories
                .Include(x => x.ParentCategory)
                .FirstOrDefaultAsync(x => x.Id == childId, cancellationToken);

            if (item is not null)
            {
                return new GetDataForCreateAdvDto
                {
                    Title = $" {item.Title} > {item.ParentCategory!.Title}",
                    ImagePath = item.ImagePath
                };
            }
            else
            {
                throw new Exception("category not found!");
            }

        }

    }
}
