using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PopulationDetailCasteGroup
{
    public int Id { get; set; }

    public int CasteId { get; set; }

    public int PopulationId { get; set; }

    public int Male { get; set; }

    public int Female { get; set; }

    public int Other { get; set; }

    public virtual Caste Caste { get; set; } = null!;

    public virtual PopulationDetail Population { get; set; } = null!;
}
