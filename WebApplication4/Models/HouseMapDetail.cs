﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class HouseMapDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<HouseDetail> HouseDetails { get; set; } = new List<HouseDetail>();
}
