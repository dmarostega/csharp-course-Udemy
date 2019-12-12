using Course_Intermediate_Composition2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Course_Intermediate_Composition2.Entities
{
    class Order
    {

        DateTime Moment { get; set; }
        OrderStatus Status { get; set; }
        List<OrderItem> OrderItens = new List<OrderItem>();
        Client Client { get; set; }

        public Order()
        {
        }

        public Order(Client client,OrderStatus status)
        {
            Client = client;
            Moment = DateTime.Now;
            Status = status;
        }

        public void AddItem(OrderItem orderItem)
        {
            OrderItens.Add(orderItem);
        }

        public void RemoveItem(OrderItem orderItem)
        {
            OrderItens.Remove(orderItem);
        }

        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem x in OrderItens)
            {
                total += x.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder outOrder = new StringBuilder();

          
            outOrder.Append("Order Moment: ");
            outOrder.AppendLine(Moment.ToString());
            outOrder.Append("Order Status: ");
            outOrder.AppendLine(Status.ToString());
            outOrder.AppendLine(Client.ToString());
            outOrder.AppendLine("Order Items:");
            foreach(OrderItem oi in OrderItens)
            {
                outOrder.AppendLine(oi.ToString());
            }
            outOrder.Append("Total Price: $");
            outOrder.AppendLine("$" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return outOrder.ToString();
        }



    }
}
