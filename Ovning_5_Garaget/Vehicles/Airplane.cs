using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Vehicles
{
    public class Airplane : Vehicle
    {

        public int NumberPfEngines{ get; }

        public Airplane(string regNumber, string color, int wheels, string brand, int numberPfEngines) : base(regNumber, color, wheels, brand)
        {
            NumberPfEngines = numberPfEngines;
        }

        public override string ToString() => $"{base.ToString()}, antal motorer: {NumberPfEngines}";



    }
}
