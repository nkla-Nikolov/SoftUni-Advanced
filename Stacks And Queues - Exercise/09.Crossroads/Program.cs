using System;
using System.Collections.Generic;

namespace _09.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            int counter = 0;

            while (command != "END")
            {
                if (command == "green")
                {
                    int green = seconds;
                    int windowsLeft = freeWindow;

                    while (green > 0 && cars.Count > 0)
                    {
                        string car = cars.Dequeue();
                        green -= car.Length;

                        if (green < 0)
                        {
                            windowsLeft += green;
                            if (windowsLeft < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {car[car.Length + windowsLeft]}.");
                                return;
                            }
                        }

                        counter++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
