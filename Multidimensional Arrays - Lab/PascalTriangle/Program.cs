using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];

            for (int i = 0; i < jagged.Length; i++)
            {
                jagged[i] = new long[i + 1];
                jagged[i][0] = 1;
                jagged[i][jagged[i].Length - 1] = 1;

                for (int j = 1; j < jagged[i].Length - 1; j++)
                {
                    jagged[i][j] = jagged[i - 1][j - 1] + jagged[i - 1][j];
                }
            }

            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
    }
}
