using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class AgriculturePasuPanchiDetail
{
    public int Id { get; set; }

    public int? AgricultureDetailId { get; set; }

    public string? PasuPanchi { get; set; }

    public string? Pariman { get; set; }

    public string? Type { get; set; }

    public virtual AgricultureDetail? AgricultureDetail { get; set; }
}
