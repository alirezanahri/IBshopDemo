using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class HrMonthlyReport
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int HrmonthlyreportId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Year { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public string Month { get; set; } = null!;
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MonthNumber { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int HrpersonnelQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int LeftQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int HrmhiredQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Obqty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Reqqty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SentCvtoDep { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CoursQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IntQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RsgReq { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int UsedImp { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Gcissu { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SrvAsgNewPer { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AsuAsgNewPer { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GurReqFun { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GurReqLtt { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int PyrDedReqLtt { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SendOutLtt { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SendIntLtt { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RecLtt { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int PerEntCnfQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int PreFailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ReplacemntQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Rrfail { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int RrfacFail { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int LobFailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int FloFailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TblFailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int StrFailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MngRfailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int BrkFailQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int PntFailQty { get; set; }
}
