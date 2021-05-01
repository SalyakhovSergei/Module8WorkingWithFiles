using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Files
{
    public class FileDelete
    {
        public void DeleteFiles(string folder)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(folder);
            DirectoryInfo[] directories = dirInfo.GetDirectories();
            FileInfo[] FI = dirInfo.GetFiles();

            if (dirInfo.Exists)
            {
                try
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
                catch(IOException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }
    }
}
