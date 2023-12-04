using System;
using System.Collections.Generic;

namespace Mars;

public partial class Waiterassignment
{
    public int Waiterassignmentid { get; set; }

    public int? Waiterid { get; set; }

    public int? Tableid { get; set; }

    public virtual Table? Table { get; set; }

    public virtual User? Waiter { get; set; }
}
