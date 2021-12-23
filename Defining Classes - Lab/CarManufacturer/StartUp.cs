using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            string input = Console.ReadLine();

            while (input != "No more tires")
            {
                Queue<double> tiresInfo = new Queue<double>(input.Split().Select(double.Parse));
                Tire[] tireSet = new Tire[4];
                int counter = 0;

                while (tiresInfo.Count != 0)
                {
                    int year = (int) tiresInfo.Dequeue();
                    double pressure = tiresInfo.Dequeue();
                    Tire currnTire = new Tire(year, pressure);
                    tireSet[counter] = currnTire;
                    counter++;
                }
                
                tires.Add(tireSet);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Engines done")
            {
                string[] engineInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int hp = int.Parse(engineInfo[0]);
                double cc = double.Parse(engineInfo[1]);

                Engine engine = new Engine(hp, cc);
                engines.Add(engine);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Show special")
            {
                string[] carInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Engine engine = engines[int.Parse(carInfo[5])];
                int tireIdx = int.Parse(carInfo[6]);

                Car currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tires[tireIdx]);
                cars.Add(currentCar);

                input = Console.ReadLine();
            }

            cars = cars.Where(c =>
                c.Year >= 2017 && c.Engine.HorsePower > 330 && c.Tires.Sum(t => t.Pressure) >= 9 &&
                c.Tires.Sum(t => t.Pressure) <= 10).ToList();

            foreach (var car in cars)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
