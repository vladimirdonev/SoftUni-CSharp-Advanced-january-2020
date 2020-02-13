using System;
using System.Linq;

namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var firstinput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var Name = firstinput[0] + " " + firstinput[1];
            var Street = firstinput[2];
            var Town = string.Join(" ",firstinput.Skip(3));
            Print(Name, Street, Town);
            var secondinput = Console.ReadLine().Split(" ").ToArray();
            Name = secondinput[0];
            var beer = double.Parse(secondinput[1]);
            var drunk = secondinput[2];
            Print(Name, Street, drunk);
            var thirdinput = Console.ReadLine().Split(" ").ToArray();
            Name = thirdinput[0];
            var money = double.Parse(thirdinput[1]);
            var bank = thirdinput[2];
            Console.WriteLine($"{Name} -> {money:f1} -> {bank}");
        }
        public static void Print<T,t,l>(T Item,t Item2,l Item3)
        {
            var tuple = new Tuple<T,t,l>(Item,Item2,Item3);
            var first = tuple.Item1;
            var second = tuple.Item2;
            var third = tuple.Item3;
            bool IsDrunk = false;
            if (third.Equals("drunk"))
            {
                IsDrunk = true;
                Console.WriteLine($"{first} -> {second} -> {IsDrunk}");
            }
            else if(third.Equals("not"))
            {
                Console.WriteLine($"{first} -> {second} -> {IsDrunk}");
            }
            else
            {
                Console.WriteLine($"{first} -> {second} -> {third}");
            }
        }
    }
}
