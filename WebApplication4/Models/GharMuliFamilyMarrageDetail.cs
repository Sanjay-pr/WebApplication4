using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class GharMuliFamilyMarrageDetail
{
    public int Id { get; set; }

    public int GharMuliId { get; set; }

    public string FullName { get; set; } = null!;

    public int GenderId { get; set; }

    public string MarrageDate { get; set; } = null!;

    public DateTime MarrageDateEng { get; set; }

    public int MarrageTimeAge { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual HouseOwnerDetail GharMuli { get; set; } = null!;
}
