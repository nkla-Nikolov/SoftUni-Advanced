using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numbersToRemove = input[1];
            int xNumber = input[2];

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < numbersToRemove; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(xNumber))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                if (stack.Count >= 1)
                {
                    int min = int.MaxValue;
                    for (int i = 0; i < stack.Count; i++)
                    {
                        int currentNum = stack.Pop();
                        if (currentNum < min)
                        {
                            min = currentNum;
                        }
                    }

                    Console.WriteLine(min);
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
