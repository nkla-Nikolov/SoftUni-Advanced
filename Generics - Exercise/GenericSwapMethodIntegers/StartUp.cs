using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                box.List.Add(num);
            }

            int[] indexesToSwap = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.SwapIndexes(indexesToSwap[0], indexesToSwap[1]);

            foreach (var number in box.List)
            {
                Console.WriteLine($"{box}: {number}");
            }

        }
    }
}
