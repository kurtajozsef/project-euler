// https://projecteuler.net/problem=1

using System.Diagnostics;

namespace Problem1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();

            var result = 0;

            for (var i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
        }
    }
}