﻿using System;
using System.Linq;

namespace AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x * 1.20)
                .ToArray();

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num:f2}");
            }
        }
    }
}
