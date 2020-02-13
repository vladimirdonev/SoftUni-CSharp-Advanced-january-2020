using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            for (int i = 1; i <= n; i++)
            {
                int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int query = number[0];
                if (query == 1)
                {
                    int element = number[1];
                    numbers.Push(element);
                }
                else if (query == 2)
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }
                }
                else if (query == 3)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (query == 4)
                {
                    if (numbers.Count > 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
