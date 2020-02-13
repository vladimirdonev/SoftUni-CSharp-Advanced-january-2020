using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        public static List<string> Names;
        public static int[] numbers;
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Names = Console.ReadLine().Split(" ").ToList();
            Func<int, string> FirstName = Goingtoparty;
            Console.WriteLine(FirstName(number));
        }
        static string Goingtoparty(int number)
        {
            int sum = 0;
            string Toreturn = null;
            for (int i = 0; i < Names.Count; i++)
            {
                string name = Names[i];
                for (int j = 0; j < name.Length; j++)
                {
                    char letter = name[j];
                    sum += letter;
                }
                if (sum >= number)
                {
                    Toreturn = name;
                    break;
                }
                else
                {
                    sum = 0;
                }
            }
            return Toreturn;
        }
    }
}
