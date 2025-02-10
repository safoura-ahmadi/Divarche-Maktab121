using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divarcheh.Domain.Core.Enum
{
    public enum RoleEnum
    {
        [Display(Name = "ادمین")]
        Admin = 1,

        [Display(Name = "بازدید کننده")]
        Visitor = 2,

        [Display(Name = "آگهی دهنده")]
        Advertiser = 3
    }
}
