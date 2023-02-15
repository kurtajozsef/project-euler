namespace Program
{
	public static class Program
	{
		private static List<ulong> calculatedFibonacciNumbers = new List<ulong>();
		public static void Main()
		{
			ulong sum = 0;
			ulong fibonacci = Fibonacci(0);
			int i = 0;

			// every 
			while (fibonacci < 4000000)
			{
				sum += fibonacci;
				i += 3;
				fibonacci = Fibonacci(i);
			}

			Console.WriteLine(sum);
		}

		public static ulong Fibonacci(int number)
		{
			if (calculatedFibonacciNumbers.Count > number)
			{
				return calculatedFibonacciNumbers[number];
			}

			if (number == 0)
			{
				calculatedFibonacciNumbers.Add(0);
				return 0;
			}

			if (number == 1)
			{
				calculatedFibonacciNumbers.Add(1);
				return 1;
			}

			ulong fibonacci = Fibonacci(number - 1) + Fibonacci(number - 2);
			calculatedFibonacciNumbers.Add(fibonacci);
			return fibonacci;
		}
	}
}