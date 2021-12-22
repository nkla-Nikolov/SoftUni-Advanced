using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine().ToUpper();
            HashSet<string> set = new HashSet<string>();

            while (command != "END")
            {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("IN"))
                {
                    set.Add(tokens[1]);
                }
                else
                {
                    set.Remove(tokens[1]);
                }
                command = Console.ReadLine().ToUpper();
            }

            if (set.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var car in set)
            {
                Console.WriteLine(car);
            }
        }
    }
}
