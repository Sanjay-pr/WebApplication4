using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class TechnicalSkill
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EconomicDetailTechnicalSkillGroup> EconomicDetailTechnicalSkillGroups { get; set; } = new List<EconomicDetailTechnicalSkillGroup>();
}
