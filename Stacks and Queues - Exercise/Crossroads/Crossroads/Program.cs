using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int freewindow = int.Parse(Console.ReadLine());
            var carqueue = new Queue<string>();
            string command = null;
            int remainingtime = n;
            int remainingfromfreewindow = freewindow;
            int carspassed = 0;
            int carscrash = 0;
            while (command != "END")
            {
                command = Console.ReadLine();
                remainingtime = n;
                remainingfromfreewindow = freewindow;
                if (command == "END")
                {
                    break;
                }
                else if (command == "green")
                {
                    while (true)
                    {
                        string car = null;
                        if (remainingtime > 0)
                        {
                            if (carqueue.Count == 0)
                            {
                                break;
                            }
                            car = carqueue.Dequeue();
                            if (remainingtime - car.Length >= 0)
                            {
                                remainingtime -= car.Length;
                                carspassed++;
                                if (remainingtime == 0)
                                {
                                    break;
                                }
                            }
                            else
                            {
                                if (remainingfromfreewindow - car.Length > 0)
                                {
                                    carspassed++;
                                    break;
                                }
                                else
                                {
                                    remainingfromfreewindow += remainingtime;
                                    string hit = car.Substring(remainingfromfreewindow, 1);
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{car} was hit at {hit}.");
                                    carscrash++;
                                    break;
                                }
                            }
                        }
                        if (carscrash > 0)
                        {
                            break;
                        }
                    }
                }
                else
                {
                    carqueue.Enqueue(command);
                }
            }
            if (carscrash == 0)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carspassed} total cars passed the crossroads.");
            }
        }
    }
}
