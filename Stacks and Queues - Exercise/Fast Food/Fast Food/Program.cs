using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] foodrequest = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var numbers = new Queue<int>(foodrequest);
            Console.WriteLine(numbers.Max());
            while (n > 0)
            {
                int element = numbers.Peek();
                if (n - element >= 0)
                {
                    if (numbers.Count > 0)
                    {
                        n -= element;
                        numbers.Dequeue();
                    }
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Orders complete");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", numbers)}");
                    break;
                }
            }
        }
    }
}
