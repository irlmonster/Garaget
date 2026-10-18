using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public class Bus : Vehicle
    {
        public int NumberOfSeats { get; }

        public Bus (string regNumber, string color, int wheels, string brand, int numberOfSeats) : base (regNumber, color, wheels, brand)
        {
            NumberOfSeats = numberOfSeats;
        }


        public override string ToString() => $"{base.ToString()}, antal säten: {NumberOfSeats}";
    }
}
