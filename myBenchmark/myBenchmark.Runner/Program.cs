﻿using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace myBenchmark.Runner
{
    public class FizzBuzz
    {
        private CSharp.FizzBuzzLogic csharpImpl = new CSharp.FizzBuzzLogic();
        private CSharp.Range range;

        [Params(10,100,1000,10000)]
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
