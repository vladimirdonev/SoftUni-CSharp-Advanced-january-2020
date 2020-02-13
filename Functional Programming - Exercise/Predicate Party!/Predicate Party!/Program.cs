using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        public static List<string> Names;
        public static int[] numbers;
        static void Main(string[] args)
        {
            Names = Console.ReadLine().Split(" ").ToList();
            string command = null;
            while (command != "Party!")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(" ");
                Func<string[], List<string>> Partylist = Goingtoparty;
                Partylist(splitedinput);
            }
            Names.Sort();
            if (Names.Any())
            {
                Console.Write($"{string.Join(", ", Names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        static List<string> Goingtoparty(string[] splitedinput)
        {
            string currentcommand = splitedinput[0];
            if (currentcommand == "Remove")
            {
                string startswithorendwith = splitedinput[1];
                if (startswithorendwith == "StartsWith")
                {
                    string letter = splitedinput[2];
                    Names.RemoveAll(x => x.StartsWith(letter));
                }
                else if (startswithorendwith == "EndsWith")
                {
                    string letter = splitedinput[2];
                    Names.RemoveAll(x => x.EndsWith(letter));
                }
                else
                {
                    int lenght = int.Parse(splitedinput[2]);
                    Names.RemoveAll(x => x.Length == lenght);
                }
            }
            else if (currentcommand == "Double")
            {
                string nextcommand = splitedinput[1];
                switch (nextcommand)
                {
                    case "StartsWith":
                        string letter = splitedinput[2];
                        List<string> names3 = Names.FindAll(x => x.StartsWith(letter));
                        foreach (var name in names3)
                        {
                            Names.Add(name);
                        }
                        break;
                    case "EndsWith":
                        letter = splitedinput[2];
                        List<string> names1 = Names.FindAll(x => x.EndsWith(letter));
                        foreach (var name in names1)
                        {
                            Names.Add(name);
                        }
                        break;
                    case "Length":
                        int lenght = int.Parse(splitedinput[2]);
                        List<string> names = Names.FindAll(x => x.Length == lenght);
                        foreach (var name in names)
                        {
                            Names.Add(name);
                        }

                        break;
                }
            }
            else
            {

            }
            return Names;
        }
    }
}
