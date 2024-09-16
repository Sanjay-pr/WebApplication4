using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Caste
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<GharMuliDetail> GharMuliDetails { get; set; } = new List<GharMuliDetail>();

    public virtual ICollection<PopulationDetailCasteGroup> PopulationDetailCasteGroups { get; set; } = new List<PopulationDetailCasteGroup>();
}
