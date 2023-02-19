//https://projecteuler.net/problem=10

using System.Diagnostics;

namespace Problem10
{
	public class Program
	{
		// Sieve of Eratosthenes algorithm
		private static List<bool> Sieve(int number)
		{
			List<bool> isPrime = Enumerable.Repeat(true, number).ToList();
			isPrime[0] = false;
			isPrime[1] = false;

			for (int i = 2; i * i <= number; i++)
			{
				if (isPrime[i] == false)
				{
					continue;
				}

				for (int j = 2 * i; j < number; j += i)
				{
					isPrime[j] = false;
				}
			}

			return isPrime;
		}

		private static long GetSumOfAllPrimesSmallerThan(int number)
		{
			var sieve = Sieve(number);
			long sum = 0;

			for(int i = 2; i < number; i++)
			{
				if (!sieve[i])
				{
					continue;
				}
				sum += i;
			}

			return sum;
		}

		public static void Main(string[] args)
		{
			var timer = Stopwatch.StartNew();

			var result = GetSumOfAllPrimesSmallerThan(2_000_000);

			timer.Stop();

			Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
		}
	}
}