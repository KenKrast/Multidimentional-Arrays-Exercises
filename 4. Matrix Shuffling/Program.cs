using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            string[,] matrix = new string[dimentions[0], dimentions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] strings = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = strings[col];
                }
            }
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (IsVslidCommand(dimentions, tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;
                    PrintMatrix(matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }

        static bool IsVslidCommand(int[] dimentions, string[] tokens)
        {
            return
                tokens[0] == "swap"
                && tokens.Length == 5
                && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < dimentions[0]
                && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < dimentions[1]
                && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < dimentions[0]
                && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[2]) < dimentions[1];

        }
    }
}
