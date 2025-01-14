using Divarcheh.Domain.Core.Contracts.AppService;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;

namespace Divarcheh.Domain.AppServices
{
    public class BaseDataAppService : IBaseDataAppService
    {
        private readonly IBaseDataService _baseDataService;

        public BaseDataAppService(IBaseDataService baseDataService)
        {
            _baseDataService = baseDataService;
        }

        public List<City> GetCities() => _baseDataService.GetCities();
        public List<Role> GetRoles() => _baseDataService.GetRoles();
    }
}
