using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] quaries = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (quaries[0] == 1)
                {
                    numbers.Push(quaries[1]);
                }
                else if (quaries[0] == 2)
                {
                    if (numbers.Count >= 1)
                    {
                        numbers.Pop();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (quaries[0] == 3)
                {
                    if (numbers.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (quaries[0] == 4)
                {
                    if (numbers.Count == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
