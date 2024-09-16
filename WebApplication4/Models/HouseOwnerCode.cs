using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class HouseOwnerCode
{
    public int Id { get; set; }

    public long LocalLavelId { get; set; }

    public long WardId { get; set; }

    public int Code { get; set; }

    public int HouseOwnerId { get; set; }

    public virtual HouseOwnerDetail HouseOwner { get; set; } = null!;

    public virtual LocalLevel LocalLavel { get; set; } = null!;

    public virtual Ward Ward { get; set; } = null!;
}
