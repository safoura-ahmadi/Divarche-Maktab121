using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;

namespace Divarcheh.Domain.Core.Contracts.AppService
{
    public interface IBaseDataAppService
    {
        Task<List<City>> GetCities(CancellationToken cancellationToken);
    }
}
