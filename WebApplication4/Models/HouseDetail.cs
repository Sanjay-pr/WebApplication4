using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class HouseDetail
{
    public int Id { get; set; }

    public int? WardNo { get; set; }

    public int HouseFloorId { get; set; }

    public int HouseRoofId { get; set; }

    public int HouseMapId { get; set; }

    public int HouseOwnershipId { get; set; }

    public int HouseOwnerDetailId { get; set; }

    public string? AnySuggestions1 { get; set; }

    public virtual HouseFloor HouseFloor { get; set; } = null!;

    public virtual HouseMapDetail HouseMap { get; set; } = null!;

    public virtual HouseOwnerDetail HouseOwnerDetail { get; set; } = null!;

    public virtual HouseOwnership HouseOwnership { get; set; } = null!;

    public virtual HouseRoof HouseRoof { get; set; } = null!;
}
