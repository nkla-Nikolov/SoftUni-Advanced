using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] dividibleNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] allNumbers = Enumerable.Range(1, n).ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            foreach (var currentDividibleNumber in dividibleNums)
            {
                predicates.Add(x => x % currentDividibleNumber == 0);
            }

            foreach (var currentNumber in allNumbers)
            {
                bool isDividible = true;

                foreach (var predicate in predicates)
                {
                    if (!predicate(currentNumber))
                    {
                        isDividible = false;
                        break;
                    }
                }

                if (isDividible)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}
