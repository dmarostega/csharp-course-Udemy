using System;
using System.Collections.Generic;
using Course_16_Expressoes_Lambda.Entities;

namespace Course_16_Expressoes_Lambda
{
    class Program
    {
        /*  SEM Transparência Referial: porque trabalhc om valor que está fora dela..  esse GlobalValue*/
        public static int globalValue = 3;

        static void Main(string[] args)
        {
            Console.WriteLine("Expressões Lambda 1 - COMPARISON<T> !!\n\n");


            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            /* sem comparison
             * 
                Nesse exemplo a classe Product não fica fechada para alteração.
                No caso, de ordenar por outro atributo, deverá alterar a classe Product            
            */
            //   list.Sort();

            /*  Com COMPARISON Alternativa 1 */
            //list.Sort(CompareProduct);

            /*  Com COMPARISON Alternativa 2*/
            //  Comparison<Product> comp = CompareProduct;
            //  list.Sort(comp);

            /*  Com COMPARISON Alternativa 3, sem função auxiliar. com EXPRESSAO LAMBDA  ( função anônima! )   */
            //  Comparison<Product> comp = (p1,p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //  list.Sort(comp);

            //  OR
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n\nExpressões Lambda 2 - SEM Transparência referencial!!\n\n");

            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect);
            Console.WriteLine(string.Join(" ", vect));


            Console.ReadLine();
        }

        //Tipo Delegate
        /* 
         * função para Comparison Alternativas 1 e 2
         * static int CompareProduct(Product p1,  Product p2)
          {
              return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
          }

           */
    
        /*  Função para Tranparência Refedrencial!! */ 
        public static void ChangeOddValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    numbers[i] += globalValue;
                }
            }
        }
    }
}
