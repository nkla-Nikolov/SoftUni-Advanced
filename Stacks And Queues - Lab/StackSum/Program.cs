using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackArr = new Stack<int>(arr);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "add")
                {
                    stackArr.Push(int.Parse(commandArgs[1]));
                    stackArr.Push(int.Parse(commandArgs[2]));
                }
                else
                {
                    int count = int.Parse(commandArgs[1]);

                    if (stackArr.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackArr.Pop();
                        }
                    }
                }


                command = Console.ReadLine().ToLower();
            }

            int sum = stackArr.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
