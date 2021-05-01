using System;
using System.IO;

namespace Module8Files
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDelete test = new FileDelete();

            test.DeleteFiles("C:/Users/admin/Desktop/1212");
        }
    }
}
