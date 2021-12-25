using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public Parking(int capacity)
        {
            Capacity = capacity;
            Cars = new List<Car>();
        }
        public List<Car> Cars { get => cars; set => cars = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        public int Count => cars.Count;

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count >= capacity)
            {
                return "Parking is full";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                Car carToDelete = cars.First(x => x.RegistrationNumber == registrationNumber);
                cars.Remove(carToDelete);
                return $"Successfully removed {registrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                cars.RemoveAll(x => x.RegistrationNumber == registrationNumber);
            }
        }
    }
}
