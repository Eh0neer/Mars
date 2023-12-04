using System;
using System.Collections.Generic;

namespace Mars;

public partial class Report
{
    public int Reportid { get; set; }

    public DateOnly Reportdate { get; set; }

    public string Reporttype { get; set; } = null!;

    public string Content { get; set; } = null!;
}
