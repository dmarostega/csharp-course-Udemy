using System;
using System.Collections.Generic;

namespace Course
{
    class _82_Conjuntos
    {
        public static void run()
        {
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(4);
            B.Add(5);

            Console.WriteLine("Conjunto A");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Conjunto B");
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("Procurando um numero no conjunto A");
            Console.WriteLine("Digite um valor:");

            int N = int.Parse(Console.ReadLine());

            if (A.Contains(N))
            {
                Console.WriteLine(N + " pertence ao conjunto A");
            }else
                Console.WriteLine(N + " não pertence ao conjunto A");


            Console.WriteLine( "Removendo item B");
            B.Remove(4);

            Console.WriteLine("Conjunto B");
            foreach (int x in B)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("ExceptWith - vai em A remove itens igual com B");

            A.ExceptWith(B);
            Console.WriteLine("Conjunto A");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }



            Console.WriteLine("Union - A com B");

            A.UnionWith(B);
            Console.WriteLine("Conjunto A");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }


            Console.WriteLine("Intersect - A com B");

            A.IntersectWith(B);
            Console.WriteLine("Conjunto A");
            foreach (int x in A)
            {
                Console.WriteLine(x);
            }




        }
    }
}
