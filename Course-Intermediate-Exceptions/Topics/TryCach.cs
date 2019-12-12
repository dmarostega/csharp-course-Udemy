using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Intermediate_Exceptions.Topics
{
    class TryCach
    {


        public static void run()
        {

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                Console.WriteLine(n1 / n2);
            }
            // catch (Exception e)
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error! Nâo é permitido divisão por zero!!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Impossível usar o formato informado!!");
            }
            finally //Executa tanto se der erro ou não
            {
                Console.WriteLine("ACABOU");
            }
        }
        
    }
}
