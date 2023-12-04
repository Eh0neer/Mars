using System;
using System.Collections.Generic;

namespace Mars;

public partial class Shiftassignment
{
    public int Shiftassignmentid { get; set; }

    public int? Shiftid { get; set; }

    public int? Userid { get; set; }

    public virtual Shift? Shift { get; set; }

    public virtual User? User { get; set; }
}
