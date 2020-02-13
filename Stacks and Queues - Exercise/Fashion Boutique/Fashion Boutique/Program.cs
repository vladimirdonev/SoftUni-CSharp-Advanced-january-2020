using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] totalclothes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var rackcap = int.Parse(Console.ReadLine());
            var racks = new Stack<int>(totalclothes);
            int count = 1;
            var sum = 0;
            while (racks.Count > 0)
            {
                sum += racks.Peek();
                if (sum <= rackcap)
                {
                    racks.Pop();
                }
                else
                {
                    count++;
                    sum = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
