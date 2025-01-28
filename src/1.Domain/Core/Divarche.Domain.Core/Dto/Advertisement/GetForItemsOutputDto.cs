using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divarcheh.Domain.Core.Entities.Advertisement;
using Divarcheh.Domain.Core.Entities.BaseEntities;

namespace Divarcheh.Domain.Core.Dto.Advertisement
{
    public class GetForItemsOutputDto
    {
        public GetDataForCreateAdvDto CategoryData { get; set; }
        public List<Brand> Brands { get; set; }
    }
}
