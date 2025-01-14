using Divarcheh.Domain.Core.Contracts.Repository;
using Divarcheh.Domain.Core.Contracts.Service;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;

namespace Divarcheh.Domain.Services
{
    public class BaseDataService : IBaseDataService
    {
        private readonly IBaseDataRepository _baseDataRepository;

        public BaseDataService(IBaseDataRepository baseDataRepository)
        {
            _baseDataRepository = baseDataRepository;
        }

        public List<City> GetCities() => _baseDataRepository.GetCities();
        public List<Role> GetRoles() => _baseDataRepository.GetRoles();
    }
}
