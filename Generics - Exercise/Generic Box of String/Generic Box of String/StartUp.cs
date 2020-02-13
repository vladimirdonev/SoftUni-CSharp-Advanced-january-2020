using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericBoxofString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var Numbers = new List<Box<double>>();
            for (int i = 0; i < n; i++)
            {
                var words = new Box<double>(double.Parse(Console.ReadLine()));
                Numbers.Add(words);
            }
            var element = double.Parse(Console.ReadLine());
            var box = new Box<double>(3);
            int count =  box.Count(Numbers, element);
            Console.WriteLine(count);
        }
    }
}
