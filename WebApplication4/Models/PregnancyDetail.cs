﻿using System;
using System.Collections.Generic;

namespace WebApplication4.Models;

public partial class PregnancyDetail
{
    public int Id { get; set; }

    public string AmmaKoNam { get; set; } = null!;

    public int GarvRaheKoPatak { get; set; }

    public string? GarvPrachianPatak { get; set; }

    public string? Ttkhopa { get; set; }

    public string? WhatDoUeat { get; set; }

    public int GharMuliId { get; set; }

    public virtual HouseOwnerDetail GharMuli { get; set; } = null!;
}
