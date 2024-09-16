using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Earthquake2072
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<HouseOwnerDetail> HouseOwnerDetails { get; set; } = new List<HouseOwnerDetail>();
}
