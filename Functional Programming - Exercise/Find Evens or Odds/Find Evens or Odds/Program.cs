using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int Start = numbers[0];
            int End = numbers[1];
            var Command = Console.ReadLine();
            Func<string, int, int, bool> EvenorOdd = Fill;
            EvenorOdd(Command, Start, End);
        }
        static bool Fill(string command, int Start, int End)
        {
            bool EvenorOdd = true;
            var numbers = new List<int>();
            for (int i = Start; i <= End; i++)
            {
                if (command == "even")
                {
                    int num = i;
                    if (num % 2 == 0)
                    {
                        Console.Write(num + " ");
                    }
                }
                else
                {
                    int num = i;
                    if (num % 2 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
            }
            return EvenorOdd;
        }
    }
}
