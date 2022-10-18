using System;
using System.Linq;
using System.Runtime.InteropServices;

using System;
using System.Linq;

namespace _2x2_Square_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            char[,] matrix = new char[dimentions[0], dimentions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] chars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => char.Parse(n)).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
            int count = 0;
            if (matrix.GetLength(0) > 1 && matrix.GetLength(1) > 1)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        if (matrix[row, col] == matrix[row, col + 1]
                            && matrix[row, col] == matrix[row + 1, col + 1]
                            && matrix[row, col] == matrix[row + 1, col])
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}

