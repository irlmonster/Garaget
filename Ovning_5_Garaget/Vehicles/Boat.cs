namespace Ovning_5_Garaget.Vehicles
{
    public class Boat : Vehicle
    {
        public double Length { get; }

        public Boat(string regNumber, string color, int wheels, string brand, double length) : base(regNumber, color, wheels, brand)
        {
            Length = length;
        }

        public override string ToString() => $"{base.ToString()}, längd: {Length}";
    }
}
