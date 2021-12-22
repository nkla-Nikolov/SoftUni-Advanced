using System;
using System.Linq;

namespace CountUpperCaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> func = x => char.IsUpper(x[0]);
            string[] newText = text.Where(func).ToArray();

            foreach (var word in newText)
            {
                Console.WriteLine(word);
            }
        }

    }
}
