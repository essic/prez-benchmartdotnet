using System;
using System.Linq;
using System.Collections.Generic;

namespace myBenchmark.CSharp
{
    public class Range
    {
        public Range(int start, int end)
        {
            if (start <= 0 || end < 0 && end <= start)
                throw new ArgumentException($"The interval [start,end] given is incorrect : [{start},{end}]");

            Start = start;
            End = end;
        }

        public int Start { get; }
        public int End { get; }

    }

    public class FizzBuzzLogic
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        private string FizzBuzzIt(int number)
        {
            string result;
            if (number % 3 == 0 && number % 5 == 0)
            {
                result = fizz + buzz;
            }
            else if (number % 3 == 0)
            {
                result = fizz;
            }
            else if (number % 5 == 0)
            {
                result = buzz;
            }
            else
            {
                result = $"{number}";
            }
            return result;
        }

        public string[] BasicForLoopVersion(Range range)
        {
            var result = new List<string>();
            for (var number = range.Start; number <= range.End; number++)
            {
                result.Add(FizzBuzzIt(number));
            }
            return result.ToArray();
        }

        public string[] ForLoopWithAnInitializedArrayVersion(Range range)
        {
            var result = new string[range.End];
            for (var number = range.Start; number <= range.End; number++)
            {
                    result[number - 1] = FizzBuzzIt(number);
            }
            return result;
        }

        public string[] LinqVersion(Range range)
        {
            return Enumerable.Range(range.Start, range.End)
                .Select(FizzBuzzIt)
                .ToArray();
        }

        public string[] ParallelLinqVersion(Range range)
        {
            return Enumerable.Range(range.Start, range.End)
                .AsParallel().Select(FizzBuzzIt)
                .ToArray();
        }
    }
}
