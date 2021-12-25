using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> vehicles = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                List<Tire> tires = new List<Tire>();

                for (int j = 5; j < input.Length; j += 2)
                {
                    Tire currentTire = new Tire(int.Parse(input[j + 1]), double.Parse(input[j]));
                    tires.Add(currentTire);
                }

                Car car = new Car(model, engine, cargo, tires);
                vehicles.Add(car);
            }

            string typeOfCargo = Console.ReadLine();

            if (typeOfCargo == "fragile")
            {
                foreach (var car in vehicles.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (typeOfCargo == "flammable")
            {
                foreach (var car in vehicles.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
