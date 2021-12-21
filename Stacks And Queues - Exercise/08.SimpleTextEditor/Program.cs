using System;
using System.Collections.Generic;
using System.Text;

namespace _08.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> stack = new Stack<string>();


            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string[] commandArgs = command.Split();

                if (commandArgs[0] == "1")
                {
                    stack.Push(text.ToString());
                    string textToAppend = commandArgs[1];
                    text.Append(textToAppend);
                }
                else if (commandArgs[0] == "2")
                {
                    stack.Push(text.ToString());
                    int count = int.Parse(commandArgs[1]);
                    text.Remove(text.Length - count, count);
                }
                else if (commandArgs[0] == "3")
                {
                    int index = int.Parse(commandArgs[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else
                {
                    if (text.Length == 0)
                    {
                        text.Append(stack.Pop());
                    }
                    else
                    {
                        text.Replace(text.ToString(), stack.Pop());
                    }
                }
            }
        }
    }
}

