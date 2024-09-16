using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class DisabilityCard
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<HealthDetailDisabilityCardGroup> HealthDetailDisabilityCardGroups { get; set; } = new List<HealthDetailDisabilityCardGroup>();
}
