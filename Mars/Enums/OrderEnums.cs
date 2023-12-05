using System.ComponentModel;

namespace Mars.Enums
{
    public enum OrderStatus
    {
        [Description("Принят")]
        Accepted,
        [Description("Оплачен")]
        Paid,
        // Add more statuses as needed
    }


    public enum PaymentMethod
    {
        Cash,
        NonCash,
        // Add more payment methods as needed
    }
}