using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace myBenchmark.Runner
{
    public class FizzBuzz
    {
        private CSharp.FizzBuzzLogic csharp = new CSharp.FizzBuzzLogic();
        private CSharp.Range range;

        [Params(10,100,1000,10000)]
        public int N;

        [GlobalSetup]
        public void Setup()
        {
            range = new CSharp.Range(1, N);
        }

        [Benchmark]
        public string[] NonOptimizedCSharpVersion() => csharp.NonOptimized(range);

        [Benchmark]
        public string[] Optimize1CSharpVersion() => csharp.Optimize1(range);

        [Benchmark]
        public string[] LinqVersion() => csharp.LinqVersion(range);

    }

    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<FizzBuzz>();
            Console.Write("Press any key to exists ...");
            Console.ReadKey();
        }
    }
}
