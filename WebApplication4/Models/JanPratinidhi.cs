using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class JanPratinidhi
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Desiganation { get; set; }

    public string? PhoneNo { get; set; }

    public string? Photo { get; set; }

    public long LocalLevelId { get; set; }

    public long? WardId { get; set; }

    public bool IsActive { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LocalLevel LocalLevel { get; set; } = null!;

    public virtual Ward? Ward { get; set; }
}
