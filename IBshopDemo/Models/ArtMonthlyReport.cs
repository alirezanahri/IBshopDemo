using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class ArtMonthlyReport
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int ArtMonthlyReportId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید سال باشد")]
    public int Year { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و باید ماه را مشخص کنید ")]
    public string Month { get; set; } = null!;
    [Required(ErrorMessage = "این فیلد اجباریست و باید شماره ماه باشد")]
    public int MonthNumber { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int MrkReq { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int CompStudy { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int ArchiveDesignQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int MediaFailureQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int SiteBannerAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int BrochureDesignAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int StoryDesignAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int GifDesignAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int StandDesignAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int BannerDesignQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int BrochureDesignQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int StoryDesignQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int GifDesignQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int StandDesigQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int MotionQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int ArchivedmotionQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int AppliedMotionAvgTime { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int RecordedvideoQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int RecordedQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int NarrationEditQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int VideoArchiveQty { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست و عدد باید باشد")]
    public int VideoProduceAvgTime { get; set; }
}
