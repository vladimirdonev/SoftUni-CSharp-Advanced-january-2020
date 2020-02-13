using System;
using System.Linq;
namespace Matrix_Shuffing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimesion = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var matrix = new string[dimesion[0], dimesion[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colelements = Console.ReadLine().Split(" ").ToArray();
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
                if (command == "END")
                {
                    break;
                }
                if (splitedinput[0] == "swap")
                {
                    if (splitedinput.Length == 5)
                    {
                        int x = int.Parse(splitedinput[1]);
                        int y = int.Parse(splitedinput[2]);
                        int x1 = int.Parse(splitedinput[3]);
                        int y1 = int.Parse(splitedinput[4]);
                        if (x >= 0 && x < matrix.GetLength(0) && x1 >= 0 && x1 < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1) &&
                            y1 >= 0 && y1 < matrix.GetLength(1))
                        {
                            string firstelement = matrix[x, y];
                            string secondelement = matrix[x1, y1];
                            matrix[x, y] = secondelement;
                            matrix[x1, y1] = firstelement;
                            for (int row = 0; row < matrix.GetLength(0); row++)
                            {
                                for (int col = 0; col < matrix.GetLength(1); col++)
                                {
                                    Console.Write(matrix[row, col] + " ");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
