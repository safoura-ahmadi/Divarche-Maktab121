using System.ComponentModel.DataAnnotations;

namespace Divarche.Domain.Core.Enum;

public enum AdvertisementStatusEnum
{
    [Display(Name = "جدید")]
    New = 1,
    [Display(Name = "دسته دوم")]
    Used = 2
}