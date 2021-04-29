using System;
using System.IO;

namespace Module8Files
{
    class Program
    {
        static void Main(string[] args)
        {
            DeleteFiles("C:/Users/admin/Desktop/1212");

            static void DeleteFiles(string folder)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folder);
                DirectoryInfo[] directories = dirInfo.GetDirectories();
                FileInfo[] FI = dirInfo.GetFiles();

                if (dirInfo.Exists)
                {
                    foreach (FileInfo file in FI)
                    {
                        TimeSpan fileTime = DateTime.Now - file.CreationTime;
                        if (fileTime.Minutes > 30)
                        {
                            file.Delete();
                        }
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
