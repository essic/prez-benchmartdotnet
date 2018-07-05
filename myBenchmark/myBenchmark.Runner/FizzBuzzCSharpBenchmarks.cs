using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace myBenchmark.Runner
{
    [Config(typeof(BenchmarkConfig))]
    public class FizzBuzzCSharpBenchmarks
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

}
