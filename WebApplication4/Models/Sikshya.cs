using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Sikshya
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? ContactNo { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }

    public string? Photo { get; set; }

    public long? WardId { get; set; }

    public long LocalLevelId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public long StateId { get; set; }

    public long DistrictId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual LocalLevel LocalLevel { get; set; } = null!;

    public virtual State State { get; set; } = null!;

    public virtual Ward? Ward { get; set; }
}
