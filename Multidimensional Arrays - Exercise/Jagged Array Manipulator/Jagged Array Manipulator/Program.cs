using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                return;
            }
            double[][] jagged = new double[n][];
            for (int i = 0; i < jagged.Length; i++)
            {
                double[] number = Console.ReadLine().Split(" ").Select(double.Parse).ToArray();
                jagged[i] = new double[number.Length];
                for (int j = 0; j < number.Length; j++)
                {
                    jagged[i][j] += number[j];
                }
            }
            for (int i = 0; i < jagged.Length - 1; i++)
            {
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    jagged[i] = jagged[i].Select(x => x * 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jagged[i] = jagged[i].Select(x => x / 2).ToArray();
                    jagged[i + 1] = jagged[i + 1].Select(x => x / 2).ToArray();
                }

            }
            string command = null;
            while (command != "End")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(" ");
                string currentcommand = splitedinput[0];
                if (currentcommand == "Add")
                {
                    int row = int.Parse(splitedinput[1]);
                    int col = int.Parse(splitedinput[2]);
                    int number = int.Parse(splitedinput[3]);
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged.GetLength(0))
                    {
                        jagged[row][col] += number;
                    }
                }
                else if (currentcommand == "Subtract")
                {
                    int row = int.Parse(splitedinput[1]);
                    int col = int.Parse(splitedinput[2]);
                    int number = int.Parse(splitedinput[3]);
                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged.GetLength(0))
                    {
                        jagged[row][col] -= number;
                    }
                }
                else if (currentcommand == "End")
                {
                    for (int row = 0; row < jagged.Length; row++)
                    {
                        for (int col = 0; col < jagged[row].Length; col++)
                        {
                            Console.Write(jagged[row][col] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
        }
    }
}
