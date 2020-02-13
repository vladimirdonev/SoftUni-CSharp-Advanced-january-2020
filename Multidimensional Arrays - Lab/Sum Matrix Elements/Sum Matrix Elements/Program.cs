using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            var col = n[1];
            var raws = n[0];
            var matrix = new int[raws, col];
            for (int raw = 0; raw < raws; raw++)
            {
                int[] colelements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[raw, cols] = colelements[cols];
                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(matrix.Cast<int>().Sum());
        }
    }
}
