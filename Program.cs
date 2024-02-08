using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAzureDevOpsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestAzureDevOpsConsoleApp is running...");
            string path = ".";
            int fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
            
            for(; ; )
            {
                fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
                Console.WriteLine("# of files here: " + fCount);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
