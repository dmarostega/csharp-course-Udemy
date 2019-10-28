using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _91_TimeSpan
    {
        public static void run()
        {
            /*
             Representa uma duração
             É um tipo Valor (Struct)

            Internamente: armazena uma duração na forma de ticks (100 nanosegundos)

            TimeSpan t1 = new TimeSpan(0,1,30); hora, minutos, segundos
             
             */


            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            Console.WriteLine("Construtores TimeSpan");

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(900000000L);
            TimeSpan t4 = new TimeSpan(2, 11, 21);//hora,minuto,segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21); //dia, hora, minuto,segundo
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21, 321);//dia, hora, minuto, segundo, milisegundo

            Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4}",t2,t3,t4,t5,t6);

            Console.WriteLine("Metodos FROM, converter no modo que quizer...");

            TimeSpan t7 = TimeSpan.FromDays(1.5);
            TimeSpan t8 = TimeSpan.FromHours(1.5);
            TimeSpan t9 = TimeSpan.FromMinutes(1.5);
            TimeSpan t10 = TimeSpan.FromSeconds(1.5);
            TimeSpan t11 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t12 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(" {0} \n {1} \n {2} \n {3} \n {4} \n {5}", t7, t8, t9, t10, t11, t12);

        }
    }
}
