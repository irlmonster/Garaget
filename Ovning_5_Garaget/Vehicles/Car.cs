using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public class Car : Vehicle
    {
        public string FuelType { get; }
        public CarType Type { get; }

        public Car(string regNumber, string color, int wheels, string brand, string fuelType, CarType type) : base(regNumber, color, wheels, brand)
        {
            FuelType = fuelType;
            Type = type;
        }

        public override string ToString() => $"{base.ToString()}, {Type}, bränsle: {FuelType}";
    }
}
