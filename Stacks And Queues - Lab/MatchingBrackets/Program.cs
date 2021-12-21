using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    int lastIndex = indexes.Pop();
                    Console.WriteLine(input.Substring(lastIndex, i - lastIndex + 1));
                }
            }
        }
    }
}
