using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;

namespace myBenchmark.Runner
{
    [CoreJob(isBaseline:true),MonoJob,ClrJob]
    [RyuJitX64Job]
    [Config(typeof(BenchmarkConfig))]
    public abstract class CSsharpVsFSharpBenchmarks
    {
        protected CSharp.Range cRange;
        protected FSharp.Range fRange;
        protected readonly CSharp.FizzImplementations csharpImpl = new CSharp.FizzImplementations(FizzBuzzLogic.Execute);
        protected readonly FSharp.FizzBuzzImplementations fsharpImpl = new FSharp.FizzBuzzImplementations(FizzBuzzLogic.Execute);

        [Params(10, 100, 1000, 10000, 100000, 1000000)]
        public int MaxBoundNumber;
        
        [GlobalSetup]
        public void Setup()
        {
            cRange = new CSharp.Range(1, MaxBoundNumber);
            fRange = FSharp.RangeModule.create(1, MaxBoundNumber);
        }
    }

    public class CSharpVsFSharpForLoopNoOptBenchmarks : CSsharpVsFSharpBenchmarks
    {
        [Benchmark(Baseline = true)]
        public string[] CSharpBasicForLoopNoOpt() => csharpImpl.BasicForLoopVersion(cRange);

        [Benchmark]
        public string[] FSharpImperativeForLoopNoOpt() => fsharpImpl.imperativeForLoopVersion(fRange);
    }

    public class CSharpVsFSharpForLoopOptBenchmarks : CSsharpVsFSharpBenchmarks
    {
        [Benchmark(Baseline = true)]
        public string[] CSharpBasicForLoopWithOpt() => csharpImpl.ForLoopWithAnInitializedArrayVersion(cRange);

        [Benchmark]
        public string[] FSharpImperativeForLoopWithOpt() => fsharpImpl.imperativeForLoopVersionWithArrayInitialization(fRange);



    }

    public class CSharpVsFSharpNaturalBenchmarks : CSsharpVsFSharpBenchmarks
    {
        [Benchmark(Baseline = true)]
        public string[] CSharpLinqVersion() => csharpImpl.LinqVersion(cRange);

        [Benchmark]
        public string[] FSharpMapVersion() => fsharpImpl.mappingStyle(fRange);

        [Benchmark]
        public string[] FSharpRecursion() => fsharpImpl.recursiveStyle(fRange);

        [Benchmark]
        public string[] FSharpRecursionTailCallOpt() => fsharpImpl.recursiveStyleTailCallOptimized(fRange);
    }

    public class CSharpVsFSharpParallelBenchmarks : CSsharpVsFSharpBenchmarks
    {
        [Benchmark(Baseline = true)]
        public string[] CSharpParallelLinq() => csharpImpl.ParallelLinqVersion(cRange);

        [Benchmark]
        public string[] FSharpParallelMap() => fsharpImpl.parallelMappingStyle(fRange);
    }
}
