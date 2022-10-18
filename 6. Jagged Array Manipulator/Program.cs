using System;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            if (size < 3)
            {
                Console.WriteLine(0);
                return;
            }

            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {
                string chars = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
            int knightsRemoved = 0;
            while (true)
            {
                int countMostAtacking = 0;
                int rowMostAtacking = 0;
                int colMostAtacking = 0;
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int attackedKnights = CountOfAttackeKnights(row, col, size, matrix);
                            if (countMostAtacking < attackedKnights)
                            {
                                countMostAtacking = attackedKnights;
                                rowMostAtacking = row;
                                colMostAtacking = col;
                            }
                        }
                    }
                }
                if (countMostAtacking == 0)
                {
                    break;
                }
                else
                {
                    matrix[rowMostAtacking, colMostAtacking] = '0';
                    knightsRemoved++;
                }
            }
            Console.WriteLine(knightsRemoved);

        }

        static int CountOfAttackeKnights(int row, int col, int size, char[,] matrix)
        {
            int attackedHorses = 0;
            if (IsCellValid(row - 1, col - 2, size))
            {
                if (matrix[row - 1, col - 2] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row + 1, col - 2, size))
            {
                if (matrix[row + 1, col - 2] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row - 1, col + 2, size))
            {
                if (matrix[row - 1, col + 2] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row + 1, col + 2, size))
            {
                if (matrix[row + 1, col + 2] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row - 2, col - 1, size))
            {
                if (matrix[row - 2, col - 1] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row - 2, col + 1, size))
            {
                if (matrix[row - 2, col + 1] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row + 2, col - 1, size))
            {
                if (matrix[row + 2, col - 1] == 'K')
                {
                    attackedHorses++;
                }

            }
            if (IsCellValid(row + 2, col + 1, size))
            {
                if (matrix[row + 2, col + 1] == 'K')
                {
                    attackedHorses++;
                }

            }
            return attackedHorses;

        }
        static bool IsCellValid(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
