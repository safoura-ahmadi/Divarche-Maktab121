﻿using System.ComponentModel.DataAnnotations;

namespace Divarche.Domain.Core.Enum;

public enum AdvertisementTypeEnum
{
    [Display(Name = "خریدار")]
    Buyer = 1,
    [Display(Name = "فروشنده")]
    Seller = 2
}