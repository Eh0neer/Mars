using System;
using System.Collections.Generic;

namespace Mars;

public partial class Order
{
    public int Orderid { get; set; }

    public DateOnly Orderdate { get; set; }

    public int? Tableid { get; set; }

    public int? Waiterid { get; set; }

    public string Status { get; set; } = null!;

    public string Paymentmethod { get; set; } = null!;

    public virtual ICollection<Cashorder> Cashorders { get; } = new List<Cashorder>();

    public virtual ICollection<Orderitem> Orderitems { get; } = new List<Orderitem>();

    public virtual Table? Table { get; set; }

    public virtual User? Waiter { get; set; }
}
