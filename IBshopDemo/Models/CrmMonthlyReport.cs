using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class CrmMonthlyReport
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Crmmrid { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Year { get; set; }

    public string Month { get; set; } = null!;
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int MonthNumber { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InChatQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InCompCallQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InVmQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InCallQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OutAccNumEditQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OutsurveyQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OutComTrtQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OutVmQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SejamQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double AvgCallDuration { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double AvgCallWaitingDuration { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double ToalCallDuration { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GanjinehIssuesQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double GanjinehIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AndookhtehIssuesQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double AndookhtehIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GoharandServatIssuesQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double GoharandServatIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TotalIssuesQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public double TotalIssuesVol { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int CrmcoursesQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int TicketOnlineQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Inticket { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ComplaintTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int SurveyTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int InSurveyCallQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OutSurveyCallQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int OnlineChatsurveyQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GanjinehTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int AndookhtehicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int ServatafarinanTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int GoharTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IbCardTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IbCrowdTicketQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int BranchComplTicketQty { get; set; }
}
