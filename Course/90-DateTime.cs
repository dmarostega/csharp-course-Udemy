using System;
using System.Globalization;

namespace Course
{
    class _90_DateTime
    {
        /*
            Represante um INSTNTE, uma data
            É um tipo valor (struct)

            internamente armazena o número de "ticks" (100 nanosegundos ) desde a meia noite do dia 1 de janeiro do ano 1 da era comum;

         */

        public static void run()
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine("DateTime NOW: " + d1);
            Console.WriteLine(d1.Ticks);

            Console.WriteLine("\n\n DateTime(ano,mes,dia);");
            DateTime d2 = new DateTime(2019, 07, 06);

            Console.WriteLine("\n\n DateTune(ano,mes,dia,hora,minutos,segundos);");
            DateTime d3 = new DateTime(2018, 07, 06, 13, 45, 23);
            Console.WriteLine(d3);


            Console.WriteLine("\n\n DateTune(ano,mes,dia,hora,minutos,segundos,milisegundo);");
            DateTime d4 = new DateTime(2013, 05, 03, 13, 45, 23,500); //não exibe milisegndo, para isso terá que usr formatção
            Console.WriteLine(d4);

            Console.WriteLine("Builders: ");

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow; //horário de agora no formato GMT (universal)

            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);

            Console.WriteLine("DateTime Parses");

            DateTime d8 = DateTime.Parse("2019-08-10");
            DateTime d9 = DateTime.Parse("2019-08-10 10:46:22");
            DateTime d10 = DateTime.Parse("06/07/2005");
            DateTime d11 = DateTime.Parse("06/07/1982 11:45:51");

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);

            Console.WriteLine("DateTime Parse Exact");

            DateTime d12 = DateTime.ParseExact("2000-02-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/08/2004", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
        }

    }
}