//https://projecteuler.net/problem=3

using System.Diagnostics;

namespace Problem3
{
    public class Program
    {
        public static IEnumerable<long> PrimeFactors(long number)
        {
            if (number == 0)
            {
                return new List<long>();
            }

            List<long> result = new();
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (!IsPrime(i) || number % i != 0)
                {
                    continue;
                }
                result.Add(i);
            }

            return result;
        }

        public static bool IsPrime(long number)
        {
            if (number < 2)
            {
                return false;
            }

            var isPrime = true;
            for (var i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i != 0)
                {
                    continue;
                }

                isPrime = false;
                break;
            }

            return isPrime;
        }

        public static void Main(string[] args)
        {
            Stopwatch timer = Stopwatch.StartNew();

            long result = PrimeFactors(600851475143).Max();

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
        }
    }
}