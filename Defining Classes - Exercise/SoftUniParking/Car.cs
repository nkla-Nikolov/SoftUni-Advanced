using System;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string plate)
        {
            Make = make;
            Model = model;
            HorsePower = horsePower;
            RegistrationNumber = plate;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            return
                $"Make: {Make}\r\nModel: {Model}\r\nHorsePower: {HorsePower}\r\nRegistrationNumber: {RegistrationNumber}";
        }
    }
}
