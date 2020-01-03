using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using Course_16_ExercicioFixacao_Employees.Entities;

namespace Course_16_ExercicioFixacao_Employees
{
    class Program
    {
        static void Main(string[] args)
        {


            /*
                Fazer um programa para ler os dados (nome, email e salário)
                de funcionários a partir de um arquivo em formato .csv.
                Em seguida mostrar, em ordem alfabética, o email dos
                funcionários cujo salário seja superior a um dado valor
                fornecido pelo usuário.
                Mostrar também a soma dos salários dos funcionários cujo
                nome começa com a letra 'M'.
             
             */


            try
            {
                List<Employee> employees = new List<Employee>();

                Console.Write("Entre com o caminho completo do arquivo: ");
                string path = Console.ReadLine();
                Console.Write("Entre com um valor para comparação salarial: ");
                double salaryBase = double.Parse(Console.ReadLine());


                using(StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream){
                        string[] employee = sr.ReadLine().Split(',');

                        string name = employee[0];
                        string email = employee[1];
                        double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);

                        employees.Add(new Employee(name, email, salary));
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Lista completa!!");

                var listEmails = employees.Where(e => e.Salary > salaryBase).OrderBy(e => e.Email);

                foreach(Employee e in employees)
                {
                    Console.WriteLine(e);
                }

                Console.WriteLine();
                Console.WriteLine("Email das pessoas com salario acime de " + salaryBase.ToString("F2", CultureInfo.InvariantCulture));
                
                foreach (Employee e in listEmails)
                {
                    Console.WriteLine(e.Email);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " +e.Message);
            }

            Console.ReadLine();

        }
    }
}
