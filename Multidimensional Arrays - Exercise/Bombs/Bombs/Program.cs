using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            fill(matrix);
            string[] coordinates = Console.ReadLine().Split(" ").ToArray();
            int bombs = coordinates.Length;
            int sum = 0;
            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] coordinate = coordinates[i].Split(",").Select(int.Parse).ToArray();
                int x = coordinate[0];
                int y = coordinate[1];
                detonate(x, y, matrix);
            }

            sum = matrix.Cast<int>().Where(x => x > 0).Sum();
            Console.WriteLine($"Alive cells: {alive(matrix)}");
            Console.WriteLine($"Sum: {sum}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] detonate(int x, int y, int[,] matrix)
        {
            if (validcoordinates(x, y, matrix))
            {
                int number = matrix[x, y];
                if (validcoordinates(x - 1, y - 1, matrix))
                {
                    if (bigerthanzero(x - 1, y - 1, matrix))
                    {
                        matrix[x - 1, y - 1] -= number;
                    }
                }
                if (validcoordinates(x - 1, y, matrix))
                {
                    if (bigerthanzero(x - 1, y, matrix))
                    {
                        matrix[x - 1, y] -= number;
                    }
                }
                if (validcoordinates(x - 1, y + 1, matrix))
                {
                    if (bigerthanzero(x - 1, y + 1, matrix))
                    {
                        matrix[x - 1, y + 1] -= number;
                    }
                }
                if (validcoordinates(x, y + 1, matrix))
                {
                    if (bigerthanzero(x, y + 1, matrix))
                    {
                        matrix[x, y + 1] -= number;
                    }
                }
                if (validcoordinates(x, y - 1, matrix))
                {
                    if (bigerthanzero(x, y - 1, matrix))
                    {
                        matrix[x, y - 1] -= number;
                    }
                }
                if (validcoordinates(x + 1, y - 1, matrix))
                {
                    if (bigerthanzero(x + 1, y - 1, matrix))
                    {
                        matrix[x + 1, y - 1] -= number;
                    }
                }
                if (validcoordinates(x + 1, y, matrix))
                {
                    if (bigerthanzero(x + 1, y, matrix))
                    {
                        matrix[x + 1, y] -= number;
                    }
                }
                if (validcoordinates(x + 1, y + 1, matrix))
                {
                    if (bigerthanzero(x + 1, y + 1, matrix))
                    {
                        matrix[x + 1, y + 1] -= number;
                    }
                }
                matrix[x, y] -= number;
            }
            return matrix;
        }
        public static bool validcoordinates(int x, int y, int[,] matrix)
        {
            if (x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }
        public static bool bigerthanzero(int x, int y, int[,] matrix)
        {
            if (matrix[x, y] > 0)
            {
                return true;
            }
            return false;
        }
        public static int[,] fill(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            return matrix;
        }
        public static int alive(int[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}