using System;
using System.IO;

namespace WorkingWithFile
{
    class Program
    {
        static void Main(string[] args)
        {

            Files files = new Files(@"C:\Git\WorkingWithFileAtCSharp\WorkingWithFile\resource\file.txt", @"C:\Git\WorkingWithFileAtCSharp\WorkingWithFile\resource\");

            try
            {
                // FileInfo and File Classes
                WorkingWithFile.CallFile(files.sourcePath, files.targetPath + "file2.txt");

                // FileStream and StreamReader Classes
                WorkingWithStream.CallStream(files.sourcePath);

                // File and StreamReader Classes Simple Way
                WorkingWithStream.CallStreamSimple(files.sourcePath);

                // Use Using to close the objects
                Console.WriteLine("\nUsing 'using' StreamReader and File Stream!");
                using (FileStream fs = new FileStream(files.sourcePath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }

                //StreamWriter
                WorkingWithStream.CallStreamWriter(files.sourcePath, files.targetPath+"file3.txt");

                //Directory and DirectoryFile Classes
                WorkingWithDirectory.CallDirectory(files.targetPath);
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error occurred!\n{e.Message}");
            }

            Console.ReadKey();
        }
    }
}
