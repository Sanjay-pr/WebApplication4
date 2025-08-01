﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AverageMonthlyIncome
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EconomicDetail> EconomicDetails { get; set; } = new List<EconomicDetail>();
}
