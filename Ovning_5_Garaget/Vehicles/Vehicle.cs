using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        public string RegNumber { get; }
        public string Color { get; }
        public int Wheels { get; }
        public string Brand { get; }


        protected Vehicle( string regNumber, string color, int wheels, string brand)
        {
            RegNumber = regNumber.ToUpper();    // gör sökningen enklare senare
            Color = color;
            Wheels = wheels;
            Brand = brand;
        }

        public override string ToString() =>
    $"{GetType().Name} {RegNumber}, {Brand}, {Color}, {Wheels} hjul";



    }
}
