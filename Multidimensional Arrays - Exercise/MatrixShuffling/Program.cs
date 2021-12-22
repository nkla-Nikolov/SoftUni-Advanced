using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] elements = Console.ReadLine()
                    .Split();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];
                }
            }

            string command = Console.ReadLine();

            while (command.ToUpper() != "END")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0].ToLower() != "swap" || commandArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                int row1 = int.Parse(commandArgs[1]);
                int col1 = int.Parse(commandArgs[2]);
                int row2 = int.Parse(commandArgs[3]);
                int col2 = int.Parse(commandArgs[4]);

                if ((!Validator(matrix, row1, col1, row2, col2)))
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine();
                    continue;
                }

                string temp = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = temp;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                    Console.WriteLine();
                }

                command = Console.ReadLine();
            }
        }

        public static bool Validator(string[,] matrix, int row1, int col1, int row2, int col2)
        {
            if (row1 < 0 || col1 < 0 || row1 >= matrix.GetLength(0) || col1 >= matrix.GetLength(1)
                || row2 < 0 || col2 < 0 || row2 >= matrix.GetLength(0) || col2 >= matrix.GetLength(1))
            {
                return false;
            }
            return true;
        }
    }
}
