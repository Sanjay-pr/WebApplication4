﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class EducationEducationalLevelGroup
{
    public int Id { get; set; }

    public int EducationId { get; set; }

    public int EducationalLevelId { get; set; }

    public int Male { get; set; }

    public int Female { get; set; }

    public int Other { get; set; }

    public virtual EducationDetail Education { get; set; } = null!;

    public virtual EducationalLevel EducationalLevel { get; set; } = null!;
}
