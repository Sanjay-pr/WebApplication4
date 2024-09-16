using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class Tax
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public long? LocalLevelId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<TaxDetail> TaxDetails { get; set; } = new List<TaxDetail>();
}
