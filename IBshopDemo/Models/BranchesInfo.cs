using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class BranchesInfo
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و باید عدد باشد")]
    public int BranchCode { get; set; }
    [Required(ErrorMessage = "این فیلد اجباریست ")]
    public string BranchLocation { get; set; } = null!;

    public string? BranchManager { get; set; }

    public virtual ICollection<FixIncomeProperty> FixIncomeProperties { get; set; } = new List<FixIncomeProperty>();

    public virtual ICollection<MixProperty> MixProperties { get; set; } = new List<MixProperty>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
