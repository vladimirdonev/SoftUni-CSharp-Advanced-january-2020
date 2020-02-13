using System;
using System.Collections.Generic;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {

            var guests = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "PARTY")
                {
                    while (true)
                    {
                        command = Console.ReadLine();
                        if (command == "END")
                        {
                            break;
                        }
                        guests.Remove(command);
                    }
                    break;
                }
                else
                {
                    guests.Add(command);
                }
            }
            Console.WriteLine(guests.Count);
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
