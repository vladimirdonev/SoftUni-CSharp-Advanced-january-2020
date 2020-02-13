using System;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");
            Action<string[]> action = Print;
            action(words);
        }
        static void Print(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
