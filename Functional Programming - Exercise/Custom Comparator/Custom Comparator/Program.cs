using System;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        public static int[] numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int[], int[]> writeeven = even;
            writeeven += odd;
            writeeven(numbers);
        }
        static int[] even(int[] numbers2)
        {
            numbers2 = numbers;
            numbers2 = numbers2.Where(x => x % 2 == 0).ToArray();
            numbers2 = numbers2.OrderBy(x => x).ToArray();
            Console.Write(string.Join(" ", numbers2));
            Console.Write(" ");
            return numbers2;
        }
        static int[] odd(int[] numbers2)
        {
            numbers2 = numbers;
            numbers2 = numbers2.Where(x => x % 2 != 0).ToArray();
            numbers2 = numbers2.OrderBy(x => x).ToArray();
            Console.Write(string.Join(" ", numbers2));
            return numbers2;
        }
    }
}
