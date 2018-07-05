using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Horology;
using BenchmarkDotNet.Diagnosers;

namespace myBenchmark.Runner
{
    public class BenchmarkConfig : ManualConfig
    { 
        public BenchmarkConfig()
        {
            Add(MemoryDiagnoser.Default);
            Add(Job.Default
                        .WithLaunchCount(1)
                        .WithIterationTime(TimeInterval.FromMilliseconds(200))
                        .WithWarmupCount(5)
                        .WithTargetCount(1));
                        //.WithWarmupCount(10)
                        //.WithTargetCount(10));
        }
    }
}
