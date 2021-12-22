using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = number => number % 2 == 0;
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            List<int> numbers = new List<int>();

            for (int i = sizes[0]; i <= sizes[1]; i++)
            {
                numbers.Add(i);
            }

            if (command == "even")
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => isEven(x))));
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers.Where(x => !isEven(x))));
            }
        }
    }
}
