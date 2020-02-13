using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string Studentname = input[0];
                double grade = double.Parse(input[1]);
                var list = new List<double>();
                list.Add(grade);
                if (dic.ContainsKey(Studentname))
                {
                    dic[Studentname].Add(grade);
                }
                else
                {
                    dic.Add(Studentname, list);
                }
                list = new List<double>();
            }
            foreach (var student in dic)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var item in student.Value)
                    Console.Write($"{item:f2} ");
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
