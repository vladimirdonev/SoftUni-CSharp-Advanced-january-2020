using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        public static int[] numbers;
        static void Main(string[] args)
        {
            numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = null;
            while (command != "end")
            {
                command = Console.ReadLine();
                Action<string> mathoperation = Fill;
                mathoperation(command);
            }
        }
        static void Fill(string command)
        {
            switch (command)
            {
                case "add":
                    numbers = numbers.Select(x => x += 1).ToArray();
                    break;
                case "multiply":
                    numbers = numbers.Select(x => x *= 2).ToArray();
                    break;
                case "subtract":
                    numbers = numbers.Select(x => x -= 1).ToArray();
                    break;
                case "print":
                    Console.WriteLine(string.Join(" ", numbers));
                    break;
                case "end":

                    break;

            }
        }
    }
}
