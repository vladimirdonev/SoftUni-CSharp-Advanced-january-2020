using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();
            var song = new Queue<string>(songs);
            string command = null;
            while (song.Count > 0)
            {
                command = Console.ReadLine();
                if (command.StartsWith("Add"))
                {
                    string newsong = command.Substring(4, command.Length - 4);
                    if (song.Contains(newsong))
                    {
                        Console.WriteLine($"{newsong} is already contained!");
                    }
                    else
                    {
                        song.Enqueue(newsong);
                    }
                }
                else if (command == "Play")
                {
                    if (song.Count > 0)
                    {
                        song.Dequeue();
                    }
                }
                else
                {
                    Console.WriteLine(string.Join(", ", song));
                }
                if (song.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }
            }
        }
    }
}
