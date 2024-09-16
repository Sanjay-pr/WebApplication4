﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PopulationDetailOccupationGroup
{
    public int Id { get; set; }

    public int PopulationDetailId { get; set; }

    public int OccupationDetailId { get; set; }

    public int Male { get; set; }

    public int Female { get; set; }

    public int Other { get; set; }

    public virtual OccupationDetail OccupationDetail { get; set; } = null!;

    public virtual PopulationDetail PopulationDetail { get; set; } = null!;
}
