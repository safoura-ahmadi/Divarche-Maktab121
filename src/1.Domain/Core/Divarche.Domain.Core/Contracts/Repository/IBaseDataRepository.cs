using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;

namespace Divarcheh.Domain.Core.Contracts.Repository
{
    public interface IBaseDataRepository
    {
        public List<City> GetCities();
        public List<Role> GetRoles();
    }
}
