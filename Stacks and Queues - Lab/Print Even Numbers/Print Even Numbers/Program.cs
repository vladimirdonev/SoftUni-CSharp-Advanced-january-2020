using System;
using System.Collections.Generic;
using System.Linq;

namespace Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>(number);
            Console.WriteLine(string.Join(", ", queue.Where(x => x % 2 == 0)));

        }
    }
}
