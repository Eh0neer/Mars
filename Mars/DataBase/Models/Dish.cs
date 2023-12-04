using System;
using System.Collections.Generic;

namespace Mars;

public partial class Dish
{
    public int Dishid { get; set; }

    public string Dishname { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<Orderitem> Orderitems { get; } = new List<Orderitem>();
}
