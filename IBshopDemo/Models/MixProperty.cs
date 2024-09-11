using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class MixProperty
{
    [Key]
    public int MixIncomeId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int BrancheCode { get; set; }

    public int? IncomeCenterId { get; set; }

    public int? MonthNumber { get; set; }

    public string? MonthName { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal ServatIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal ServatRev { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal GoharIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal GoharRev { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal TotalIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal TotalRev { get; set; }

    public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;

    public virtual IncomeCenter? IncomeCenter { get; set; }
}
