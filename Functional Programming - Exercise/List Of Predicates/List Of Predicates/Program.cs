using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Of_Predicates
{
    class Program
    {
        public static int[] numbers;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int, int[], List<int>> writeeven = candevide;
            writeeven(n, numbers);
        }
        static List<int> candevide(int n, int[] numbers)
        {
            bool devidebyall = true;
            var numbers2 = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                foreach (var num in numbers)
                {
                    if (i % num != 0)
                    {
                        devidebyall = false;

                    }
                    else
                    {
                        devidebyall = true;
                    }
                }
                if (devidebyall == true)
                {
                    numbers2.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", numbers2));
            return numbers2;
        }
    }
}
