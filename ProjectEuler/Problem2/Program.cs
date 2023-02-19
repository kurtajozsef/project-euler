//https://projecteuler.net/problem=2

using System.Diagnostics;

namespace Problem2
{
	public static class Program
	{
		private static readonly List<long> _calculatedFibonacciNumbers = new();

        public static long Fibonacci(int number)
        {
            if (_calculatedFibonacciNumbers.Count > number)
            {
                return _calculatedFibonacciNumbers[number];
            }

            if (number == 0)
            {
                _calculatedFibonacciNumbers.Add(0);
                return 0;
            }
            if (number == 1)
            {
                _calculatedFibonacciNumbers.Add(1);
                return 1;
            }

            var result = Fibonacci(number - 1) + Fibonacci(number - 2);
            _calculatedFibonacciNumbers.Add(result);
            return result;
        }

        public static long SumOfEvenFibonacci(long limit)
        {
            long result = 0;
            var fibonacci = Fibonacci(0);
            var i = 0;

            while (fibonacci < limit)
            {
                result += fibonacci;
                i += 3;
                fibonacci = Fibonacci(i);
            }

            return result;
        }

		public static void Main(string[] args)
		{
            Stopwatch timer = Stopwatch.StartNew();

            long result = SumOfEvenFibonacci(4_000_000);

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
}
    }
}