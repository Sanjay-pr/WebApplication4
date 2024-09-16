﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ProtectedArea
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Area { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public long? WardId { get; set; }

    public long LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? DistrictId { get; set; }

    public long? StateId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public virtual LocalLevel LocalLevel { get; set; } = null!;

    public virtual Ward? Ward { get; set; }
}
