using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class SchoolLayer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EducationDetailSchoolGroup> EducationDetailSchoolGroups { get; set; } = new List<EducationDetailSchoolGroup>();
}
