using System;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sizes = Console.ReadLine().Split(", ");
            int rows = int.Parse(sizes[0]);
            int cols = int.Parse(sizes[1]);
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(rowData[j]);
                }

            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
