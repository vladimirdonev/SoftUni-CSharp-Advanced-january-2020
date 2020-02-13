using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbers = new Stack<int>();
            foreach (var item in number)
            {
                numbers.Push(item);
            }
            string command = null;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                string[] splitedinput = command.Split(' ');
                string currentcommand = splitedinput[0];
                if (currentcommand == "add")
                {
                    int firtnumber = int.Parse(splitedinput[1]);
                    int nextnumber = int.Parse(splitedinput[2]);
                    numbers.Push(firtnumber);
                    numbers.Push(nextnumber);
                }
                else if (currentcommand == "remove")
                {
                    int count = int.Parse(splitedinput[1]);
                    if (count <= numbers.Count())
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
