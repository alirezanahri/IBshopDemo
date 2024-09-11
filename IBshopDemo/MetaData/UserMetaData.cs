using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class UserMetaData
    {


        public int UserId { get; set; }
        [Display(Name = "کد ملی")]
        public string? NationalCode { get; set; }
        [Display(Name = "نام خانوادگی")]
        public string? LastName { get; set; }
        [Display(Name = "نام")]
        public string? FirstName { get; set; }
        [Display(Name = "شماره تلفن")]
        public string? PhoneNumber { get; set; }
        [Display(Name = "رمز عبور")]
        public string? Password { get; set; }






    }
    [ModelMetadataType(typeof(UserMetaData))]
    public partial class User
    {

    }
}
