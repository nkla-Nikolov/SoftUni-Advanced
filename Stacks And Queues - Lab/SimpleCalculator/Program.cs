using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> nums = new Stack<string>(input);

            while (nums.Count > 1)
            {
                int a = int.Parse(nums.Pop());
                string op = nums.Pop();
                int b = int.Parse(nums.Pop());

                if (op == "-")
                {
                    nums.Push((a - b).ToString());
                }
                else
                {
                    nums.Push((a + b).ToString());
                }
            }

            Console.WriteLine(nums.Peek());
        }
    }
}
