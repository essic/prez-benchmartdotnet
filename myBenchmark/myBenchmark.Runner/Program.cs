using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace myBenchmark.Runner
{
    public static class FizzBuzzLogic
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        public static string Execute(int number)
        {
            string result;
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = fizz + buzz;
            }
            else if (number % 3 == 0)
            {
                result = fizz;
            }
            else if (number % 5 == 0)
            {
                result = buzz;
            }
            else
            {
                result = $"{number}";
            }
            return result;
        }
    }

    public class FizzBuzzBenchmarkForCSharp
    {
        private CSharp.FizzImplementations csharpImpl = new CSharp.FizzImplementations(FizzBuzzLogic.Execute);
        private CSharp.Range range;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int MaxBoundNumber;

        [GlobalSetup]
        public void Setup()
        {
            range = new CSharp.Range(1, MaxBoundNumber);
        }

        [Benchmark(Description = "C# for loop version with no optimization")]
        public string[] BasicForLoopVersion() => csharpImpl.BasicForLoopVersion(range);

        [Benchmark(Description = "C# for loop version with array pre-initialization")]
        public string[] ForLoopWithAnInitializedArrayVersion() => csharpImpl.ForLoopWithAnInitializedArrayVersion(range);

        [Benchmark(Description = "C# linq version")]
        public string[] LinqVersion() => csharpImpl.LinqVersion(range);

        [Benchmark(Description = "C# parallel linq version")]
        public string[] ParallelLinqVersion() => csharpImpl.ParallelLinqVersion(range);

    }

    public class FizzBuzzBenchmarkCSharpVsFSharp
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<FizzBuzzBenchmarkForCSharp>();
            var fsharpImpl = new FSharp.FizzBuzzImplementations(FizzBuzzLogic.Execute);
            var resuts = fsharpImpl.recursiveStyleTailCallOptimized(FSharp.RangeModule.create(1, 100));
            foreach (var result in resuts)
            {
                Console.WriteLine(result);
            }
            Console.Write("Press any key to exists ...");
            Console.ReadKey();
        }
    }
}
