using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var Globeinfo = new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] splitedinput = Console.ReadLine().Split(" ");
                string Continent = splitedinput[0];
                string Country = splitedinput[1];
                string City = splitedinput[2];
                var dic = new Dictionary<string, List<string>>();
                var list = new List<string>();
                list.Add(City);
                dic.Add(Country, list);
                if (Globeinfo.ContainsKey(Continent))
                {
                    if (Globeinfo[Continent].ContainsKey(Country))
                    {
                        Globeinfo[Continent][Country].Add(City);
                    }
                    else
                    {
                        Globeinfo[Continent].Add(Country, list);
                    }
                }
                else
                {
                    Globeinfo.Add(Continent, dic);
                }
                list = new List<string>();
                dic = new Dictionary<string, List<string>>();
            }
            foreach (var Country in Globeinfo)
            {
                Console.WriteLine($"{Country.Key}:");
                foreach (var item in Country.Value)
                {
                    Console.WriteLine($"  {item.Key} -> {string.Join(", ", item.Value)}");
                }
            }
        }
    }
}
