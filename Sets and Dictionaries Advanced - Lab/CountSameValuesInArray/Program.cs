using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> counter = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!counter.ContainsKey(array[i]))
                {
                    counter.Add(array[i], 0);
                }

                counter[array[i]]++;
            }

            foreach (var count in counter)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }
        }
    }
}
