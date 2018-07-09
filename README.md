## A short presentation and demo on BenchmarkDotNet.

This project targets .NET 4.7.2 and .Net Core 2.1.
We use the version 0.10.14 of BenchmarkDotNet here.

To run benchmarks launch from the 'myBenchmark' folder :
dotnet run -c release --framework netcoreApp2.1 -p ./myBenchmark/myBenchmark.Runner/myBenchmark.Runner.csproj

Launchers exists in the project, works on unix system though. (You might need to chmod)

You can also target 4.7 by specifying the '-- framework' argument

List of benchmarks presents 
- C# implementations of FizzBuzz on specified target during launch
- F# implementations of FizzBuzz on specified target during launch
- C# vs F# implementations, of your choosing on .Net Core, .Net and Mono. If run on Windows (BenchmarkDotNet constraints)

## We benchmark for 10, 100, 1000, 10000, 100000 and 1000000 iterations.

Please note that benchmark target must be installed as a prerequisite. <br>
However if not presents, it will keep going.

You can find some test in the repo and benchmarks results in the 'demo' folder.

You can view the presentation which goes along the demo, [here](https://gitpitch.com/essic/prez-benchmarkdotnet/master?grs=github&t=black)

Feel free to fork or drop an issue if needed.

## Also note that the recursive implementation in F# with no tail call optimisation will cause an error during benchmark, on purpose !

