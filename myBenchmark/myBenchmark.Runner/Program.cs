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

            ////var summary = BenchmarkRunner.Run<FizzBuzzBenchmarkForCSharp>();
            //var fsharpImpl = new FSharp.FizzBuzzImplementations(FizzBuzzLogic.Execute);
            //var resuts = fsharpImpl.mappingStyle(FSharp.RangeModule.create(1, 100));
            //foreach (var result in resuts)
            //{
            //    Console.WriteLine(result);
            //}
            Console.Write("Press any key to exists ...");
            Console.ReadKey();
        }
    }
}
