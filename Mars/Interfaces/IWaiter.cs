using System;
using System.Collections.Generic;
using Mars.Enums; // Add this using statement at the top

namespace Mars.Interfaces
{
    public interface IWaiter
    {
        void CreateOrder(Order newOrder);
        List<Order> ViewOrdersForShift(int shiftId);
        void EditOrderStatus(Order order, OrderStatus newStatus);
        void CreateCashOrder(Order order, PaymentMethod paymentMethod);
        Report GenerateWaiterReport(DateTime startDate, DateTime endDate);
    }
}