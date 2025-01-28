using Divarcheh.Domain.Core.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divarcheh.Domain.Core.Dto.Advertisement;
using Divarcheh.Domain.Core.Entities.Advertisement;
using Divarcheh.Domain.Core.Enum;
using Divarcheh.Infrastructure.EfCore.Common;

namespace Divarcheh.Infrastructure.EfCore.Repositories
{
    public class AdvertisementRepository(AppDbContext dbContext) : IAdvertisementRepository
    {
        public async Task<int> Create(CreateAdvertisementDto model, CancellationToken cancellationToken)
        {
            try
            {
                var entity = new Advertisement()
                {
                    Title = model.Title,
                    Description = model.Description,
                    Price = model.Price,
                    Model = model.Model,
                    BrandId = model.BrandId,
                    CategoryId = model.CategoryId,
                    CityId = model.CityId,
                    UserId = model.UserId,
                    CreateAt = DateTime.Now,
                    AdvertisementType = model.AdvertisementType,
                    AdvertisementStatus = model.AdvertisementStatus,
                    AdvertisementFinalStatus = AdvertisementFinalStatusEnum.Pending
                };

                await dbContext.Advertisements.AddAsync(entity, cancellationToken);
                await dbContext.SaveChangesAsync(cancellationToken);

                return entity.Id;
            }
            catch (Exception e)
            {

                throw new Exception("Exception");
            }
            
        }
    }
}
