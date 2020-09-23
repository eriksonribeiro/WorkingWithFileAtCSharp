using System;

namespace WorkingWithFile
{
    public class Files
    {
        public string sourcePath { get; set; }
        public string targetPath { get; set; }

        public Files(string sourcePath)
        {
            this.sourcePath = sourcePath;
        }

        public Files(string sourcePath, string targetPath)
        {
            this.sourcePath = sourcePath;
            this.targetPath = targetPath;
        }
    }
}
