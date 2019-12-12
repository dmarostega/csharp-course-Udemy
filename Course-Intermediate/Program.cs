using System;
using Course_Intermediate.Entities;
using Course_Intermediate.Entities.Enums;

namespace Course_Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine("\n\nIN OrderStatus to string: " + txt);

            Console.WriteLine("\n\nString to OrderStatus: " + os);
        }
    }
}
