using System.ComponentModel.DataAnnotations;

namespace Divarche.Domain.Core.Enum;

public enum AdvertisementFinalStatusEnum
{
    [Display(Name = "در انتظار تایید")]
    Pending = 1,
    [Display(Name = "تایید شده")]
    Approved = 2,
    [Display(Name = "رد شده")]
    Rejected = 3
}