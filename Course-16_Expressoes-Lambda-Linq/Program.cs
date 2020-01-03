using System;
using System.Linq;
using System.Collections.Generic;

using Course_16_Expressoes_Lambda_Linq.Entities;


namespace Course_16_Expressoes_Lambda_Linq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);

            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Introdução ao Linq\n\n");


            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5, 6, 7, 8 };

            //Define the query expression
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);


            foreach(int n in result)
            {
                Console.WriteLine("Number: " + n);
            }


            Console.WriteLine("\n\nTestando Operadores Linq\n\n" );

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name="Computer", Price = 1100.00, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() { Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() { Id = 6, Name = "Tablet", Price = 700.00, Category = c2},
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() { Id = 9, Name = "MacBook", Price =1800.0, Category = c2},
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1}

            };


            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("\nTIER 1 AND PRICE < 900: ", r1);

            var r2 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0).Select(x => x.Price += x.Price * 0.1);
            Print("\nTIER 1 AND PRICE < 900 mais juros 10% : ", r2);

            var r3 = products.Where(p => p.Category.Name == "Tools").Select(x => x.Name);
            Print("\nName of Producto from tools: ", r3);

            var r4 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("\nProducts init 'C': ", r4);

            var r5 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("\nOrder to price and name: ", r5);

            var r6 = r5.Skip(2).Take(4);
            Print("\nSkip 2 tak3 4: ", r6);

            var r7 = products.First();
            Console.WriteLine("First or Default Product: "  + r7);

            var r8 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or Default Product with Price equal 3000.00: " + r8);

            var r9 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default equal 3: " + r9);

            var r10 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Default equal 30: " + r10);

            var r11 = products.Max(p => p.Price);
            Console.WriteLine("Produto mais caro: " + r11);

            var r12 = products.Min(p => p.Price);
            Console.WriteLine("Produto mais barato: "+r12);

            var r13 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price); 
            Console.WriteLine("Produto da categorias 1, soma: " + r13);

            var r14 = products.Average(p => p.Price);
            Console.WriteLine("Valor médio dos produtos: " + r14);

            //var r15 = products.Where(p => p.Category.Id == 5).Average(p => p.Price); //execption
            var r15 = products.Where(p => p.Category.Id == 5).Select(p=>p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Média de um produto de uma categoria inexistente: " + r15);


            var r16 = products.Where(p => p.Category.Id == 2).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma dos Produtos de Categoria 2: " + r16);

            var r17 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma dos Produtos de Categoria 5: " + r17);


            //   var rgrouping = products.GroupBy(p => p.Category);

            var rgrouping = from p in products group p by p.Category;

            Console.WriteLine();
            foreach(IGrouping<Category,Product> group in rgrouping)
            {
                Console.WriteLine("Category: " + group.Key.Name + ": ");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }


            Console.WriteLine("\n\nLinq com SQL!!\n\n");

            var r1Sql = from p in products where  p.Category.Tier == 1 && p.Price < 900.0
                        select p;

            Print("\nSQL: TIER 1 AND PRICE < 900 (Sql): ", r1Sql);

            var r2Sql = from p in products where p.Category.Tier == 1 && p.Price < 900.0
            select(p.Price += p.Price * 0.1);

            Print("\nTIER 1 AND PRICE < 900 mais juros 10% (Sql): ", r2Sql);

            var r3Sql =  from p in products where p.Category.Name == "Tools" select p.Name;
            Print("\nName of Producto from tools (Sql): ", r3Sql);

           // var r4Sql = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r4Sql = from p in products where  p.Name[0] == 'C'
                        select  new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("\nProducts init 'C' (Sql): ", r4Sql);

            var r5Sql = from p in products where p.Category.Tier == 1 orderby p.Price, p.Name
                       select p;
            Print("\nOrder to price and name (Sql): ", r5Sql);

            var r6Sql = (from p in r5Sql select p).Skip(2).Take(4);
            Print("\nSkip 2 tak3 4(Sql): ", r6Sql);




            Console.ReadLine();
        }
    }
}
