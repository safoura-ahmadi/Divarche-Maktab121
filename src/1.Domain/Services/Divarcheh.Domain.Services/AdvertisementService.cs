using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Dto.Advertisement;

namespace Divarcheh.Domain.Services
{
    public class AdvertisementService (IAdvertisementRepository advertisementRepository): IAdvertisementService
    {
        public async Task<int> Create(CreateAdvertisementDto model, CancellationToken cancellationToken)
        {
           return await advertisementRepository.Create(model, cancellationToken);
        }
    }
}
