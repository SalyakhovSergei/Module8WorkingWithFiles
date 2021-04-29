using System;
using System.IO;

namespace Module8Files
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteFiles("C:/Users/Анатолий/Desktop/testFolder");

            static void DeleteFiles(string folder)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                DirectoryInfo[] directories = dirInfo.GetDirectories();
                FileInfo[] FI = dirInfo.GetFiles();

                if (dirInfo.Exists)
                {
                    foreach (FileInfo file in FI)
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo DI in directories)
                    {
                        DeleteFiles(DI.FullName);
                    }
                }
            }
        }
    }
}
