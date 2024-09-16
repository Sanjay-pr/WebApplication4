using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class ShikshyaType
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public bool? IsDeleted { get; set; }
}
