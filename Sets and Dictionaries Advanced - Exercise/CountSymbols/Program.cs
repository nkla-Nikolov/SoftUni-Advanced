using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> counter = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!counter.ContainsKey(text[i]))
                {
                    counter.Add(text[i], 0);
                }

                counter[text[i]]++;
            }

            foreach (var symbol in counter.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
