using IBshopDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models
{
    public class UserRoleMetaData
    {
        [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
        public long UserRoleId { get; set; }

        public int? UserId { get; set; }

        public int? RoleId { get; set; }



    }
    [ModelMetadataType(typeof(UserRoleMetaData))]
    public partial class UserRole
    {

    }
}
