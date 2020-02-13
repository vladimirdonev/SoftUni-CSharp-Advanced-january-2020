using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Action<string[]> action = Print;
            action(words);
        }
        static void Print(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine($"Sir {word}");
            }
        }
    }
}
