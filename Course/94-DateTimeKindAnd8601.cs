using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _94_DateTimeKindAnd8601
    {
        public static void run()
        {

            /*
                Boa Prática- Armazenar em formato UTC 
                             Instanciar em formato local
                             

            Converter DateTime para Local ou UTC

            - ToLocalTime()
            - ToUniversalTime();
             */


            DateTime d1 = new DateTime(2000, 8, 13, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 13, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 13, 13, 5, 58);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);


            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 Kind: " + d1.Kind);
            Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 to UTC: " + d1.ToUniversalTime());

            Console.WriteLine("\n\nD2: " + d2);
            Console.WriteLine("D2 Kind: " + d2.Kind);
            Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 to UTC: " + d2.ToUniversalTime());

            Console.WriteLine("\n\nD3: " + d3);
            Console.WriteLine("D3 Kind: " + d3.Kind);
            Console.WriteLine("D3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("D3 to UTC: " + d3.ToUniversalTime());


            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");

            Console.WriteLine("\n\nISO-8601\nD4: " + d4);
            Console.WriteLine("D4 Kind: " + d4.Kind);
            Console.WriteLine("D4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("D4 to UTC: " + d4.ToUniversalTime());

            Console.WriteLine("\n\nD5: " + d5);
            Console.WriteLine("D5 Kind: " + d5.Kind);
            Console.WriteLine("D5 to Local: " + d5.ToLocalTime());
            Console.WriteLine("D5 to UTC: " + d5.ToUniversalTime());

            Console.WriteLine("\n\nWithParse to String()\n");
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ")); //CUIDADO !! Melhor garantir que o formato seja universal (conforme poxima linha)
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}
