using System;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int[], int> SmallestNumber = Smallest;
            Console.WriteLine(string.Join(" ", SmallestNumber(numbers)));

        }
        static int Smallest(int[] number)
        {
            int smallest = number.Min();
            return smallest;
        }
    }
}
