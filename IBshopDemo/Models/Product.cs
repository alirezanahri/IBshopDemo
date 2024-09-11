using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class Product
{
    [Key]
    public int ProductsId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int BrancheCode { get; set; }

    public int? IncomeCenterId { get; set; }

    public int? MonthNumber { get; set; }

    public string? MonthName { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal IbcrowdVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IbcardIssueQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CardQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int KargozariBoursCode { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal DealValue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public decimal Income { get; set; }

    public virtual BranchesInfo BrancheCodeNavigation { get; set; } = null!;

    public virtual IncomeCenter? IncomeCenter { get; set; }
}
