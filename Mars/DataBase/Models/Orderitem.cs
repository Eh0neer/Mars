using System;
using System.Collections.Generic;

namespace Mars;

public partial class Orderitem
{
    public int Orderitemid { get; set; }

    public int? Orderid { get; set; }

    public int? Dishid { get; set; }

    public int Quantity { get; set; }

    public virtual Dish? Dish { get; set; }

    public virtual Order? Order { get; set; }
}
