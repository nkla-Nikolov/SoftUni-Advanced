using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                
                Car currentCar = new Car(arguments[0], double.Parse(arguments[1]), 
                    double.Parse(arguments[2]));

                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split();
                string model = commandArgs[1];
                double distance = double.Parse(commandArgs[2]);

                int index = cars.FindIndex(x => x.Model == model);
                cars[index].Drive(distance);

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
