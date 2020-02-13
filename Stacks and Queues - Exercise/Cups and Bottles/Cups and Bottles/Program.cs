using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsarr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] bottlesarr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var cups = new Queue<int>(cupsarr);
            var bottles = new Stack<int>(bottlesarr);
            var totalwoter = 0;
            var leftcap = 0;
            while (true)
            {
                if (cups.Count == 0)
                {
                    break;
                }
                if (bottles.Count == 0)
                {
                    break;
                }
                var cup = cups.Peek();
                var bottle = bottles.Peek();
                var woterleft = 0;
                if (leftcap > 0)
                {
                    if (leftcap - bottle <= 0)
                    {
                        cups.Dequeue();
                        bottles.Pop();
                        woterleft = bottle - leftcap;
                        totalwoter += woterleft;
                        leftcap = 0;
                    }
                    else
                    {
                        bottles.Pop();
                        leftcap -= bottle;
                    }
                }
                else if (cup - bottle <= 0)
                {
                    woterleft = bottle - cup;
                    totalwoter += woterleft;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else if (cup - bottle > 0)
                {
                    bottles.Pop();
                    leftcap = cup - bottle;

                }

            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {totalwoter}");
        }
    }
}
