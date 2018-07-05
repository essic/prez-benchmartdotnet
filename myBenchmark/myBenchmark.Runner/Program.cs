using System;
using BenchmarkDotNet.Running;

namespace myBenchmark.Runner
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var switcher = new BenchmarkSwitcher(new[] {
                typeof(FizzBuzzCSharpBenchmarks),
                typeof(FizzBuzzFSharpBenchmarks)
            });
            switcher.Run(args);

            Console.Write("Press any key to exists ...");
            Console.ReadKey();
        }
    }
}
