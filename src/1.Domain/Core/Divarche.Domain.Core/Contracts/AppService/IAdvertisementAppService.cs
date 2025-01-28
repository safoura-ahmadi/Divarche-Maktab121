﻿using Divarcheh.Domain.Core.Dto.Advertisement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divarcheh.Domain.Core.Contracts.AppService
{
    public interface IAdvertisementAppService
    {
        Task Create(CreateAdvertisementDto model, CancellationToken cancellationToken);
        Task<GetForItemsOutputDto> GetForItems(int childId, CancellationToken cancellationToken);
    }
}
