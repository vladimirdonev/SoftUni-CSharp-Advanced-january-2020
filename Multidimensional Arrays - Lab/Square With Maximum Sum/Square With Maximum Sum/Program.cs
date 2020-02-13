using System;
using System.Linq;

namespace Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var matrix = new int[size[0], size[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colelements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] += colelements[col];
                }
            }
            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                Console.WriteLine("No solution");
                return;
            }
            int max = int.MinValue;
            int maxrowsum = -1;
            int maxcolsum = -1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var matrixsum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (matrixsum > max)
                    {
                        max = matrixsum;
                        maxrowsum = row;
                        maxcolsum = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxrowsum, maxcolsum]} {matrix[maxrowsum, maxcolsum + 1]}");
            Console.WriteLine($"{matrix[maxrowsum + 1, maxcolsum]} {matrix[maxrowsum + 1, maxcolsum + 1]}");
            Console.WriteLine(max);
        }
    }
}
