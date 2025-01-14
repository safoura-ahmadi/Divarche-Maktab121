using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
namespace Divarcheh.Domain.Core.Contracts.Service
{
    public interface IBaseDataService
    {
        public List<City> GetCities();
        public List<Role> GetRoles();
    }
}
