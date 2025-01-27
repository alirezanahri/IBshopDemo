﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IBshopDemo.Models;

public partial class Kpiplanning
{
    [Key]
    public int Id { get; set; }

    public string? KpiplanCode { get; set; }

    public string? DelonPrConf { get; set; }

    public string? EffImpAct { get; set; }

    public string? OtimpPercentage { get; set; }

    public string? PrImPercent { get; set; }

    public string? KmsavePercent { get; set; }

    public string? ArchivePer { get; set; }

    public string? Nps { get; set; }
}
