ulong sum = 0;

for (ulong i = 1; i < 1000; i++)
{
	if (i % 3 == 0 || i % 5 == 0)
	{
		sum += i;
	}
}

Console.WriteLine(sum);