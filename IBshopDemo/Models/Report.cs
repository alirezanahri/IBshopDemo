using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class Report
{
    [Key]
    public int ReportId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست")]
    public string ReportName { get; set; } = null!;
}
