using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = number[0];
            int s = number[1];
            int x = number[2];
            int[] num = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var numbers = new Queue<int>();
            for (int i = 0; i < num.Length; i++)
            {
                numbers.Enqueue(num[i]);
            }
            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
