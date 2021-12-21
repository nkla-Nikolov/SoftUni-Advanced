using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int numsToRemove = input[1];
            int numX = input[2];

            for (int i = 0; i < numsToRemove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(numX))
            {
                Console.WriteLine("true");
                return;
            }

            if (queue.Count >= 1)
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
