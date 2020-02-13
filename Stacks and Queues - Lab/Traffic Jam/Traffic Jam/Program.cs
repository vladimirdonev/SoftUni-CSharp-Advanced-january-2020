using System;
using System.Collections.Generic;

namespace Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofcars = int.Parse(Console.ReadLine());
            var cars = new Queue<string>();
            int totalcarspassed = 0;
            string command = null;
            while (command != "end")
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    Console.WriteLine($"{totalcarspassed} cars passed the crossroads.");
                    break;
                }
                else if (command == "green")
                {
                    for (int i = 0; i < numberofcars && cars.Count > 0; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalcarspassed++;
                    }
                    continue;
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
        }
    }
}
