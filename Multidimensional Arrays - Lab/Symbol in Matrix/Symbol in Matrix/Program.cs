using System;
using System.Linq;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colelements = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] += colelements[col];
                }
            }
            string symbol = Console.ReadLine();
            int x = 0;
            int y = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == char.Parse(symbol))
                    {
                        x = row;
                        y = col;
                        break;
                    }
                }
            }
            if (matrix.Cast<char>().Contains(char.Parse(symbol)))
            {
                Console.WriteLine($"({x}, {y})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
