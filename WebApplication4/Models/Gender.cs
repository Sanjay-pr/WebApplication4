using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Gender
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? NameEng { get; set; }

    public virtual ICollection<GharMuliDetail> GharMuliDetails { get; set; } = new List<GharMuliDetail>();

    public virtual ICollection<GharMuliFamilyMarrageDetail> GharMuliFamilyMarrageDetails { get; set; } = new List<GharMuliFamilyMarrageDetail>();

    public virtual ICollection<HouseOwnerDetail> HouseOwnerDetails { get; set; } = new List<HouseOwnerDetail>();
}
