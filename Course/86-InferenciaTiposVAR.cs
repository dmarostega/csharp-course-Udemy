using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _86_InferenciaTiposVAR
    {
        public static void run()
        {
            var x = 10; //o compilador entende que o tipo é int pelo valor
            var y = 20.0;
            var z = "Maria";


            //problema
            var w = z; //compilador entende que poderá ser qualquer tipo, podendo gera problemas

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}
