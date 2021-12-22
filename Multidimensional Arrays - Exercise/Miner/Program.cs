using System;
using System.Data;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[,] matrix = new string[n, n];

            int startingRow = 0;
            int startingCol = 0;
            int coalCounter = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] elements = Console.ReadLine()
                    .Split();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elements[j];

                    if (matrix[i, j] == "s")
                    {
                        startingRow = i;
                        startingCol = j;
                    }
                    else if (matrix[i, j] == "c")
                    {
                        coalCounter++;
                    }
                }
            }

            int coalCollected = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i] == "up")
                {
                    startingRow--;
                    if (startingRow < 0)
                    {
                        startingRow++;
                    }
                }
                else if (commands[i] == "down")
                {
                    startingRow++;
                    if (startingRow >= matrix.GetLength(0))
                    {
                        startingRow--;
                    }
                }
                else if (commands[i] == "left")
                {
                    startingCol--;
                    if (startingCol < 0)
                    {
                        startingCol++;
                    }
                }
                else if (commands[i] == "right")
                {
                    startingCol++;
                    if (startingCol >= matrix.GetLength(1))
                    {
                        startingCol--;
                    }
                }

                if (matrix[startingRow, startingCol] == "c")
                {
                    coalCollected++;
                    coalCounter--;
                    matrix[startingRow, startingCol] = "*";
                    if (coalCounter <= 0)
                    {
                        Console.WriteLine($"You collected all coals! ({startingRow}, {startingCol})");
                        return;
                    }
                }
                else if (matrix[startingRow, startingCol] == "e")
                {
                    Console.WriteLine($"Game over! ({startingRow}, {startingCol})");
                    return;
                }
            }

            Console.WriteLine($"{coalCounter} coals left. ({startingRow}, {startingCol})");
        }
    }
}
