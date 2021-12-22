using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> addCommand = x => x.Insert(0, "Sir ");

            var names = Console.ReadLine()
                .Split(" ")
                .Select(addCommand)
                .ToArray();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
