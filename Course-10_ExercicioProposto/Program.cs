using System;
using System.Collections.Generic;
using System.Globalization;
using Course_10_ExercicioProposto.Entities;

namespace Course_10_ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #"+i+" data");
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: : ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(op == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCarge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCarge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("PAYMENTS: ");

            foreach (Employee x in employees)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();

        }
    }
}
