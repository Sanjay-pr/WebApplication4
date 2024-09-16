using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class District
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public long StateId { get; set; }

    public virtual ICollection<DistrictDetail> DistrictDetails { get; set; } = new List<DistrictDetail>();

    public virtual ICollection<KaryalayaSetup> KaryalayaSetups { get; set; } = new List<KaryalayaSetup>();

    public virtual ICollection<LocalLevel> LocalLevels { get; set; } = new List<LocalLevel>();

    public virtual ICollection<Sikshya> Sikshyas { get; set; } = new List<Sikshya>();

    public virtual State State { get; set; } = null!;

    public virtual ICollection<UserDetail> UserDetails { get; set; } = new List<UserDetail>();
}
