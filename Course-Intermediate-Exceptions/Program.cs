using System;
using Course_Intermediate_Exceptions.Topics;
using Course_Intermediate_Exceptions.Entities;

namespace Course_Intermediate_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // TryCach.run();

            for(int i = 0; i < 6; ++i)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            Console.Write("Room Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Check-in (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Check-out (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if(checkOut <= checkIn)
            {
                Console.WriteLine("Erro nas datas...");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: "+reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update reservation: ");


                Console.Write("Check-in (dd/MM/yyyy): ");
                 checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out (dd/MM/yyyy): ");
                 checkOut = DateTime.Parse(Console.ReadLine());

                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in Reservation: Reservation dates for update must be future date.");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in Reservation:Check-out date must be after check-in date.");

                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: "+reservation);
                }
            }

        }
    }
}
