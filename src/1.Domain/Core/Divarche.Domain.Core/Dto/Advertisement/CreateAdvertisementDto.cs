using Divarcheh.Domain.Core.Entities.Advertisement;
using Divarcheh.Domain.Core.Entities.BaseEntities;
using Divarcheh.Domain.Core.Entities.User;
using Divarcheh.Domain.Core.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Divarcheh.Domain.Core.Dto.Advertisement
{
    public class CreateAdvertisementDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public int CityId { get; set; }
        public int BrandId { get; set; }
        public AdvertisementTypeEnum AdvertisementType { get; set; }
        public AdvertisementStatusEnum AdvertisementStatus { get; set; }
        public List<IFormFile>? Images { get; set; }
    }
}
