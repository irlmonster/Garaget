using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public class Airplane : Vehicle
    {

        public int NumberOfEngines{ get; }

        public Airplane(string regNumber, string color, int wheels, string brand, int numberOfEngines) : base(regNumber, color, wheels, brand)
        {
            NumberOfEngines = numberOfEngines;
        }

        public override string ToString() => $"{base.ToString()}, antal motorer: {NumberOfEngines}";



    }
}
