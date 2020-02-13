using System;
using System.Linq;

namespace Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colelements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] += colelements[col];
                }
            }
            string command = null;
            while (command != "END")
            {
                command = Console.ReadLine();
                string[] splitedinput = command.Split(" ");
                string currentcommand = splitedinput[0];
                if (currentcommand == "Add")
                {
                    int rowindex = int.Parse(splitedinput[1]);
                    int colindex = int.Parse(splitedinput[2]);
                    int number = int.Parse(splitedinput[3]);
                    if (rowindex >= 0 && rowindex < matrix.GetLength(0) && colindex >= 0 && colindex < matrix.GetLength(1))
                    {
                        matrix[rowindex, colindex] += number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (currentcommand == "Subtract")
                {
                    int rowindex = int.Parse(splitedinput[1]);
                    int colindex = int.Parse(splitedinput[2]);
                    int number = int.Parse(splitedinput[3]);
                    if (rowindex >= 0 && rowindex < matrix.GetLength(0) && colindex >= 0 && colindex < matrix.GetLength(1))
                    {
                        matrix[rowindex, colindex] -= number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
        }
    }
}
