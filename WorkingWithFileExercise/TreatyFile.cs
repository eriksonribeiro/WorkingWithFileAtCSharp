using System;
using System.IO;
using System.Globalization;

namespace WorkingWithFileExercise
{
    public static class TreatyFile
    {
        public static void OpenFile(string fileIn)
        {
            if (File.Exists(fileIn))
            {
                string[] fileInLines = File.ReadAllLines(fileIn);

                string pathIn = Path.GetDirectoryName(fileIn);
                string pathOut = pathIn + @"\out";
                string fileOut = pathOut + @"\summary.csv";

                if (!Directory.Exists(pathOut))
                    Directory.CreateDirectory(pathOut);

                if (File.Exists(fileOut))
                    File.Delete(fileOut);

                StreamWriter sw = File.AppendText(fileOut);

                foreach (string line in fileInLines)
                {
                    string[] splittedLine = line.Split(';');

                    string name = splittedLine[0];
                    double price = double.Parse(splittedLine[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(splittedLine[2]);

                    Products product = new Products(name, price, quantity);

                    sw.WriteLine(product.ToString());
                }
                sw.Close();

                Console.WriteLine("File summary.csv created!");
            }
            else
                Console.WriteLine("File not found!");
        }
    }
}
