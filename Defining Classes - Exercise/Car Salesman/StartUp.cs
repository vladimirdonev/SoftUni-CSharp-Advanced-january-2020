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
            var Engine = new List<engine>();
            Addengineinfo(n, Engine);
            var car = new List<Car>();
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] splitedinput = Console.ReadLine().Split(new string[] {" "},StringSplitOptions.RemoveEmptyEntries);
                string carmodel = splitedinput[0];
                string enginemodel = splitedinput[1];
                string weight = "n/a";
                string color = "n/a";
                if (splitedinput.Length >= 3)
                {
                    if (char.IsNumber(splitedinput[2], 0))
                    {
                        weight = splitedinput[2];
                    }
                    else
                    {
                        weight = "n/a";
                        color = splitedinput[2];
                    }
                }
                if (splitedinput.Length == 4)
                {
                    color = splitedinput[3];
                }
                var sort = Engine.FirstOrDefault(x => x.Model == enginemodel);
                Car Car = new Car(carmodel,sort,weight,color);
                car.Add(Car);
            }
            foreach (var item in car)
            {
                PrintCarModelEngineAndEngineProperties(item);
                PrintCarWeightAndColor(item);
            }
        }

        private static void PrintCarWeightAndColor(Car car)
        {

                Console.WriteLine($"  Weight: {car.Weight}");

                Console.WriteLine($"  Color: {car.Color}");
            
        }
        private static void PrintCarModelEngineAndEngineProperties(Car car)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            
        }
        private static List<engine> Addengineinfo(int n, List<engine> Engine)
        {
            for (int i = 0; i < n; i++)
            {
                string[] splitedintput = Console.ReadLine().Split(' ');
                string enginemodel = splitedintput[0];
                string power = splitedintput[1];
                var displacement = "n/a";
                string efficiency = "n/a";
                if (splitedintput.Length >= 3)
                {
                    if (char.IsNumber(splitedintput[2], 0))
                    {
                        displacement = splitedintput[2];
                    }
                    else
                    {
                        displacement = "n/a";
                        efficiency = splitedintput[2];
                    }
                }
                if (splitedintput.Length == 4)
                {
                    efficiency = splitedintput[3];
                }
                engine engine = new engine(enginemodel, power, displacement, efficiency);
                Engine.Add(engine);
            }
            return Engine;
        }
    }
}
