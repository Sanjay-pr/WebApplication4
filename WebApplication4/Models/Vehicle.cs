using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Vehicle
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<HouseOwnerDetail> HouseOwnerDetails { get; set; } = new List<HouseOwnerDetail>();
}
