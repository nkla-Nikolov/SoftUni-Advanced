using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            for (int i = 0; i < sizes[0] + sizes[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < sizes[0])
                {
                    first.Add(number);
                }
                else
                {
                    second.Add(number);
                }
            }
            // Can use INTERSECT METHOD also!
            Console.WriteLine(string.Join(" ", first.Where(x => second.Contains(x))));
        }
    }
}
