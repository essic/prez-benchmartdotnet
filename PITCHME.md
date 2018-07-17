## Bencharmking with BenchmarkDotNet !

[@essiccf37](https://twitter.com/essiccf37) <br> July 2018

---

### What's BenchmarkDotNet ?

- .NET Library for Microbenchmark / Component benchmark |
- SDK available on C#, F#, VB |
- Runs with .NET Framework (4.6+), .NET Core (2.0+), Mono, CoreRT |
- Runs on Windows, Linux, OSX |

---

> Microbenchmarking is about measuring the performance of something "small" 

> It's about solving bottlenecks. There's a relation with Optimization but the purpose is different

---

### When is it needed ? 

+++
A code section has been identified as problematic in your application

+++
You suspect that some code is more time / memory consuming than it should 

+++
Performance is a feature so you need to make sure of the comportement of a specific piece of code under load

---

### Benchmarking is hard 

+++
Stopwatch is far from being sufficient to get correct metrics 

+++
Intermediate to expert level on the runtime is needed to make sure you measure the right thing. 

+++
Failure to isolate properly what needs benchmarking, gives useless metrics

+++
Failure to make sufficient run of what needs benchmarking, makes metrics inacurate

+++
Even if you get all that right, reporting things correctly, is what comes next !

---

### BenchmarkingDotNet helps 

- Gives you a extensive SDK to create and customize your benchmark |
- Runs benchmarking operations (including warmup) |
- Calculates statistical data, creates reporting for you |
- Gives you a nice short summary |

---

### Ok cool but what do I do ?

- You set up your code in methods with the needed annotation on the methods and class |
- You might configure your project (csproj / fsproj / vbproj) with necessary targets, especially if you run a multi-target benchmark |
- You run the project in RELEASE mode and wait for the results |

---

## Demo

### `C#` vs `F#` <br /> Siblings rivalery unleashed

+++
We implement a simple FizzBuzz 

+++
Then for a Range from 1 to N (included) we apply the FizzBuzz logic, given different implementation in C# and F#.

+++
C# signature of benchmark target

```csharp
string[] SomeImplementation(Range range); 
```

+++
F# signature of benchmark target
```fsharp
val someImplementation : Range -> string[]
```
+++

# Coding Time !
#### CLick [here](https://github.com/essic/prez-benchmarkdotnet/tree/master/demo) to access the benchmark results on GitHub 
#### Click [here](https://github.com/essic/prez-benchmarkdotnet/tree/master/myBenchmark) to view the code on GitHub
---

### In short

- BenchmarkDotNet is a highly configurable library for microbenchmark |
- We do microbenchmark in addition of profiling and other performance related skills |
- Already widely used, included but not limited : CoreCLR, Roslyn, EntityFrameworkCore, Orleans, Serilog, Autofac ... |

---
### Some links about all this ...

- [Proper Benchmarking To Diagnose And Solve A .NET Serialization Bottleneck](http://www.hanselman.com/blog/ProperBenchmarkingToDiagnoseAndSolveANETSerializationBottleneck.aspx)
- [A very good tutorial, I wished I've seen before starting this](https://dotnetcoretutorials.com/2017/12/04/benchmarking-net-core-code-benchmarkdotnet/)
- [MSDN about the GC](https://msdn.microsoft.com/en-us/library/ms973837.aspx)

---

### Thanks !

There are much more to be said about this library, please check [https://benchmarkdotnet.org](https://benchmarkdotnet.org) <br> Questions ?
