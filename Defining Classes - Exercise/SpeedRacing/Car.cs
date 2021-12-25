using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {
            
        }

        public Car(string model, double distanceTravelled) : this()
        {
            Model = model;
            TravelledDistance = distanceTravelled;
        }
        public Car(string model, double fuelAmount, double fuelConsp) : this()
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConspPerKM = fuelConsp;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConspPerKM { get; set; }
        public double TravelledDistance { get; set; } = 0;


        public void Drive(double distance)
        {

            double fuelConsumed = distance * FuelConspPerKM;

            if (FuelAmount - fuelConsumed >= 0)
            {
                TravelledDistance += distance;
                FuelAmount -= fuelConsumed;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
