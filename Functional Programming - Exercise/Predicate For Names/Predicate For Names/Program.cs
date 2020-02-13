using System;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        public static string[] Names;
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Names = Console.ReadLine().Split(" ");
            Predicate<int> predicate = Fill;
            predicate(n);
            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
        static bool Fill(int n)
        {
            bool remaining = true;
            Names = Names.Where(x => x.Length <= n).ToArray();
            return remaining;
        }
    }
}
