using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _92_DateTimeOperations
    {
        public static void run()
        {
            DateTime d = new DateTime(2011, 08, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("Propriedades possivelmente a serem utilizadas do DateTime\n\n");
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " +d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Kind: " + d.Kind);
            Console.WriteLine("6) Hour: " + d.Hour);
            Console.WriteLine("7) Minuttes: " + d.Minute);
            Console.WriteLine("8) Second: "+ d.Second);
            Console.WriteLine("9) Millisecond: " + d.Millisecond);
            Console.WriteLine("10) Month: " + d.Month);
            Console.WriteLine("13) Year: " + d.Year);
            Console.WriteLine("11) Ticks:" + d.Ticks);
            Console.WriteLine("12) (eh um TimeSpan) TimeOfDay: " + d.TimeOfDay);


            Console.WriteLine("\n\nMetodos");
            Console.WriteLine("1) ToLongDateString: " + d.ToLongDateString());
            Console.WriteLine("2) ToLongTimeString: " + d.ToLongTimeString());
            Console.WriteLine("3) ToShortDateString: " + d.ToShortDateString());
            Console.WriteLine("4) ToShortTimeString: " + d.ToShortTimeString());
            Console.WriteLine("5) ToString: " + d.ToString());
            Console.WriteLine("5.1) ToString Mask: " + d.ToString("yyyy/MM/dd HH:mm:ss"));
            Console.WriteLine("5.2) ToString Maks 2: "+ d.ToString("yyyy/MM/dd HH:mm:ss.fff"));

            DateTime d2 = d.AddHours(2);

            Console.WriteLine("\n\nOperações DateTime");
            Console.WriteLine("AddHours \n  Data Original: " + d + " adicionou: " + d2);

        }
    }
}
