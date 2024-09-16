using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<HouseOwnerCountryGroup> HouseOwnerCountryGroups { get; set; } = new List<HouseOwnerCountryGroup>();
}
