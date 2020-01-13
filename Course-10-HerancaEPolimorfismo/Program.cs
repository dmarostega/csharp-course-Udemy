using System;
using Course_10_HerancaEPolimorfismo.Entities;

namespace Course_10_HerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herança!");
            Console.WriteLine("É um tipo de associação que permite a uma classe herde dados e comportamentos de outra.");
            Console.WriteLine("\n Vantagens: \n - Re-uso\n - Polimorfismo!!\n\n");
            Console.WriteLine("Sintaxe: \n - :(estende)\n - base(referência para a superclasse)\n");
            Console.WriteLine("Definições Importantes: - Relação 'é-um',\n - Gerenralização/Especialização,\n - Superclasse (classe base) / subclasse (classe derivada),\n - Herança / Extesão,\n" +
                            " - Herança é uma associação entre classes (e não entre objetos)\n\n");

            Console.WriteLine("Exemplo 1: protected ");

            BusinessAccount account = new BusinessAccount(8010, "Bob Brow", 100.0, 500.00);
            Console.WriteLine(account.Balance);

            Console.WriteLine("UPCASTING & DOWNCASTING!");
            Console.WriteLine("Upcating: casting da subclasse para superclasse. Uso comum: polimorfismo.");
            Console.WriteLine("Downcasting: Casting da superclasse para subclasse. Palavra is e as. ");

            Console.WriteLine("Exemplo 2: ");

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1001, "Maria", 0.0, 500.0);


            //UPCASTING
            Console.WriteLine("\n UpCasting (é um)\n");
            Account acc1 = bacc; //polimosrfismo
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //nesse momento, o compilador entende que acc3 é do tipo Account;
            Account acc3 = new SavingsAccount(1004, "Saving Ana", 0.0, 0.001);

            //DOWNCAST
            Console.WriteLine("\n DownCast \n");
            // BusinessAccount acc4 = acc2; //erro
            BusinessAccount acc4 = (BusinessAccount) acc2; //Acc2 é do tipo Account, 
            //nesse caso, o Loan funconará pois acc2 (Account) é compativel com BussinessAccount
            acc4.Loan(100.0);

            //acc3 é do tipo Account porém instânciado como SavingAccount
            //Erro pois acc3 instancido como SavingsAccount não é compatível com Bussinesse account, o erro so será apresentado na compilação
            //BusinessAccount acc5 = (BusinessAccount)acc3;


            //falha pois acc3 não é do tipo BusinessAccount
            if(acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount; //sintaxe alternativa
                acc5.Loan(100.0);
                Console.WriteLine("Loan!");
            }

            //OK
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("UpdateBalance!");
            }




            //acc3.Loan(150.0); 













            Console.ReadLine();
        }
    }
}
