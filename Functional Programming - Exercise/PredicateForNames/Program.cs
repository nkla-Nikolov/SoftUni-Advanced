using System;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split();

            Func<string, int, bool> func = (name, length) => name.Length <= length;

            foreach (var name in names)
            {
                if (func(name, n))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
