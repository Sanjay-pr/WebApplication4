using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class KaryalayaSetup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Address { get; set; } = null!;

    public long ProvinceId { get; set; }

    public long DistrictId { get; set; }

    public long PalikaId { get; set; }

    public string Email { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public int Wardno { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual LocalLevel Palika { get; set; } = null!;

    public virtual State Province { get; set; } = null!;
}
