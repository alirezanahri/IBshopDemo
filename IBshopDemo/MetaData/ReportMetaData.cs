using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class ReportMetaData
    {
        public int ReportId { get; set; }
        [Display(Name = "نام گزارش")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        public string ReportName { get; set; } = null!;



    }
    [ModelMetadataType(typeof(ReportMetaData))]
    public partial class Report
    {

    }
}
