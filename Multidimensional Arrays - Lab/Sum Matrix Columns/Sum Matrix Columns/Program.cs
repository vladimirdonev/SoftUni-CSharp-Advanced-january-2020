using System;
using System.Linq;

namespace Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var col = n[1];
            var raws = n[0];
            var matrix = new int[raws, col];
            int sumcols = 0;
            for (int raw = 0; raw < raws; raw++)
            {
                int[] colelements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[raw, cols] = colelements[cols];
                }
            }
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumcols += matrix[row, cols];
                }
                Console.WriteLine(sumcols);
                sumcols = 0;
            }
        }
    }
}
