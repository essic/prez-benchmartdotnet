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

    public class FizzBuzz
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";

        public string[] NonOptimized(Range range)
        {
            var result = new List<string>();
            for (var number = range.Start; number < range.End; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    result.Add(fizz + buzz);
                }
                else if (number % 3 == 0)
                {
                    result.Add(fizz);          
                }
                else if (number % 5 == 0)
                {
                    result.Add(buzz);
                } else
                {
                    result.Add($"{number}");
                }
            }
            return result.ToArray();
        }
    }
}
