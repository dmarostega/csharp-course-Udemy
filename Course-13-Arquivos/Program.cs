using System;
using System.IO;

namespace Course_13_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string sourcePathToUsing = @"c:\temp\file2.txt";
            string sourcePathToUsingResume = @"c:\temp\file2.txt";
            string targetPath = @"c:\temp\file3.txt";

            string sourcePathToStreamWriter = @"c:\temp\file2.txt";
            string targetPathToStreamWriter = @"c:\temp\file3.txt";

            FileStream fs = null;
            StreamReader sr = null;
            StreamReader srWithFile = null;

            try
            {
                Console.WriteLine("\n\nFile & FileInfo\n\n");

                FileInfo fileInfo = new FileInfo(sourcePath);
                //  fileInfo.CopyTo(sourcePathToUsing);

                // FileInfo targetFileInfo = new FileInfo(targetPath);

                /*        if (File.Exists(targetPath))
                        {
                            Console.WriteLine("FILEINFO EXISESSSS");
                            fileInfo.CopyTo(targetPath);
                        }
                        else
                        {
                            Console.WriteLine("NAOOOO  FILEINFO EXISESSSS");

                        }

            */

                string[] lines = File.ReadAllLines(sourcePath);
                Console.WriteLine("FILE Static");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }


                Console.WriteLine("\n\nFileStream e StreamReader\n\n");

                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new StreamReader(fs);

                //OR
                srWithFile = File.OpenText(targetPath);

                sr.Close();
                fs.Close();


                while (!srWithFile.EndOfStream)
                {
                    //string lineStream = sr.ReadLine();
                    string lineStream = srWithFile.ReadLine();
                    Console.WriteLine(lineStream);
                }

                srWithFile.Close();

                using (FileStream fsWithUsingBlock = new FileStream(sourcePathToUsing, FileMode.Open))
                {
                    using(StreamReader srWithUsingBlock  = new StreamReader(fsWithUsingBlock))
                    {
                        while (!srWithUsingBlock.EndOfStream)
                        {
                            string lineStream = srWithUsingBlock.ReadLine();
                            Console.WriteLine(lineStream);
                        }

                    }
                }

                //OR

                using (StreamReader srWithUsingBlock = File.OpenText(sourcePathToUsingResume))
                {
                    while (!srWithUsingBlock.EndOfStream)
                    {
                        string lineStream = srWithUsingBlock.ReadLine();
                        Console.WriteLine(lineStream);
                    }

                }

                Console.WriteLine("\n\nStreamWriter \n\n");


                string[] linesStreamWriter = File.ReadAllLines(sourcePathToStreamWriter);

                using(StreamWriter sw = File.AppendText(targetPathToStreamWriter))
                {
                    foreach(string line in linesStreamWriter)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }


            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu...");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }

            Console.ReadLine();
        }
    }
}
