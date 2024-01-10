using System;
using System.Collections.Generic;

namespace Mars.Interfaces;

public interface IAdmin
{
    void RegisterUser(User newUser);
    void TerminateUser(int userId);
    void AssignShift(int shiftId, int userId);
    void AssignTableToWaiter(int waiterId, int tableId);
    List<Order> ViewAllOrders();
    void EditUnpaidOrder(Order order);
    Report GenerateOrderReport(DateTime startDate, DateTime endDate);
    Report GenerateRevenueReport(DateTime startDate, DateTime endDate);
}