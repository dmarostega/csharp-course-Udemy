using System;
using System.Globalization;
using System.IO;

namespace Course_13_ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  ARQUIVO CSV     */
            string sourcePath = @"c:/temp/fixacao.csv";

            try
            {
                string directory = Path.GetDirectoryName(sourcePath);

                if (!Directory.Exists(directory + "/out"))
                {
                    Directory.CreateDirectory(directory + "/out");
                    Console.WriteLine("\nCriou Diretório!\n");
                }

                if (!File.Exists(directory + "/out/summary.csv"))
                {
                    File.Create(directory + "/out/summary.csv");
                    Console.WriteLine("\nCriou summary.csv!\n");
                }

                string fileSource = directory + "/out/summary.csv";
                StreamWriter writer = new StreamWriter(fileSource);

                Console.WriteLine("Exercicio De Fixação!!\n");
                using(FileStream fs = new FileStream(sourcePath, FileMode.Open))
                {
                    using(StreamReader x = new StreamReader(fs))
                    {
                        while (!x.EndOfStream)
                        {
                            string line = x.ReadLine();
                            Console.WriteLine("Lendo linha: " + line);
                            string[] brokenLine = line.Split(";");
                            Console.WriteLine("Separando Colunas");
                            Console.WriteLine("Calculando Item: " + brokenLine[0] + ", " + brokenLine[2] + " x " + brokenLine[1]);
                            string newLine = brokenLine[0] + ";" + (double.Parse(brokenLine[2], CultureInfo.InvariantCulture) * double.Parse(brokenLine[1], CultureInfo.InvariantCulture)).ToString("F2") + ";";
                            Console.WriteLine("Escrevendo linha: " + newLine+"\n\n");
                            writer.WriteLine(newLine);
                        }
                    }
                }
                writer.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: " + e.Message);
            }

            Console.WriteLine("\n\nFIM");
            Console.ReadLine();
        }
    }
}
