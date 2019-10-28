using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class _89_FuncoesInteressantesString
    {

        public static void run()
        {
            string original = "abcde FHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper(); //toas em maiusculo
            string s2 = original.ToLower(); //todas em minusculo
            string s3 = original.Trim();    //remove espaços em branco do inicio e do fim

            int n1 = original.IndexOf("bc"); //posição do 'bc'
            int n2 = original.LastIndexOf("bc"); //ultima posição de 'bc'

            string s4 = original.Substring(3); // opções: Substering(3); <- corta string inciando pela posição 3 Substring(3,8); corta a string da posição 3 até posição 8
            string s5 = original.Substring(2,5);

            string s6 = original.Replace('a','X'); //substitui carateer ou string

            string s7 = original.Replace("abc","x--y"); //substitui carateer ou string

            bool b1 = String.IsNullOrEmpty(original);
            bool b2 = String.IsNullOrWhiteSpace(original);


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf(bc): -" + n1 + "-");
            Console.WriteLine("Cortando apartir do 3: -" + s4 + "-");
            Console.WriteLine("Cortando apartir do 2 até 5: -" + s5 + "-");
            Console.WriteLine("Substituindo: -" + s6 + "-");
            Console.WriteLine("Substituindo: -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: -" + b1 + "-");
            Console.WriteLine("IsNullOrWhiteSpace: -" + b2 + "-");



        }
    }
}
