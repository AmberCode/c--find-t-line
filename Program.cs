using System;
using System.Diagnostics;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            var fs = new FileStream("C:\\temp\\32_20171205001\\32_20171205001.TSYSO", FileMode.Open);

            using(var r = new StreamReader(fs))
            {
                var line = " ";
                var i = 0;

                while((line = r.ReadLine()) != null)
                {
                    i++;
                    Console.WriteLine(i);

                    if (line.StartsWith("T"))
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(line); 
                    }
                }
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.Elapsed);            
        }
    }
}
