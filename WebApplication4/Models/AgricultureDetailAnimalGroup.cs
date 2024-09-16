﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AgricultureDetailAnimalGroup
{
    public int Id { get; set; }

    public int AnimalId { get; set; }

    public int AgricultureDetailId { get; set; }

    public int Total { get; set; }

    public virtual AgricultureDetail AgricultureDetail { get; set; } = null!;

    public virtual Animal Animal { get; set; } = null!;
}
