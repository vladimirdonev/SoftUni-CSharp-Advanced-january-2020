using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkinginfo = new HashSet<string>();
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }
                string[] parts = command.Split(", ");
                string inout = parts[0];
                string carnumber = parts[1];
                if (inout == "IN")
                {
                    parkinginfo.Add(carnumber);
                }
                else
                {
                    parkinginfo.Remove(carnumber);
                }
            }
            if (parkinginfo.Any())
            {
                foreach (var carplates in parkinginfo)
                {
                    Console.WriteLine(carplates);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
