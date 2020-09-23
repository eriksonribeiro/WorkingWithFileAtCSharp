using System;
using System.IO;

namespace WorkingWithFile
{
    public static class WorkingWithStream
    {
        public static void CallStream(string sourcePath)
        {
            Console.WriteLine("\nUsing StreamReader and File Stream!");

            FileStream fs = new FileStream(sourcePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            Console.WriteLine(line);

            if (sr != null)
                sr.Close();

            if (fs != null)
                fs.Close();

        }

        public static void CallStreamSimple(string sourcePath)
        {
            Console.WriteLine("\nUsing StreamReader and File Classe (Simple way)!");

            StreamReader sr = File.OpenText(sourcePath);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

            if (sr != null)
                sr.Close();
        }

        public static void CallStreamWriter(string sourcePath, string targetPath)
        {
            Console.WriteLine("\nUsing StreamWriter and File!");

            if (File.Exists(targetPath))
                File.Delete(targetPath);

            string[] lines = File.ReadAllLines(sourcePath);

            StreamWriter sw = File.AppendText(targetPath);

            foreach (string line in lines)
            {
                sw.WriteLine(line.ToUpper());
            }

            if (sw != null)
                sw.Close();
        }
     }
}
