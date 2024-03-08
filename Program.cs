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
            string path = ".";
            string logFile = @".\log.txt";

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
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                Console.WriteLine($"{DateTime.Now.ToString()} - TestAzureDevOpsConsoleApp is running..." );
                Console.WriteLine($"{DateTime.Now.ToString()} - " + "JSON = " + m.Name);
                writer.WriteLine( $"{DateTime.Now.ToString()} - TestAzureDevOpsConsoleApp is running..." );
                writer.WriteLine( $"{DateTime.Now.ToString()} - " + "JSON = " + m.Name );
            }

            for (; ; )
            {
                fCount = Directory.GetFiles(path, "*", SearchOption.AllDirectories).Length;

                using (StreamWriter writer = new StreamWriter(logFile, true))
                {
                    Console.WriteLine($"{DateTime.Now.ToString()} - " + "# of files here: " + fCount);
                    writer.WriteLine( $"{DateTime.Now.ToString()} - " + "# of files here: " + fCount );
                }

                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
