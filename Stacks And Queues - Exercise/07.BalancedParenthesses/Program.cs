using System;
using System.Collections.Generic;
using System.Reflection;

namespace _07.BalancedParenthesses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> balanced = new Dictionary<char, char>();
            balanced.Add('(', ')');
            balanced.Add('[', ']');
            balanced.Add('{', '}');
            bool isBalanced = true;

            if (input.Length % 2 == 1 || input.Length == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            foreach (var c in input)
            {
                if (balanced.ContainsKey(c))
                {
                    stack.Push(c);
                }
                else
                {
                    char openParanthesis = stack.Pop();
                    if (balanced[openParanthesis] != c)
                    {
                        isBalanced = false;
                    }
                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
