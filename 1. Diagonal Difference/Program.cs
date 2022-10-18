using System;
using System.Globalization;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {

                    matrix[row, col] = numbers[col];
                }
            }

            int topLeftToBottomRightCorner = 0;
            int bottomLeftToTopRightCorner = 0;

            for (int i = 0, j = size -1; i < size; i++, j--)
            {
                bottomLeftToTopRightCorner += matrix[i, i];
                topLeftToBottomRightCorner += matrix[j, i];
            }
            Console.WriteLine(Math.Abs(topLeftToBottomRightCorner - bottomLeftToTopRightCorner));
        }
    }
}
