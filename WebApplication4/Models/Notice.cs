using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Notice
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Date { get; set; }

    public string? Image { get; set; }

    public long LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual LocalLevel LocalLevel { get; set; } = null!;
}
