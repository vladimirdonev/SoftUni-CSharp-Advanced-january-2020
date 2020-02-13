using System;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        public static int[] numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            Predicate<int> predicate = Fill;
            predicate(n);
            Console.WriteLine(string.Join(" ", numbers));
        }
        static bool Fill(int n)
        {
            bool remaining = true;
            numbers = numbers.Where(x => x % n != 0).Reverse().ToArray();
            return remaining;
        }
    }
}
