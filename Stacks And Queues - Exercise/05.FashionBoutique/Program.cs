using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int sum = 0;
            int rack = 1;

            while (clothes.Count > 0)
            {
                if ((sum + clothes.Peek()) > capacity)
                {
                    rack++;
                    sum = 0;
                }

                sum += clothes.Pop();
            }

            Console.WriteLine(rack);

        }
    }
}
