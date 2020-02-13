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
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] splitedinput = Console.ReadLine().Split(" ");
                tire tire = new tire(double.Parse(splitedinput[5]), int.Parse(splitedinput[6]), double.Parse(splitedinput[7]),
                    int.Parse(splitedinput[8]),double.Parse(splitedinput[9]), int.Parse(splitedinput[10]), double.Parse(splitedinput[11]),
                    int.Parse(splitedinput[12]));
                cargo cargo = new cargo(int.Parse(splitedinput[3]), splitedinput[4]);
                engine engine = new engine(int.Parse(splitedinput[1]), int.Parse(splitedinput[2]));
                Car car = new Car(splitedinput[0], engine, cargo, tire);
                cars.Add(car);
            }
            string lastinput = Console.ReadLine();
            if(lastinput == "fragile")
            {
                cars = cars.Where(x => x.Cargo.CargoType == lastinput).ToList();
                foreach (var car in cars)
                {
                    double first = car.Tire.FirstTirePressure;
                    double second = car.Tire.SecondTirePressure;
                    double third = car.Tire.ThirdTirePressure;
                    double fourth = car.Tire.FourthTirePressure;
                    if(first < 1 || second < 1 || third < 1 || fourth < 1)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if(lastinput == "flamable")
            {
                cars = cars.Where(x => x.Cargo.CargoType == lastinput).ToList();
                foreach (var car in cars)
                {
                    if(car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
