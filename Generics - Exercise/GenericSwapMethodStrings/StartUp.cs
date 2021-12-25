using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                box.List.Add(text);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            box.SwapIndexes(indexes[0], indexes[1]);

            foreach (var text in box.List)
            {
                Console.WriteLine($"{box}: {text}");
            }
        }
    }
}
