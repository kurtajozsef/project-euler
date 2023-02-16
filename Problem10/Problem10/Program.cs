//https://projecteuler.net/problem=10

using System.Diagnostics;

namespace Problem10
{
	public class Program
	{
		private static readonly List<long> StoredPrimes = new();

		private static void GetAllPrimesSmallerThan(long n)
		{
			if (n <= 1)
			{
				return;
			}

			var wentOverN = false;
			StoredPrimes.Add(2);
			long i = 3;

			while (!wentOverN)
			{
				if (IsPrime(i))
				{
					StoredPrimes.Add(i);
				}

				i += 2;
				wentOverN = i > n;
			}

		}

		public static long GetSumOfAllPrimesSmallerThan(long n)
		{
			GetAllPrimesSmallerThan(n);

			return StoredPrimes.Sum();
		}

		private static bool IsPrime(long number) => StoredPrimes.Where(prime => prime <= Math.Sqrt(number)).All(prime => number % prime != 0);

		public static void Main(string[] args)
		{
			var timer = Stopwatch.StartNew();

			var result = GetSumOfAllPrimesSmallerThan(2_000_000);

			timer.Stop();

			Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
		}
	}
}