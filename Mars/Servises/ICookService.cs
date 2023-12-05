using System.Collections.Generic;
using Mars.Enums;

namespace Mars.Interfaces;

public interface ICookService
{
    List<Order> ViewOrdersForCook();
    void UpdateOrderStatus(Order order, OrderStatus newStatus);
}