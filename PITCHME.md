#Bencharmking with BenchmarkDotNet !

[@essiccf37](https://twitter.com/essiccf37) <br> July 201i8

---

# What is BenchmarkDotNet ?

- Benchmark library in .NET for Microbenchmark / Component benchmark |
- .NET Framework (4.6+), .NET Core (2.0+), Mono, CoreRT |
- C#, F#, VB |
- Windows, Linux, OSX |

---

# Why do we Microbenchmark ?

+++A code fragment has been identified as problematic in your application, so microbenchmark will help you test your improvement(s)
+++You suspect that somewhere in the code, some part is significantly more time consuming than other
+++Performance is an issue (or feature) and you need to make sure of the effect of a specific piece of code / component at runtime.
+++It does not replace profiling, performance measures on the whole application

---

# Benchmarking is hard ... It deals with it !

Many parameters to account for => really easy to make mistakes  ...

+++failure to isolate properly what needs benchmarking 
+++failure to make sufficient run so that the benchmark is effecient and pertinent
+++failure / mistake of not including warm up phase, when necessary,  before measuring performance 
+++failure to build / run the project with accurate parameters (Platform, Virutal machine selection, Choosing JIT ...)

---

# What does it do ?

