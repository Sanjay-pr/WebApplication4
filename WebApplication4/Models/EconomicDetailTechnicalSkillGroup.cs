using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class EconomicDetailTechnicalSkillGroup
{
    public int Id { get; set; }

    public int EconomicDetailId { get; set; }

    public int TechnicalSkillId { get; set; }

    public int Male { get; set; }

    public int Female { get; set; }

    public int Other { get; set; }

    public virtual EconomicDetail EconomicDetail { get; set; } = null!;

    public virtual TechnicalSkill TechnicalSkill { get; set; } = null!;
}
