using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class EducationDetailSchoolGroup
{
    public int Id { get; set; }

    public int SchoolLayerId { get; set; }

    public int SchoolTimeId { get; set; }

    public int EducationId { get; set; }

    public virtual EducationDetail Education { get; set; } = null!;

    public virtual SchoolLayer SchoolLayer { get; set; } = null!;

    public virtual SchoolTime SchoolTime { get; set; } = null!;
}
