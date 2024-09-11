using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class FixIncomeProperty
     
{
    [Key]
    public int FixIncomeId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int BrancheCode { get; set; }

    public int? InComeCenterId { get; set; }

    public string? MonthNumber { get; set; }

    public string? MonthName { get; set; }

    public int? CustomerQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal GanjinehIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal GanjinehRev { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal AndookhtehIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal AndookhtehRev { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int VirIssueBillQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal VirIssueBillVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal TotalIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal TotalRev { get; set; }

    public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;

    public virtual IncomeCenter? InComeCenter { get; set; }
}
