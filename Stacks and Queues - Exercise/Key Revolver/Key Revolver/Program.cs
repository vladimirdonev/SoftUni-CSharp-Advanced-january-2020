using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bullet = int.Parse(Console.ReadLine());
            int bulletmax = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());
            var locksqueue = new Queue<int>(locks);
            var bulletsstack = new Stack<int>(bullets);
            var bulletcount = 0;
            while (locksqueue.Count > 0)
            {
                if (locksqueue.Count == 0)
                {
                    break;
                }
                for (int i = 0; i < bulletmax; i++)
                {
                    if (bulletsstack.Count == 0)
                    {
                        break;
                    }
                    if (locksqueue.Count == 0)
                    {
                        break;
                    }
                    if (bulletsstack.Pop() <= locksqueue.Peek())
                    {
                        locksqueue.Dequeue();
                        Console.WriteLine("Bang!");
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                    }
                    bulletcount++;
                }
                if (bulletsstack.Count == 0)
                {
                    break;
                }
                Console.WriteLine("Reloading!");
            }
            int moneyEarned = intelligence - (bulletcount * bullet);
            if (locksqueue.Count == 0)
            {
                Console.WriteLine($"{bulletsstack.Count} bullets left. Earned ${moneyEarned}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksqueue.Count}");
            }
        }
    }
}
