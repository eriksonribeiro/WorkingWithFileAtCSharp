using System.IO;
using System.Collections.Generic;
using System;

namespace WorkingWithFile
{
    public static class WorkingWithDirectory
    {
        public static void CallDirectory(string path)
        {
            Console.WriteLine("\nUsing Directory to createa new folder!:");

            if (Directory.Exists(path + @"\newfolder"))
                Directory.Delete(path + @"\newfolder");

            Directory.CreateDirectory(path + @"\newfolder");

            Console.WriteLine($"\nUsing Directory to enumerate folders!\nFolders in {Path.GetDirectoryName(path)}:");
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }

            Console.WriteLine($"\nUsing Directory to enumerate files!\nFiles in {Path.GetDirectoryName(path)}:");
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine($"{Path.GetFileName(file)}");
            }

        }
    }
}
