using System;
using System.Collections.Generic;

namespace Mars;

public partial class Shift
{
    public int Shiftid { get; set; }

    public DateOnly Shiftdate { get; set; }

    public TimeOnly Starttime { get; set; }

    public TimeOnly Endtime { get; set; }

    public virtual ICollection<Shiftassignment> Shiftassignments { get; } = new List<Shiftassignment>();
}
