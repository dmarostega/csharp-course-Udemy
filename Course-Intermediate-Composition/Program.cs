using System;
using System.Globalization;
using Course_Intermediate_Composition.Entities;
using Course_Intermediate_Composition.Entities.Enum;

namespace Course_Intermediate_Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome do Departamento: ");

            string deptName = Console.ReadLine();

            Console.WriteLine("Enter Worker data:\nName:");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract datas: ");
                Console.WriteLine("Date (DD/MM/YYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): " );
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }


            Console.WriteLine("Enter month and year to calculate income (MM/YYY): ");
            string monthAdnYear = Console.ReadLine();

            int month = int.Parse(monthAdnYear.Substring(0, 2));
            int year = int.Parse(monthAdnYear.Substring(3));


            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Salary("+monthAdnYear+"): " + worker.Income(year,month));


        }
    }
}
