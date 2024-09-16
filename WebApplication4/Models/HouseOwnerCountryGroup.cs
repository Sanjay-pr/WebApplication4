using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class HouseOwnerCountryGroup
{
    public int Id { get; set; }

    public int CountryId { get; set; }

    public int HouseOwnerId { get; set; }

    public int? Count { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual HouseOwnerDetail HouseOwner { get; set; } = null!;
}
