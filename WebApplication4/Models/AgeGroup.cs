﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AgeGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<PopulationDetailAgeGroup> PopulationDetailAgeGroups { get; set; } = new List<PopulationDetailAgeGroup>();
}
