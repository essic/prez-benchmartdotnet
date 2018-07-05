using System;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Horology;

namespace myBenchmark.Runner
{
    public class BenchmarkConfig : ManualConfig
    { 
        public BenchmarkConfig()
        {
            Add(Job.Default
                        .WithLaunchCount(1)
                        .WithIterationTime(TimeInterval.FromMilliseconds(200))
                        .WithWarmupCount(5)
                        .WithTargetCount(5));
                        //.WithWarmupCount(10)
                        //.WithTargetCount(10));
        }
    }
}
