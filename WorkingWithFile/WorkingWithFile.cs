using System;
using System.IO;

namespace WorkingWithFile
{
    public static class WorkingWithFile
    {
        public static void CallFile(string sourcePath, string targetPath)
        {
            Console.WriteLine("\nUsing FileInfo and File Classes!");

            if (File.Exists(targetPath))
                File.Delete(targetPath);

            FileInfo fileInfo = new FileInfo(sourcePath);
            fileInfo.CopyTo(targetPath);

            string[] lines = File.ReadAllLines(targetPath);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
        }
    }
}
