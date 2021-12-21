using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int availableFood = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(input);
            int max = orders.Max();

            while (orders.Count > 0)
            {
                if (availableFood - orders.Peek() < 0 && orders.Count != 0)
                {
                    Console.WriteLine(max);
                    Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
                    return;
                }

                availableFood -= orders.Dequeue();
            }

            Console.WriteLine(max);
            Console.WriteLine("Orders complete");
        }
    }
}
