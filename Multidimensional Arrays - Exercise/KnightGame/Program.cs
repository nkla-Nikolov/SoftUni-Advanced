using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string input = Console.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int removedKnights = 0;


            while (true)
            {
                int maxAttacks = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int currentAttacks = 0;

                        if (matrix[row, col] != 'K')
                        {
                            continue;
                        }

                        if (Validate(matrix, row - 2, col + 1) && matrix[row - 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row - 1, col + 2) && matrix[row - 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row + 1, col + 2) && matrix[row + 1, col + 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row + 2, col + 1) && matrix[row + 2, col + 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row + 2, col - 1) && matrix[row + 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row + 1, col - 2) && matrix[row + 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row - 1, col - 2) && matrix[row - 1, col - 2] == 'K')
                        {
                            currentAttacks++;
                        }
                        if (Validate(matrix, row - 2, col - 1) && matrix[row - 2, col - 1] == 'K')
                        {
                            currentAttacks++;
                        }

                        if (currentAttacks > maxAttacks)
                        {
                            maxAttacks = currentAttacks;
                            knightRow = row;
                            knightCol = col;
                        }

                    }
                }

                if (maxAttacks == 0)
                {
                    Console.WriteLine(removedKnights);
                    break;
                }
                else
                {
                    matrix[knightRow, knightCol] = '0';
                    removedKnights++;
                }
            }
        }

        static bool Validate(char[,] matrix, int row, int col)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
