using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            int sumdiagonal = 0;
            for (int raw = 0; raw < matrix.GetLength(0); raw++)
            {
                int[] colelements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[raw, col] = colelements[col];
                    if (raw == col)
                    {
                        sumdiagonal += matrix[raw, col];
                    }
                }
            }
            Console.WriteLine(sumdiagonal);
        }
    }
}
