using System;
using System.Linq;
using System.Collections.Generic;
namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var matrix = new int[size, size];
            int primarydiagonal = 0;
            int secondarydiagoal = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colelemnts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] += colelemnts[col];
                    if (row == col)
                    {
                        primarydiagonal += matrix[row, col];
                    }
                    if (row == size - col - 1)
                    {
                        secondarydiagoal += matrix[row, col];
                    }
                }
            }
            int sum = Math.Abs(primarydiagonal - secondarydiagoal);
            Console.WriteLine(sum);
        }
    }
}
