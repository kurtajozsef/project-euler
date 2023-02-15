namespace Program
{
	public static class Program
	{
		public static void Main()
		{
			ulong sum = 0;
			ulong fibonacci = Fibonacci(1);
			int i = 1;

			while (fibonacci < 4000000)
			{
				if (fibonacci % 2 == 0)
				{
					sum += fibonacci;
				}
				i++;
				fibonacci = Fibonacci(i);
			}

			Console.WriteLine(sum);
		}

		public static ulong Fibonacci(int number)
		{
			if (number == 0 || number == 1)
			{
				return 1;
			}

			return Fibonacci(number - 1) + Fibonacci(number - 2);
		}
	}
}