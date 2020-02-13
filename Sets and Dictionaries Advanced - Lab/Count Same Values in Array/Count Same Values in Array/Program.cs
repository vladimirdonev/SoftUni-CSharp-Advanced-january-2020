using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var dic = new Dictionary<double, int>();
            double[] numbers = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (dic.ContainsKey(numbers[i]))
                {
                    dic[numbers[i]]++;
                }
                else
                {
                    dic[numbers[i]] = 1;
                }
            }
            foreach (var number in dic)
            {
                Console.WriteLine("{0} - {1} times", number.Key, number.Value);
            }
        }
    }
}
