using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace deletebinaries
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("input path clear...");
                string path = Console.ReadLine();
                Utility.WalkDirectoryTree(new DirectoryInfo(path));
            }


        }
    }
}
