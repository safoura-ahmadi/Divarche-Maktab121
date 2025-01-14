using Divarcheh.Domain.Core.Contracts.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
using Divarcheh.Infrastructure.EfCore.Common;

namespace Divarcheh.Infrastructure.EfCore.Repositories
{
    public class BaseDataRepository : IBaseDataRepository
    {
        private readonly AppDbContext _dbContext;

        public BaseDataRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<City> GetCities() => _dbContext.Cities.ToList();

        public List<Role> GetRoles() => _dbContext.Roles.ToList();
    }
}