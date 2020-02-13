using System;
using System.Collections.Generic;
using System.Linq;

namespace Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(' ').ToList();
            int count = int.Parse(Console.ReadLine());
            var lastpersonstanding = new Queue<string>(names);
            while (lastpersonstanding.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    lastpersonstanding.Enqueue(lastpersonstanding.Dequeue());
                }
                Console.WriteLine($"Removed {lastpersonstanding.Dequeue()}");
            }
            Console.WriteLine($"Last is {string.Join("", lastpersonstanding)}");
        }
    }
}
