using System;
using System.Collections.Generic;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> symbols = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                symbols.Push(input[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(symbols.Pop());
            }
        }
    }
}
