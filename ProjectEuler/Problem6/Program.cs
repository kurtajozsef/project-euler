//https://projecteuler.net/problem=6

using System.Diagnostics;

namespace Problem6
{
    public class Program
    {
        public static long SumOfSquares(long limit) => limit * (limit + 1) * (2 * limit + 1) / 6;

        public static long SquareOfSum(long limit) => (long)Math.Pow(limit * (limit + 1) / 2, 2);

        public static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            var result = Math.Abs(SumOfSquares(100) - SquareOfSum(100));

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
        }
    }
}