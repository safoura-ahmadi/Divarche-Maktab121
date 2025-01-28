using Divarcheh.Domain.Core.Dto.Advertisement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divarcheh.Domain.Core.Contracts.Service
{
    public interface IAdvertisementService
    {
        Task<int> Create(CreateAdvertisementDto model, CancellationToken cancellationToken);
    }
}
