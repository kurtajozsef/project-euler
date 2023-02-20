//https://projecteuler.net/problem=14

using System.Collections;
using System.Diagnostics;

namespace Problem14
{
	public class Program
	{
		private static Dictionary<long,int> ComputedSequences = new();

		private static long Collatz(long number) => number % 2 == 0 ? number / 2 : 3 * number + 1;

		private static int GetCollatzSequenceLength(int startingNumber)
		{
			int length = 1;
			long collatzStep = startingNumber;
			do
			{
				collatzStep = Collatz(collatzStep);

				if (ComputedSequences.ContainsKey(collatzStep))
				{
					length += ComputedSequences[collatzStep];
					break;
				}

				length++;
			} while (collatzStep != 1);

			ComputedSequences[startingNumber] = length;

			return length;
		}

		private static int GetLongestCollatzNumberUnderN(int n)
		{
			int result = 0;
			int maxLength = 0;

			for (int i = 2; i < n; i++)
			{
				int collatzLength = GetCollatzSequenceLength(i);
				if (maxLength >= collatzLength)
				{
					continue;
				}

				maxLength = collatzLength;
				result = i;
			}

			return result;
		}

		public static void Main(string[] args)
		{
			var timer = Stopwatch.StartNew();

			var result = GetLongestCollatzNumberUnderN(1_000_000);

			timer.Stop();

			Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds}ms");
		}
	}
}