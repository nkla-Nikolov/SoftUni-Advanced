using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            string[] separator = new string[2] {" -> ", ","};

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] typeClothes = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string color = typeClothes[0];

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < typeClothes.Length; j++)
                {
                    if (!clothes[color].ContainsKey(typeClothes[j]))
                    {
                        clothes[color].Add(typeClothes[j], 0);
                    }

                    clothes[color][typeClothes[j]]++;
                }
            }

            string[] clothesToLookFor = Console.ReadLine().Split();
            string searchedColor = clothesToLookFor[0];
            string searchedType = clothesToLookFor[1];


            foreach (var cloth in clothes)
            {
                Console.WriteLine($"{cloth.Key} clothes:");

                foreach (var dress in cloth.Value)
                {
                    if (cloth.Key == searchedColor)
                    {
                        if (dress.Key == searchedType)
                        {
                            Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
                            continue;
                        }
                    }
                    Console.WriteLine($"* {dress.Key} - {dress.Value}");
                }
            }
        }
    }
}
