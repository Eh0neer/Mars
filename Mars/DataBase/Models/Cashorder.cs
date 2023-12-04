using System;
using System.Collections.Generic;

namespace Mars;

public partial class Cashorder
{
    public int Cashorderid { get; set; }

    public int? Orderid { get; set; }

    public string Paymentmethod { get; set; } = null!;

    public virtual Order? Order { get; set; }
}
