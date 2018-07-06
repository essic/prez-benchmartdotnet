## Microbencharmking with BenchmarkDotNet !

[@essiccf37](https://twitter.com/essiccf37) <br> July 2018

---

### What is BenchmarkDotNet ?

- .NET Library for Microbenchmark / Component benchmark |
- .NET Framework (4.6+), .NET Core (2.0+), Mono, CoreRT |
- C#, F#, VB |
- Windows, Linux, OSX |

---

### About microbenchmark ... 

> "core routine consists of a relatively small and specific piece of code." <br> Wikipedia

+++
So it's about measuring time spent on a particuliar piece of code / method / function under given conditions.

---

### Why do we Microbenchmark ?

+++
A code section has been identified as problematic in your application

+++
You suspect that some code is more time consuming than it should 

+++
Performance is an issue or feature so you need to make sure of the effect of a specific piece of code / component at runtime

---

### Benchmarking is hard ... 

+++
Intermediate to expert level on the runtime needed to make sure you measure the right thing.

+++
Failure to isolate properly what needs benchmarking results in useless metrics 

+++
Failure to make sufficient run of what needs benchmarking, makes metrics inacurate

+++
Even if you get all that right, reporting is what comes next !

---

### How does BenchmarkingDotNet helps ?

- Does several launches of projects |
- Runs benchmarking operations (including warmup) |
- Creates reporting for you, calculate statistical data |
- Gives you a nice short summary |

---

### Ok cool but what do I do ?

- You set up your code in methods with the correct anotation |
- You might configure your project with necessary targets, if you run a multi-target benchmark |
- You run the project in RELEASE mode and wait for the results |

---

## Demo

C# vs F#

+++
We implement a simple FizzBuzz 

+++
Then for a Range from 1 to N (included) we apply the FizzBuzz logic, given different implementation in C# and F#.

+++

```csharp
string SomeImplementation(Range range); 
```

+++

```fsharp
val someImplementation : Range -> string[]
```

+++

Coding Time !

---

### In short

- BenchmarkDotNet is a highly configurable library for microbenchmark |
- We do microbenchmark in addition of profiling and other performance related skills |
- You get for free : process isolation, warmup, statistics, reporting ... |
- Already widely used, included but not limited : CoreCLR, Roslyn, EntityFrameworkCore, Orleans, Serilog, Autofac ... |
- There are much more to be said about this library, please check : [https://benchmarkdotnet.org](https://benchmarkdotnet.org) |

---
### Some links about all this ...

- [Proper Benchmarking To Diagnose And Solve A .NET Serialization Bottleneck](http://www.hanselman.com/blog/ProperBenchmarkingToDiagnoseAndSolveANETSerializationBottleneck.aspx)
- [A very good tutorial, I wished I've seen before starting this](https://dotnetcoretutorials.com/2017/12/04/benchmarking-net-core-code-benchmarkdotnet/)
- [MSDN about the GC](https://msdn.microsoft.com/en-us/library/ms973837.aspx)

---
### Thanks !

Questions ?
