//https://projecteuler.net/problem=5

using System.Diagnostics;

namespace Problem5
{
    public class Program
    {
        public static long GreatestCommonDivisor(long number1, long number2)
            => number2 == 0 ? number1 : GreatestCommonDivisor(number2, number1 % number2);

        public static long SmallestNumberDivisible(int limit)
        {
            long result = 1;
            for (long i = 1; i <= limit; i++)
            {
                var multiply = i;
                var gcd = GreatestCommonDivisor(result, i);
                if (gcd != 1)
                {
                    multiply /= gcd;
                }
                result *= multiply;
            }

            return result;
        }

        public static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            var result = SmallestNumberDivisible(20);

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
        }
    }
}