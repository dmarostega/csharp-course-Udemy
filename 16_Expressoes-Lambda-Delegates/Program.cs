using System;
using System.Collections.Generic;
using Course_16_Expressoes_Lambda.Entities;
using Course_16_Expressoes_Lambda_Delegates.Services;
using System.Linq;

namespace Course_16_Expressoes_Lambda_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10.0;
            double b = 12.0;

            Console.WriteLine("Classe com Metodos simples, sem DELEGATE: ");
            double result = CalculationService.Max(a,b);
            Console.WriteLine(" CalculationService.Max(a,b): " + result);


            double result1 = CalculationService.Sum(a, b);
            Console.WriteLine(" CalculationService.Sum(a,b): " + result1);


            double result2 = CalculationService.Square(a);
            Console.WriteLine(" CalculationService.Square(a): " + result2);

            Console.WriteLine("\n\nCom Delegate. ");

            /*
                 O delegate BinaryNumricOperation, só funcionará para metodos que esperam 2 argumento.
                 No exemplo da Classe CalculationService, o delegate não funcionará com o método .Square(..) pois esse espera apenas um parametro.             
             */
            BinaryNumericOperation op = CalculationService.Sum;

            double result4 = op(a, b);
            Console.WriteLine(result4);

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.0));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /*  delegate PREDICATE  */
            list.RemoveAll(p => p.Price <= 100.00);

            Console.WriteLine("\n\nExemplo delegate Predicate: return bool");

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n\nExemplo delegate Action: void");



            Action<Product> act = UpdatePrice; //referencia para função UpdatePrice

            //OR
            list.ForEach(act);

            //OR
            list.ForEach(UpdatePrice);

            //OR
            Action<Product> act2 = p => { p.Price += p.Price * 0.1; }; //função anônima

            //OR
            list.ForEach(p => { p.Price += p.Price * 0.1; });   //expressão lambda

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n\nExemplo delegate Func: TResult");

            List<string> resultToFunc = list.Select(NameUpper).ToList();

            //OR

            Func<Product, string> func = NameUpper;
            List<string> resultToFunc2 = list.Select(func).ToList();

            //OR  mesmo do ACTION            


            foreach (string s in resultToFunc)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        //for Action delegate
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        //for Func delegate with select linq
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
