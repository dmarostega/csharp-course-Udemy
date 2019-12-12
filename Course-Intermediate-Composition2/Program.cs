using Course_Intermediate_Composition2.Entities;
using Course_Intermediate_Composition2.Entities.Enums;
using System;
using System.Globalization;

namespace Course_Intermediate_Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CLIENT DATA: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("BirthDay: (DD/MM/YYYY)");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name,email,birthdate);

            Console.WriteLine("Enter Order Data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(client, status);

            Console.WriteLine("How many items to this order ? ");
            int N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                Product product = new Product();

                Console.WriteLine("$Enter #{i} item data: ");
                Console.Write("Name: ");
                product.Name = Console.ReadLine();

                Console.Write("Product Price: ");
                product.Price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.WriteLine("Quantity: "); ;
                int quantity = int.Parse(Console.ReadLine());

                order.AddItem(new OrderItem(quantity, product.Price, product));              
            }

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine(order);


        }
    }
}
