using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; }
        public MotorcycleType Type { get; }

        public Motorcycle(string regNumber, string color, int wheels, string brand, int cylinderVolume, MotorcycleType type) : base (regNumber, color, wheels, brand)
        {
            CylinderVolume = cylinderVolume;
            Type = type;
        }


        public override string ToString() =>
            $"{base.ToString()}, {Type}, {CylinderVolume} cc";
    }
}
