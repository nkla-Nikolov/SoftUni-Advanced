using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> add = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] += 1;
                }

                return numbers;
            };
            Func<int[], int[]> subtract = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] -= 1;
                }

                return numbers;
            };
            Func<int[], int[]> multiply = numbers =>
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] *= 2;
                }

                return numbers;
            };
            Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));


            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command == "add")
                {
                    add(input);
                }
                else if (command == "subtract")
                {
                    subtract(input);
                }
                else if (command == "multiply")
                {
                    multiply(input);
                }
                else if (command == "print")
                {
                    print(input);
                }

                command = Console.ReadLine();
            }
        }
    }
}
