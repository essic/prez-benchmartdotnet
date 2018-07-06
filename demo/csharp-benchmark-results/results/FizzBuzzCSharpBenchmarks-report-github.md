``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.5 (17F77) [Darwin 17.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT
  Job-SRURJG : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT

IterationTime=200.0000 ms  LaunchCount=1  TargetCount=1  
WarmupCount=5  

```
|                                              Method | MaxBoundNumber |           Mean | Error | Scaled | Rank |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
|---------------------------------------------------- |--------------- |---------------:|------:|-------:|-----:|----------:|----------:|----------:|-----------:|
|          **&#39;C# for loop version with no optimization&#39;** |             **10** |       **1.466 us** |    **NA** |   **1.00** |    **3** |    **0.1103** |         **-** |         **-** |      **720 B** |
| &#39;C# for loop version with array pre-initialization&#39; |             10 |       1.099 us |    NA |   0.75 |    1 |    0.0572 |         - |         - |      384 B |
|                                   &#39;C# linq version&#39; |             10 |       1.299 us |    NA |   0.89 |    2 |    0.0758 |         - |         - |      480 B |
|                          &#39;C# parallel linq version&#39; |             10 |      36.722 us |    NA |  25.04 |    4 |    1.5783 |         - |         - |     5874 B |
|                                                     |                |                |       |        |      |           |           |           |            |
|          **&#39;C# for loop version with no optimization&#39;** |            **100** |      **11.968 us** |    **NA** |   **1.00** |    **3** |    **0.9139** |         **-** |         **-** |     **5992 B** |
| &#39;C# for loop version with array pre-initialization&#39; |            100 |      11.475 us |    NA |   0.96 |    2 |    0.5603 |         - |         - |     3792 B |
|                                   &#39;C# linq version&#39; |            100 |       9.756 us |    NA |   0.82 |    1 |    0.6100 |         - |         - |     3888 B |
|                          &#39;C# parallel linq version&#39; |            100 |      28.683 us |    NA |   2.40 |    4 |    2.5056 |         - |         - |     7820 B |
|                                                     |                |                |       |        |      |           |           |           |            |
|          **&#39;C# for loop version with no optimization&#39;** |           **1000** |      **93.448 us** |    **NA** |   **1.00** |    **1** |    **8.4586** |    **0.9398** |         **-** |    **54480 B** |
| &#39;C# for loop version with array pre-initialization&#39; |           1000 |     101.876 us |    NA |   1.09 |    3 |    5.6424 |    0.4340 |         - |    37872 B |
|                                   &#39;C# linq version&#39; |           1000 |      95.054 us |    NA |   1.02 |    2 |    5.7692 |    0.4808 |         - |    37968 B |
|                          &#39;C# parallel linq version&#39; |           1000 |      93.497 us |    NA |   1.00 |    1 |   12.1528 |    1.7361 |         - |    22040 B |
|                                                     |                |                |       |        |      |           |           |           |            |
|          **&#39;C# for loop version with no optimization&#39;** |          **10000** |   **1,725.477 us** |    **NA** |   **1.00** |    **4** |  **117.1875** |   **62.5000** |   **39.0625** |   **679536 B** |
| &#39;C# for loop version with array pre-initialization&#39; |          10000 |     956.156 us |    NA |   0.55 |    2 |   62.5000 |   28.8462 |         - |   417072 B |
|                                   &#39;C# linq version&#39; |          10000 |   1,027.373 us |    NA |   0.60 |    3 |   62.5000 |   28.8462 |         - |   417168 B |
|                          &#39;C# parallel linq version&#39; |          10000 |     622.452 us |    NA |   0.36 |    1 |  122.0238 |   59.5238 |         - |   157267 B |
|                                                     |                |                |       |        |      |           |           |           |            |
|          **&#39;C# for loop version with no optimization&#39;** |         **100000** |  **17,426.597 us** |    **NA** |   **1.00** |    **4** | **1062.5000** |  **875.0000** |  **687.5000** |  **6307108 B** |
| &#39;C# for loop version with array pre-initialization&#39; |         100000 |  16,336.269 us |    NA |   0.94 |    2 |  562.5000 |  312.5000 |  187.5000 |  4209322 B |
|                                   &#39;C# linq version&#39; |         100000 |  16,821.325 us |    NA |   0.97 |    3 |  562.5000 |  312.5000 |  187.5000 |  4209169 B |
|                          &#39;C# parallel linq version&#39; |         100000 |  14,183.834 us |    NA |   0.81 |    1 | 1125.0000 |  625.0000 |  500.0000 |  1477394 B |
|                                                     |                |                |       |        |      |           |           |           |            |
|          **&#39;C# for loop version with no optimization&#39;** |        **1000000** | **247,538.334 us** |    **NA** |   **1.00** |    **4** | **6375.0000** | **2500.0000** | **1187.5000** | **58907792 B** |
| &#39;C# for loop version with array pre-initialization&#39; |        1000000 | 232,897.756 us |    NA |   0.94 |    2 | 6375.0000 | 2125.0000 | 1000.0000 | 42129472 B |
|                                   &#39;C# linq version&#39; |        1000000 | 236,683.906 us |    NA |   0.96 |    3 | 6375.0000 | 2125.0000 | 1000.0000 | 42129594 B |
|                          &#39;C# parallel linq version&#39; |        1000000 | 217,678.291 us |    NA |   0.88 |    1 | 6250.0000 | 2562.5000 |  875.0000 | 14463091 B |
