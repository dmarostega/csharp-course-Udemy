using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _68_Nullable
    {
        public static void run()
        {

            //double x = null; // erro

            Nullable<double> x = null;//Nullable de double

            /*      OU   Melhor forma   */
            double? c = null; //? double opcional

            double? o = null;
            double? p = 10.0;

            Console.WriteLine("O: " + o);
            Console.WriteLine("O with DefultaValue: " + o.GetValueOrDefault());
            Console.WriteLine("P: " + p);
            Console.WriteLine("P with DefultaValue: " + p.GetValueOrDefault());

            Console.WriteLine("O hasValue: " + o.HasValue);
            Console.WriteLine("P hasValue: " + p.HasValue);

            //Console.WriteLine("O hasValue: " + o.Value);      //exceção por ser null
            if(o.HasValue)
                Console.WriteLine("O IS: "+ o.Value);
            else
                Console.WriteLine("O Is Null");


            Console.WriteLine("P hasValue: " + p.Value);

            /*  OPERADOR DE COALESCÊNCIA NULL   */

            double? z = null;

            double v = z ?? 5;




        }
    }
}
