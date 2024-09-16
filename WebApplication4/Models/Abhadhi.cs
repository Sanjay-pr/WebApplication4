using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Abhadhi
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<HouseOwnerAbdhiGroup> HouseOwnerAbdhiGroups { get; set; } = new List<HouseOwnerAbdhiGroup>();
}
