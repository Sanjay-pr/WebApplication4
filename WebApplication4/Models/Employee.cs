using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long DepartmentId { get; set; }

    public long DesignationId { get; set; }

    public long? WardId { get; set; }

    public string? Phone { get; set; }

    public string? Photo { get; set; }

    public string? Address { get; set; }

    public long LocalLevelId { get; set; }

    public bool IsActive { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Designation Designation { get; set; } = null!;

    public virtual LocalLevel LocalLevel { get; set; } = null!;

    public virtual Ward? Ward { get; set; }
}
