using System;
using System.Collections.Generic;
using System.Linq;

namespace ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = input => Console.WriteLine(input);

            Console.ReadLine().Split(" ").ToList().ForEach(print);
        }
    }
}
