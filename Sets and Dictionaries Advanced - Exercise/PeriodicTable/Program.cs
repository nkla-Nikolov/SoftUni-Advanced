using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> table = new SortedSet<string>();
            
            for (int i = 0; i < n; i++)
            {
                string[] elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    string element = elements[j];
                    table.Add(element);
                }
            }
            Console.WriteLine(string.Join(" ", table));
        }
    }
}
