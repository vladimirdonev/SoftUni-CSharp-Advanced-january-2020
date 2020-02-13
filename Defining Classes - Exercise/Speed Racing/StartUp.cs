using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = null;
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] splitedinput = Console.ReadLine().Split(" ");
                string carmodel = splitedinput[0];
                double fuelamount = double.Parse(splitedinput[1]);
                double fuelConsumptionFor1km = double.Parse(splitedinput[2]);
                cars[i] = new Car(carmodel, fuelamount, fuelConsumptionFor1km);
            }
            while (command != "End")
            { 
                command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }
                string[] commands = command.Split();
                string carModel = commands[1];
                double amountOfKm = double.Parse(commands[2]);
                cars.Where(c => c.Model == carModel).ToList().ForEach(c => c.Drive(amountOfKm));
            }
            foreach (Car car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.Model, car.FuelAmount, car.TravelledDistance);
            }
        }
    }
}
