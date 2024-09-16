using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class UserDetail
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? PhoneNo { get; set; }

    public string Email { get; set; } = null!;

    public long StateId { get; set; }

    public long DistrictId { get; set; }

    public long LocalLevel { get; set; }

    public string? Address { get; set; }

    public long? WardId { get; set; }

    public string? Photo { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual LocalLevel LocalLevelNavigation { get; set; } = null!;

    public virtual State State { get; set; } = null!;

    public virtual Ward? Ward { get; set; }
}
