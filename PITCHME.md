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
A code section has been identified as problematic in your application, so microbenchmark will help you test your improvement(s)

+++
You suspect that somewhere in the code, some part is significantly more time consuming than other

+++
Performance is an issue (or feature) and you need to make sure of the effect of a specific piece of code / component at runtime

+++
Failure to calculate correct metrics

---

### Benchmarking is hard ... It deals with it !

Many parameters to account for => really easy to make mistakes  ...

+++
failure to isolate properly what needs benchmarking 

+++
failure to make sufficient run so that the benchmark is effecient and pertinent

+++
failure / mistake of not including warm up phase, when necessary,  before measuring performance 

+++
failure to build / run the project with accurate parameters (Platform, Virutal machine selection, Choosing JIT ...)

---

### What does it do ?

- You set up your code in methods with the correct anotation |
- You might configure your project with necessary targets, if you run a multi-target benchmark |
- BenchmarkDotNet create isolate project per anotation |

+++
### What does it do ?
- Does several launches of projects |
- Runs benchmarking operations (including warmup) |
- Creates reporting for you, calculate statistical data |
- Gives you a nice short summary |

---

## Demo

C# vs F#

+++
We implement a simple FizzBuzz 

+++
Then for a Range from 1 to N (included) we apply the FizzBuzz logic, given different implementation in C# and F#.

+++

```
string SomeImplementation(Range range); 
```

+++

```
someImplementation : Range -> String array
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

### Some links about all this ...

- [Proper Benchmarking To Diagnose And Solve A .NET Serialization Bottleneck](http://www.hanselman.com/blog/ProperBenchmarkingToDiagnoseAndSolveANETSerializationBottleneck.aspx)
- [A very good tutorial, I wished I've seen before starting this](https://dotnetcoretutorials.com/2017/12/04/benchmarking-net-core-code-benchmarkdotnet/)
- [MSDN about the GC](https://msdn.microsoft.com/en-us/library/ms973837.aspx)

### Thanks !

Questions ?
