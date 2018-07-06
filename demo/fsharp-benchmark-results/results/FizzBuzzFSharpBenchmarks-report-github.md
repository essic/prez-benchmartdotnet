``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.5 (17F77) [Darwin 17.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT
  Job-OHFSNL : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT

IterationTime=200.0000 ms  LaunchCount=1  TargetCount=1  
WarmupCount=5  

```
|                                                     Method | MaxBoundNumber |             Mean | Error | Scaled | ScaledSD | Rank |      Gen 0 |     Gen 1 |     Gen 2 |   Allocated |
|----------------------------------------------------------- |--------------- |-----------------:|------:|-------:|---------:|-----:|-----------:|----------:|----------:|------------:|
|        **&#39;F# for loop version with mutable variable, no opt&#39;** |             **10** |         **981.2 ns** |    **NA** |   **1.00** |     **0.00** |    **2** |     **0.1087** |         **-** |         **-** |       **704 B** |
| &#39;F# for loop version with mutable variable and array init&#39; |             10 |         889.3 ns |    NA |   0.91 |     0.00 |    1 |     0.0606 |         - |         - |       384 B |
|             &#39;F# with recursion, no tail call optimization&#39; |             10 |       1,014.0 ns |    NA |   1.03 |     0.00 |    3 |     0.1076 |         - |         - |       704 B |
|                &#39;F# with recursion, tail call optimization&#39; |             10 |       1,128.6 ns |    NA |   1.15 |     0.00 |    4 |     0.1729 |         - |         - |      1088 B |
|                                        &#39;F# with Array.map&#39; |             10 |       1,132.3 ns |    NA |   1.15 |     0.00 |    4 |     0.1139 |         - |         - |       752 B |
|                               &#39;F# with Array.Parallel.map&#39; |             10 |       8,209.9 ns |    NA |   8.37 |     0.00 |    5 |     0.4861 |         - |         - |      3018 B |
|                                                            |                |                  |       |        |          |      |            |           |           |             |
|        **&#39;F# for loop version with mutable variable, no opt&#39;** |            **100** |      **10,184.2 ns** |    **NA** |   **1.00** |     **0.00** |    **3** |     **1.0610** |         **-** |         **-** |      **6992 B** |
| &#39;F# for loop version with mutable variable and array init&#39; |            100 |       9,271.3 ns |    NA |   0.91 |     0.00 |    1 |     0.5996 |         - |         - |      3792 B |
|             &#39;F# with recursion, no tail call optimization&#39; |            100 |      10,956.2 ns |    NA |   1.08 |     0.00 |    4 |     1.0804 |         - |         - |      6992 B |
|                &#39;F# with recursion, tail call optimization&#39; |            100 |      11,569.5 ns |    NA |   1.14 |     0.00 |    5 |     1.7329 |         - |         - |     10976 B |
|                                        &#39;F# with Array.map&#39; |            100 |       9,975.3 ns |    NA |   0.98 |     0.00 |    2 |     0.8514 |         - |         - |      5488 B |
|                               &#39;F# with Array.Parallel.map&#39; |            100 |      18,905.6 ns |    NA |   1.86 |     0.00 |    6 |     1.3158 |         - |         - |      6245 B |
|                                                            |                |                  |       |        |          |      |            |           |           |             |
|        **&#39;F# for loop version with mutable variable, no opt&#39;** |           **1000** |     **107,976.0 ns** |    **NA** |   **1.00** |     **0.00** |    **4** |    **11.0619** |    **1.1062** |         **-** |     **69872 B** |
| &#39;F# for loop version with mutable variable and array init&#39; |           1000 |      94,219.7 ns |    NA |   0.87 |     0.00 |    2 |     5.6818 |    0.4735 |         - |     37872 B |
|             &#39;F# with recursion, no tail call optimization&#39; |           1000 |     119,645.8 ns |    NA |   1.11 |     0.00 |    5 |    10.7143 |    1.1905 |         - |     69872 B |
|                &#39;F# with recursion, tail call optimization&#39; |           1000 |     122,806.2 ns |    NA |   1.14 |     0.00 |    6 |    17.4279 |    2.4038 |         - |    109856 B |
|                                        &#39;F# with Array.map&#39; |           1000 |     100,414.2 ns |    NA |   0.93 |     0.00 |    3 |     7.9365 |    0.4960 |         - |     50408 B |
|                               &#39;F# with Array.Parallel.map&#39; |           1000 |      71,832.8 ns |    NA |   0.67 |     0.00 |    1 |     8.6326 |    1.0359 |         - |     28316 B |
|                                                            |                |                  |       |        |          |      |            |           |           |             |
|        **&#39;F# for loop version with mutable variable, no opt&#39;** |          **10000** |   **1,209,425.0 ns** |    **NA** |   **1.00** |     **0.00** |    **4** |   **113.6364** |   **51.1364** |         **-** |    **737072 B** |
| &#39;F# for loop version with mutable variable and array init&#39; |          10000 |   1,013,849.0 ns |    NA |   0.84 |     0.00 |    2 |    62.5000 |   28.8462 |         - |    417072 B |
|             &#39;F# with recursion, no tail call optimization&#39; |          10000 |   1,667,718.8 ns |    NA |   1.38 |     0.00 |    6 |   109.3750 |   46.8750 |         - |    737072 B |
|                &#39;F# with recursion, tail call optimization&#39; |          10000 |   1,498,800.3 ns |    NA |   1.24 |     0.00 |    5 |   180.5556 |   90.2778 |         - |   1137056 B |
|                                        &#39;F# with Array.map&#39; |          10000 |   1,082,275.3 ns |    NA |   0.89 |     0.00 |    3 |    88.5417 |   36.4583 |         - |    588584 B |
|                               &#39;F# with Array.Parallel.map&#39; |          10000 |     628,765.6 ns |    NA |   0.52 |     0.00 |    1 |    93.7500 |   46.8750 |         - |    298691 B |
|                                                            |                |                  |       |        |          |      |            |           |           |             |
|        **&#39;F# for loop version with mutable variable, no opt&#39;** |         **100000** |  **25,903,531.3 ns** |    **NA** |   **1.00** |     **0.00** |    **4** |  **1125.0000** |  **500.0000** |  **250.0000** |   **7409278 B** |
| &#39;F# for loop version with mutable variable and array init&#39; |         100000 |  16,667,906.3 ns |    NA |   0.64 |     0.00 |    2 |   562.5000 |  312.5000 |  187.5000 |   4209073 B |
|             &#39;F# with recursion, no tail call optimization&#39; |         100000 |  73,975,153.1 ns |    NA |   2.86 |     0.00 |    6 |  1187.5000 |  562.5000 |  250.0000 |   7409073 B |
|                &#39;F# with recursion, tail call optimization&#39; |         100000 |  30,427,109.4 ns |    NA |   1.17 |     0.00 |    5 |  1750.0000 |  812.5000 |  312.5000 |  11409356 B |
|                                        &#39;F# with Array.map&#39; |         100000 |  17,651,646.9 ns |    NA |   0.68 |     0.00 |    3 |   937.5000 |  687.5000 |  500.0000 |   5658394 B |
|                               &#39;F# with Array.Parallel.map&#39; |         100000 |  12,639,888.9 ns |    NA |   0.49 |     0.00 |    1 |  1000.0000 |  687.5000 |  562.5000 |   2617796 B |
|                                                            |                |                  |       |        |          |      |            |           |           |             |
|        **&#39;F# for loop version with mutable variable, no opt&#39;** |        **1000000** | **380,819,525.0 ns** |    **NA** |   **1.00** |     **0.00** |    **4** | **11687.5000** | **4750.0000** | **1187.5000** |  **74129111 B** |
| &#39;F# for loop version with mutable variable and array init&#39; |        1000000 | 236,774,834.4 ns |    NA |   0.62 |     0.00 |    2 |  6375.0000 | 2125.0000 | 1000.0000 |  42129663 B |
|             &#39;F# with recursion, no tail call optimization&#39; |        1000000 |               NA |    NA |      ? |        ? |    ? |        N/A |       N/A |       N/A |         N/A |
|                &#39;F# with recursion, tail call optimization&#39; |        1000000 | 533,768,271.9 ns |    NA |   1.40 |     0.00 |    5 | 19062.5000 | 8500.0000 | 2187.5000 | 114129914 B |
|                                        &#39;F# with Array.map&#39; |        1000000 | 239,630,146.9 ns |    NA |   0.63 |     0.00 |    3 |  6500.0000 | 2187.5000 | 1062.5000 |  54518890 B |
|                               &#39;F# with Array.Parallel.map&#39; |        1000000 | 169,245,659.4 ns |    NA |   0.44 |     0.00 |    1 |  6062.5000 | 2000.0000 |  937.5000 |  22511936 B |

Benchmarks with issues:
  FizzBuzzFSharpBenchmarks.'F# with recursion, no tail call optimization': Job-OHFSNL(IterationTime=200.0000 ms, LaunchCount=1, TargetCount=1, WarmupCount=5) [MaxBoundNumber=1000000]
