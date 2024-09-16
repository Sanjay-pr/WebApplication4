using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Animal
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<AgricultureDetailAnimalGroup> AgricultureDetailAnimalGroups { get; set; } = new List<AgricultureDetailAnimalGroup>();
}
