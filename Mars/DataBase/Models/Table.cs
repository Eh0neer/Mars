using System;
using System.Collections.Generic;

namespace Mars;

public partial class Table
{
    public int Tableid { get; set; }

    public string Tablename { get; set; } = null!;

    public int Capacity { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();

    public virtual ICollection<Waiterassignment> Waiterassignments { get; } = new List<Waiterassignment>();
}
