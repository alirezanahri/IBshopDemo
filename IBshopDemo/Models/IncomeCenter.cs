using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class IncomeCenter
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int IncomecenterId { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست  ")]
    public string IncomeCenterName { get; set; } = null!;

    public virtual ICollection<FixIncomeProperty> FixIncomeProperties { get; set; } = new List<FixIncomeProperty>();

    public virtual ICollection<MixProperty> MixProperties { get; set; } = new List<MixProperty>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
