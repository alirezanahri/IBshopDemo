using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class FinancialSuperMarketMonthlyReport
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SuperMrid { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Year { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public string Month { get; set; } = null!;
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MonthNumber { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CustomersReplyQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IbshoppRegisterQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AuthenticationQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ActivationQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ReportForCustomerC { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ReportForCustomerF { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GanjinehIssueReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GanjinehIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AndookhtehIssueReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AndookhtehIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GoharandServatIssueReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GohrandServatIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GanjinehRevokeReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GanjinehRevokeVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AndookhtehRevokeReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AndookhtehRevokeVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GoharandServatRevokeReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GohrandServatRevokeVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TotIsuuVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TotRevVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int EditQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int LegalServQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CardIssuanceQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TotalIbcardVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InvestorsQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TotalIbcrowdVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InsuranceIssued { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CreaditQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CreaditVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OnlineCodeQty { get; set; }
}
