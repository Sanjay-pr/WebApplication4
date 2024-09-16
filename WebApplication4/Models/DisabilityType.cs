using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class DisabilityType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<HealthDetailDisabilityTypeGroup> HealthDetailDisabilityTypeGroups { get; set; } = new List<HealthDetailDisabilityTypeGroup>();
}
