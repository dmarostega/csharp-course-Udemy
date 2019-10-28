using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /** AULTA 15 TIPOS */
       /*     sbyte x = 100;  // -128 a 238 
            short s = 100;  // -32768 a 32767 
            byte m1 = 255;  //não aceita valor negativo (unsigned)
            int n3 = 2147483647;
            long n4 = 2147483648L;

            bool completo = false;
            char genero = 'F';
            char letra = '\u0041'; //codigo unicode

            float n5 = 3.5f;  //o 'f' para o complilador não confundir com double;
            double n6 = 3.5;


            m1++;
            */
            /* 
             *  overflow: quando o valor estrapola o valor aceita pelo tipo;          
             *            quando extrapolar o valor máximo, ele volta ao limite oposto. exe byte=257 volta para 0 (pois eh unsigned)
             */


            /*  Console.WriteLine(m1);
               Console.WriteLine(n3);
               Console.WriteLine(completo);
               Console.WriteLine(genero);
               Console.WriteLine(letra);
               Console.WriteLine(n4);

       */

            string op = "";
        //    do {
                Console.Clear();
            //Console.WriteLine("Executar Função? (y/n): ");
            //   op = Console.ReadLine();

            //_23_EntradaDeDados.run();
            //_68_Nullable.run();
            //_72_ModificadoreParams.run();
            //_82_Conjuntos.run();
            //_89_FuncoesInteressantesString.run();
            //_90_DateTime.run();
            // _91_TimeSpan.run();
            //_92_DateTimeOperations.run();
            // _93_TimeSpanOperations.run();
            _94_DateTimeKindAnd8601.run();

            //  } while (op  == "y");
        }
    }
}
