using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public class Boat : Vehicle
    {
        public double Length;

        public Boat(string regNumber, string color, int wheels, string brand, double length) : base(regNumber, color, wheels, brand)
        {
            Length = length;
        }

        public override string ToString() => $"{base.ToString()}, längd: {Length}";
    }
}
