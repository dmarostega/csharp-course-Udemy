using Course_Intermediate.Entities.Enums;
using System;

namespace Course_Intermediate.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status {get; set;}

        public override string ToString()
        {
            return  "Order\n"+
                    "\nId: " + Id +
                    "\nData: " + Moment +
                    "\nStatus: " + Status;
        }
    }
}
