using System;
using System.Linq;
using System.Collections.Generic;

namespace myBenchmark.CSharp
{
    public class Range
    {
        public Range(int start, int end)
        {
            if ( (start <= 0 || end < 0) && end <= start)
                throw new ArgumentException($"The interval [start,end] given is incorrect : [{start},{end}]");

            Start = start;
            End = end;
        }

        public int Start { get; }
        public int End { get; }
    }

    public class FizzImplementations
    {
        private readonly Func<int, string> fizzBuzzLogic;

        public FizzImplementations(Func<int,string> fizzBuzzLogic)
        {
            this.fizzBuzzLogic = fizzBuzzLogic ?? throw new ArgumentNullException(nameof(fizzBuzzLogic));
        }

        public string[] BasicForLoopVersion(Range range)
        {
            var result = new List<string>();
            for (var number = range.Start; number <= range.End; number++)
            {
                result.Add(fizzBuzzLogic(number));
            }
            return result.ToArray();
        }

        public string[] ForLoopWithAnInitializedArrayVersion(Range range)
        {
            var result = new string[range.End];
            for (var number = range.Start; number <= range.End; number++)
            {
                    result[number - 1] = fizzBuzzLogic(number);
            }
            return result;
        }

        public string[] LinqVersion(Range range)
        {
            return Enumerable.Range(range.Start, range.End)
                .Select(fizzBuzzLogic)
                .ToArray();
        }

        public string[] ParallelLinqVersion(Range range)
        {
            return Enumerable.Range(range.Start, range.End)
                .AsParallel().Select(fizzBuzzLogic)
                .ToArray();
        }
    }
}
