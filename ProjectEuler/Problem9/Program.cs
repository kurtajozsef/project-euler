//https://projecteuler.net/problem=9

using System.Diagnostics;

namespace Problem9
{
    public class Program
    {
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return (a * a + b * b) == (c * c);
        }

        public static Tuple<int, int, int> GetPythagoreanTripletForSum(int sum)
        {
            for (var i = sum; i > 1; i--)
            {
                for (var j = sum - i; j > 1; j--)
                {
                    var k = sum - i - j;
                    if (k != 0 && IsPythagoreanTriplet(k, j, i))
                    {
                        return new Tuple<int, int, int>(k, j, i);
                    }
                }
            }

            return null!;
        }

        public static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();

            var triplet = GetPythagoreanTripletForSum(1000);
            var result = triplet.Item1 * triplet.Item2 * triplet.Item3;

            timer.Stop();

            Console.WriteLine($"Ans: {result}\nTime: {timer.ElapsedMilliseconds} ms");
        }
    }
}