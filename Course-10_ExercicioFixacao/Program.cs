using System;
using System.Collections.Generic;
using System.Globalization;
using Course_10_ExercicioFixacao.Entities;

namespace Course_10_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("PRoduct #"+i+" data: ");
                Console.Write("Common, Used or Imported: ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (op)
                {
                    case 'i':
                        Console.Write("Customs Fee: ");
                        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, customsFee));
                        break;
                    case 'u':
                        Console.Write("Manufacture Date (DD/MM/YYYY): ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, manufactureDate));
                        break;
                    default:
                        products.Add(new Product(name, price) );
                        break;
                }
            }


            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in products)
            {
                Console.WriteLine(p.PriceTag());
            }

            Console.ReadLine();
        }
    }
}
