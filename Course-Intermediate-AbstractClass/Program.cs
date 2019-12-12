using Course_Intermediate_AbstractClass.Entities;
using Course_Intermediate_AbstractClass.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course_Intermediate_AbstractClass
{
    class Program
    {
     
        static void Main(string[] args)
        {

            List<Shape> list = new List<Shape>();


            Console.Write("Enter the number of Shapes: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Shape {i} data: ");
                Console.Write("Rectagle or Circle (r/c)?");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Color (Balck/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(op == 'r')
                {
                    Console.Write("With:");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius:");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Circle(color, radius));
                }
            }


            Console.WriteLine("SHAPE AREAS");
            foreach(Shape x in list)
            {
                Console.WriteLine(x.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
