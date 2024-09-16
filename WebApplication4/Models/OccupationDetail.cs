using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class OccupationDetail
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PopulationDetailOccupationGroup> PopulationDetailOccupationGroups { get; set; } = new List<PopulationDetailOccupationGroup>();
}
