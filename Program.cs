using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestAzureDevOpsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestAzureDevOpsConsoleApp is running...");
            string path = ".";
            int fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;

            string movieJSON = @"{
                              'Name': 'Bad Boys',
                              'Genres': [
                                'Action',
                                'Comedy'
                              ]
                            }";

            Movie m = JsonConvert.DeserializeObject<Movie>(movieJSON);

            string name = m.Name;

            Console.WriteLine("JSON = " + m.Name);


            for (; ; )
            {
                fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;
                Console.WriteLine("# of files here: " + fCount);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
