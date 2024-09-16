using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class NagarikWadaPatraDoc
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long NagarikWadaPatraId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual NagarikWadaPatra NagarikWadaPatra { get; set; } = null!;
}
