using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class BranchRanking
{
    [Key]
    [Required(ErrorMessage = "این فیلد اجباریست و باید بصورت عددی باشد")]
    public int Id { get; set; }

    public int? BranchRankingId { get; set; }

    public int? BranchId { get; set; }

    public int? GanjinehRank { get; set; }

    public int? Andokhtehrank { get; set; }

    public int? ServatRank { get; set; }

    public int? Bimehrank { get; set; }

    public int? IBcrowdrank { get; set; }

    public int? Productrank { get; set; }

    public int? Sandoghrank { get; set; }

    public int? SatisfactionRank { get; set; }

    public int? Servicerank { get; set; }

    public int? TotalRank { get; set; }
}
