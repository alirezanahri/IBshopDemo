using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class RoleMetaData
    {
        public int RoleId { get; set; }
        [Display(Name = "کد نقش")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        public int? RoleUniqeCode { get; set; }
        [Display(Name = "نام نقش")]
        [Required(ErrorMessage = "وارد کردن  الزامی است")]
        public string? RoleName { get; set; }



    }
    [ModelMetadataType(typeof(RoleMetaData))]
    public partial class Role
    {

    }
}
