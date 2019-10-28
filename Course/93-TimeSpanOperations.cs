using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _93_TimeSpanOperations
    {
        public static void run()
        {
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan tzero = TimeSpan.Zero;

            TimeSpan t = new TimeSpan(2, 3, 10, 23, 11);


            Console.WriteLine("TimeSpan Props:\n\n {0} \n {1} \n {2} ",t1,t2,tzero);
            Console.WriteLine("\nMore Props\n");
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("MilliSeconds: " + t.Milliseconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);
            Console.WriteLine("FIM");

            Console.WriteLine("\nOperações\n");

            TimeSpan t3 = new TimeSpan(1, 30, 40);
            TimeSpan t4 = new TimeSpan(2, 1, 15);

            Console.WriteLine("Somando: "+t3.ToString() + " e " + t4.ToString() + "  ==  " + t3.Add(t4));
            Console.WriteLine("Subtraindo: "+t3.ToString() + " e " + t4.ToString() + "  ==  " + t3.Subtract(t4));
            Console.WriteLine("Multiplicando Dobrdo de : " + t3.ToString() + "  ==  " + t3.Multiply(2.0));
            Console.WriteLine("Dividindo: " + t3.ToString() + " Metade ==  " + t3.Divide(2.0));



        }
    }
}
