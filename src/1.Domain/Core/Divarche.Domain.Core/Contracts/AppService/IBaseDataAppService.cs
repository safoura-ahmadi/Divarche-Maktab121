using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;

namespace Divarcheh.Domain.Core.Contracts.AppService
{
    public interface IBaseDataAppService
    {
        public List<City> GetCities();
        public List<Role> GetRoles();
    }
}
