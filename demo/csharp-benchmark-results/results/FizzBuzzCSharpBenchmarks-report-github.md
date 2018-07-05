``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.5 (17F77) [Darwin 17.6.0]
Intel Core i7-4770HQ CPU 2.20GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=2.1.301
  [Host]     : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT
  Job-SMESYZ : .NET Core 2.1.1 (CoreCLR 4.6.26606.02, CoreFX 4.6.26606.05), 64bit RyuJIT

IterationTime=200.0000 ms  LaunchCount=1  TargetCount=1  
WarmupCount=5  

```
|                                              Method | MaxBoundNumber |             Mean | Error |     Gen 0 |     Gen 1 |     Gen 2 |  Allocated |
|---------------------------------------------------- |--------------- |-----------------:|------:|----------:|----------:|----------:|-----------:|
|          **&#39;C# for loop version with no optimization&#39;** |             **10** |       **1,058.0 ns** |    **NA** |    **0.1133** |         **-** |         **-** |      **720 B** |
| &#39;C# for loop version with array pre-initialization&#39; |             10 |         826.7 ns |    NA |    0.0574 |         - |         - |      384 B |
|                                   &#39;C# linq version&#39; |             10 |       1,110.0 ns |    NA |    0.0713 |         - |         - |      480 B |
|                          &#39;C# parallel linq version&#39; |             10 |      21,156.6 ns |    NA |    1.6419 |         - |         - |     5711 B |
|          **&#39;C# for loop version with no optimization&#39;** |            **100** |       **9,650.9 ns** |    **NA** |    **0.9506** |         **-** |         **-** |     **5992 B** |
| &#39;C# for loop version with array pre-initialization&#39; |            100 |       8,780.0 ns |    NA |    0.5670 |         - |         - |     3792 B |
|                                   &#39;C# linq version&#39; |            100 |       9,517.4 ns |    NA |    0.6155 |         - |         - |     3888 B |
|                          &#39;C# parallel linq version&#39; |            100 |      30,229.2 ns |    NA |    2.4883 |         - |         - |     7866 B |
|          **&#39;C# for loop version with no optimization&#39;** |           **1000** |      **93,333.5 ns** |    **NA** |    **8.3333** |    **0.9259** |         **-** |    **54480 B** |
| &#39;C# for loop version with array pre-initialization&#39; |           1000 |      89,027.2 ns |    NA |    5.8036 |    0.4464 |         - |    37872 B |
|                                   &#39;C# linq version&#39; |           1000 |      96,196.4 ns |    NA |    5.6818 |    0.4735 |         - |    37968 B |
|                          &#39;C# parallel linq version&#39; |           1000 |      88,193.0 ns |    NA |   11.8838 |    1.7606 |         - |    21741 B |
|          **&#39;C# for loop version with no optimization&#39;** |          **10000** |   **1,688,984.9 ns** |    **NA** |  **117.1875** |   **62.5000** |   **39.0625** |   **679536 B** |
| &#39;C# for loop version with array pre-initialization&#39; |          10000 |     957,952.9 ns |    NA |   62.5000 |   26.7857 |         - |   417072 B |
|                                   &#39;C# linq version&#39; |          10000 |   1,042,967.7 ns |    NA |   62.5000 |   31.2500 |         - |   417168 B |
|                          &#39;C# parallel linq version&#39; |          10000 |     609,047.6 ns |    NA |  122.0238 |   56.5476 |         - |   154089 B |
|          **&#39;C# for loop version with no optimization&#39;** |         **100000** |  **22,745,721.9 ns** |    **NA** | **2250.0000** | **2250.0000** |  **375.0000** |  **6306904 B** |
| &#39;C# for loop version with array pre-initialization&#39; |         100000 |  16,250,596.9 ns |    NA |  562.5000 |  312.5000 |  187.5000 |  4209072 B |
|                                   &#39;C# linq version&#39; |         100000 |  16,722,653.1 ns |    NA |  562.5000 |  312.5000 |  187.5000 |  4209489 B |
|                          &#39;C# parallel linq version&#39; |         100000 |  14,737,762.5 ns |    NA | 1000.0000 |  625.0000 |  437.5000 |  1493230 B |
|          **&#39;C# for loop version with no optimization&#39;** |        **1000000** | **244,838,478.1 ns** |    **NA** | **6562.5000** | **2500.0000** | **1312.5000** | **58907664 B** |
| &#39;C# for loop version with array pre-initialization&#39; |        1000000 | 220,512,834.4 ns |    NA | 6437.5000 | 2125.0000 | 1062.5000 | 42129896 B |
|                                   &#39;C# linq version&#39; |        1000000 | 231,425,090.6 ns |    NA | 6437.5000 | 2125.0000 | 1062.5000 | 42129310 B |
|                          &#39;C# parallel linq version&#39; |        1000000 | 216,920,343.8 ns |    NA | 6562.5000 | 2687.5000 | 1062.5000 | 14734416 B |
