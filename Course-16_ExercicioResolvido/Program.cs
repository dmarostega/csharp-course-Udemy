using System;
using System.Collections.Generic;
using System.IO;
using Course_16_ExercicioResolvido.Entities;
using System.Globalization;
using System.Linq;

namespace Course_16_ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.WriteLine("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');

                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

                    products.Add(new Product(name, price));
                }
            }

            var avg = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();

            Console.WriteLine("Average Price equal: " + avg.ToString("F2",CultureInfo.InvariantCulture));


            var listForName = from p in products where p.Price < avg orderby p.Name descending select p;

            foreach(Product p in listForName)
            {
                Console.WriteLine(p.Name + ", " + p.Price.ToString("F2",CultureInfo.InvariantCulture) );
            }


            Console.ReadLine();


        }
    }
}
