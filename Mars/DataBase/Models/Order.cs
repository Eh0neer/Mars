using System;
using System.Collections.Generic;
using Mars.Enums;

namespace Mars
{
    public partial class Order
    {
        public int Orderid { get; set; }

        public DateOnly Orderdate { get; set; }

        public int? Tableid { get; set; }

        public int? Waiterid { get; set; }

        // Use the OrderStatus enum instead of string
        public OrderStatus Status { get; set; } = OrderStatus.Accepted;

        // Use the PaymentMethod enum instead of string
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;

        public virtual ICollection<Cashorder> Cashorders { get; } = new List<Cashorder>();

        public virtual ICollection<Orderitem> Orderitems { get; } = new List<Orderitem>();

        public virtual Table? Table { get; set; }

        public virtual User? Waiter { get; set; }
    }
}