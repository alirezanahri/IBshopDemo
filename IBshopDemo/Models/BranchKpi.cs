using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class BranchKpi
{
    [Key]
    public string KpibranchCode { get; set; } = null!;
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? WrsupReq { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? WrongIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? BrcCnf { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? WrongQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? BrnReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? BranchCap { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? PurchaseAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? Kllevel { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? ConIntMonPercentage { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? ClienttoIssue { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? BrcClient { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? MrkSpv { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string? NewUser { get; set; }
}
