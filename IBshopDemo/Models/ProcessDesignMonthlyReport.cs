using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class ProcessDesignMonthlyReport
{
    [Key]
    public int ProcessDesignMrid { get; set; }

    public int? Year { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست")]
    public string Month { get; set; } = null!;
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MonthNumber { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int PrcdQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RelPrcdQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InsQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RelInsQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RegQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RelReqQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int FormQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int PrcDesign { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ReviewPrc { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AsmPrc { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int DlgQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IndexQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ReviwIndxQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int KpimonitoringQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MrkcommHold { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MrkDoneCmm { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MrkFailCmm { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int DevCommHold { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int DevDoneCmm { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int DevFailCmm { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CrmcommHold { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CrmdoneCmm { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CrmfailCmm { get; set; }
}
