using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ChronicDisease
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<HealthDetailChronicDiseaseGroup> HealthDetailChronicDiseaseGroups { get; set; } = new List<HealthDetailChronicDiseaseGroup>();
}
