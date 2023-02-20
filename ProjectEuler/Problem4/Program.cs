//https://projecteuler.net/problem=4

using System.Diagnostics;

namespace Problem4
{
    public class Program
    {
        public static bool IsPalindrome(long number)
        {
            if (number < 0)
            {
                return false;
            }

            var numberString = number.ToString();

            var numberStringArray = numberString.ToCharArray();
            Array.Reverse(numberStringArray);
            var reverseNumberString = new string(numberStringArray);

            return numberString.Equals(reverseNumberString);
        }

        public static long LargestPalindromeOfProduct()
        {
            var upperLimit = 999;
            var lowerLimit = 100;
            long result = 0;

            for (var i = upperLimit; i > lowerLimit; i--)
            {
                for (var j = i; j > lowerLimit; j--)
                {
                    var number = i * j;
                    if (!IsPalindrome(number) || result > number)
                    {
                        continue;
                    }

                    result = number;
                }
            }
            return result;
        }

        public static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            var result = LargestPalindromeOfProduct();

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds}ms");
        }
    }
}