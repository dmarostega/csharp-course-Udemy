using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _72_ModificadoreParams
    {

        public static void run()
        {
            // Class  Sum sem params
         //   int s1 = _72_Calculator.Sum(new int[] { 2, 4, 3 });
         //   int s2 = _72_Calculator.Sum(new int[] { 2, 4 });

            int s1 = _72_Calculator.Sum(2, 4, 3 );
            int s2 = _72_Calculator.Sum(2, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
