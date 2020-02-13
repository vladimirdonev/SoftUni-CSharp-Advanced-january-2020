using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopinfo = new SortedDictionary<string, Dictionary<string, double>>();
            string command = null;
            while (command != "Revision")
            {
                command = Console.ReadLine();
                if (command == "Revision")
                {
                    break;
                }
                string[] splitedinput = command.Split(", ");
                string shop = splitedinput[0];
                string product = splitedinput[1];
                double price = double.Parse(splitedinput[2]);
                if (shopinfo.ContainsKey(shop))
                {
                    shopinfo[shop].Add(product, price);
                }
                else
                {
                    var dic = new Dictionary<string, double>();
                    dic.Add(product, price);
                    shopinfo.Add(shop, dic);
                    dic = new Dictionary<string, double>();
                }
            }
            foreach (var shop in shopinfo)
            {
                Console.WriteLine($"{shop.Key}-> ");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
            Console.WriteLine();
        }
    }
}
