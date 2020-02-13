using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            string command = null;
            while (command != "End")
            {
                command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                else if (command == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
