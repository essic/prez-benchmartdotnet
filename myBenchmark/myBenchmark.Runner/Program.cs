using System;
using myBenchmark.CSharp;
using myBenchmark.FSharp;

namespace myBenchmark.Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            Say.hello();
            new Class1().Say();
        }
    }
}
