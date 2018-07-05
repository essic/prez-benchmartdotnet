using System;
using myBenchmark.CSharp;
using myBenchmark.FSharp;

namespace myBenchmark.Runner
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Say.hello();

            var fizzer = new FizzBuzz().NonOptimized(new Range(1, 100));
            foreach(var f in fizzer )
            {
                Console.WriteLine(f);
            }
            Console.Write("Press any key to exists ...");
            Console.ReadKey();
        }
    }
}
