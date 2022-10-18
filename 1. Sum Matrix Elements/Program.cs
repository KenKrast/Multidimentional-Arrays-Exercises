using System;

namespace _1._Sum_Matrix_Elements
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
                string[] rowData = Console.ReadLine().Split(",");
                for (int j = 0; j < cols; j++)
                {
                    matrix[i,j] = int.Parse(rowData[j]);
                }

            }
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i,j];
                    //Console.WriteLine($"{matrix[i,j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
