using System;
using System.Linq;
namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var matrix = new string[n[0]][];
            int counter = 0;
            if (n.Length < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int row = 0; row < n[0]; row++)
                {
                    matrix[row] = Console.ReadLine().Split(" ").ToArray();

                }
                for (int row = 0; row < n[0] - 1; row++)
                {
                    for (int col = 0; col < n[1] - 1; col++)
                    {
                        if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col] && matrix[row][col] == matrix[row + 1][col + 1])
                        {
                            counter++;
                        }
                    }
                }
                Console.WriteLine(counter);
            }
        }
    }
}
