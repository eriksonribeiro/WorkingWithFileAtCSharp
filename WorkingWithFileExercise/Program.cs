using System;
using System.IO;

namespace WorkingWithFileExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Git\WorkingWithFileAtCSharp\WorkingWithFileExercise\resource\vendas.csv";
                TreatyFile.OpenFile(path);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
