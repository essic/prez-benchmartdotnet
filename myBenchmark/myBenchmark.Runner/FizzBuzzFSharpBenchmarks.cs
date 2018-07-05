using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace myBenchmark.Runner
{
    [Config(typeof(BenchmarkConfig))]
    public class FizzBuzzFSharpBenchmarks
    {
        private FSharp.FizzBuzzImplementations fsharpImpl = new FSharp.FizzBuzzImplementations(FizzBuzzLogic.Execute);
        private FSharp.Range range;

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int MaxBoundNumber;

        [GlobalSetup]
        public void Setup()
        {
            range = FSharp.RangeModule.create(1, MaxBoundNumber);
        }

        [Benchmark(Description = "F# for loop version with mutable variable, no opt")]
        public string[] ImperativeStyleVersion() => fsharpImpl.imperativeForLoopVersion(range);

        [Benchmark(Description = "F# for loop version with mutable variable and array init")]
        public string[] ImperativeStyleOptimizeVersion() => fsharpImpl.imperativeForLoopVersionWithArrayInitialization(range);

        [Benchmark(Description = "F# with recursion, no tail call optimization")]
        public string[] RecursionStyleNoTailCallOpt() => fsharpImpl.recursiveStyle(range);

        [Benchmark(Description = "F# with recursion, tail call optimization")]
        public string[] ResursionStyleTailCallOpt() => fsharpImpl.recursiveStyleTailCallOptimized(range);

        [Benchmark(Description = "F# with Array.map")]
        public string[] MapStyle() => fsharpImpl.mappingStyle(range);

        [Benchmark(Description = "F# with Array.Parallel.map")]
        public string[] MapParallelStyle() => fsharpImpl.parallelMappingStyle(range);

    }
}
