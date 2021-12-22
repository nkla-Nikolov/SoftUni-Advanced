using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();
            int n = int.Parse(Console.ReadLine());

            Predicate<int> filter = number => number % n != 0;
            array = array.Where(x => filter(x)).ToList();

            Console.WriteLine(string.Join(" ", array));
        }
    }
}
