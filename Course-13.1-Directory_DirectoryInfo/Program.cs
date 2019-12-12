using System;
using System.IO;
using System.Collections.Generic;

namespace Course_13._1_Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp\directory";

            try
            {
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);

                Console.WriteLine("FOLDERS:");
                foreach(string x in folders)
                {
                    Console.WriteLine(x);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("\n\nFILES:");

                foreach (string x in files)
                {
                    Console.WriteLine(x);
                }


                Console.WriteLine("\n\nCreating Directory");

                Directory.CreateDirectory(path + @"\newFolders");

                Console.WriteLine("\n Create Directory OK!");

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: "+e.Message);
            }

            Console.ReadLine();

        }
    }
}
