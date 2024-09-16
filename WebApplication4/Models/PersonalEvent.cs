using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PersonalEvent
{
    public int Id { get; set; }

    public int? Birth { get; set; }

    public int? Death { get; set; }
}
