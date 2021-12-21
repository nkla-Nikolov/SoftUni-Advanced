using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs =
                new Queue<string>(Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries));

            string command = Console.ReadLine();

            while (songs.Count != 0)
            {
                string[] commandArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (commandArgs[0] == "Add")
                {
                    int index = command.IndexOf(' ');
                    string song = command.Substring(index + 1);

                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (commandArgs[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("No more songs!");
        }
    }
}
