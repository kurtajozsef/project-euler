//https://projecteuler.net/problem=7

using System.Diagnostics;

namespace Problem7
{
    public class Program
    {
        private static readonly List<long> StoredPrimes = new();

        public static long GetNthPrime(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            var foundPrime = false;
            var i = 2;
            while (!foundPrime)
            {
                if (IsPrime(i))
                {
                    StoredPrimes.Add(i);
                    foundPrime = StoredPrimes.Count == n;
                }

                i++;
            }

            return StoredPrimes[n - 1];
        }

        private static bool IsPrime(long number) => StoredPrimes.All(prime => number % prime != 0);

        public static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            var result = GetNthPrime(10_001);

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
        }
    }
}