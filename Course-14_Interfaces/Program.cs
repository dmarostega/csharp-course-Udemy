using System;
using System.Globalization;
using Course_14_Interfaces.Entities;
using Course_14_Interfaces.Services;

namespace Course_14_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(priceHour, priceDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice);
            Console.ReadLine();
        }
    }
}
