﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class DisabilityReason
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<HealthDetailDisabilityReasonGroup> HealthDetailDisabilityReasonGroups { get; set; } = new List<HealthDetailDisabilityReasonGroup>();
}
