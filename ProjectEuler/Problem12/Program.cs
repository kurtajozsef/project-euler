//https://projecteuler.net/problem=12

using System.Diagnostics;

namespace Problem12
{
	public class Program
	{
		private static int GetNumberOfDivisorsOfNumber(long number)
		{
			var numberOfDivisors = 0;

			for (int i = 1; i <= Math.Sqrt(number); i++)
			{
				if (number % i != 0)
				{
					continue;
				}

				if (number / i == i)
				{
					numberOfDivisors++;
					continue;
				}

				numberOfDivisors += 2;
			}

			return numberOfDivisors;
		}

		private static long GetTriangleSum(long number) => number * (number + 1) / 2;

		private static long GetLowestTriangleNumberWithOverNDivisors(int numberOfDivisors)
		{
			long result = 0;
			bool found = false;
			int i = 1;

			while (!found)
			{
				long triangleSum = GetTriangleSum(i);
				if (GetNumberOfDivisorsOfNumber(triangleSum) < numberOfDivisors)
				{
					i++;
					continue;
				}
				result = triangleSum;
				found = true;
			}

			return result;
		}

		public static void Main(string[] args)
		{
			var timer = Stopwatch.StartNew();

			var result = GetLowestTriangleNumberWithOverNDivisors(500);

			timer.Stop();

			Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
		}
	}
}