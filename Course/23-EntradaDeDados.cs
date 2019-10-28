using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _23_EntradaDeDados
    {
        public static void run()
        {
            string nome;
            int quartos;
            double preco;
            string[] data;


            Console.WriteLine("Entre com seu nome completo:");
            nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa?");
            quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor do produto:");
            preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura:");
            data = Console.ReadLine().Split(' ');

            Console.WriteLine("Nome Completo: " + nome);
            Console.WriteLine("Quartos: " + quartos);
            Console.WriteLine("Preço do produto: " + preco);

            Console.WriteLine("Ultimo nome é {0} com idade de {1} anos. Altura informada {2}", data[0], data[1], data[2]);


        }
        
    }
}
