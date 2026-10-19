using Ovning_5_Garaget.Garages;
using Ovning_5_Garaget.Vehicles;


namespace Ovning_5_Garaget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var garage = new Garage<IVehicle>(10);

            garage.Park(new Car("ABC123", "Röd", 4, "Volvo", "Bensin", CarType.Kombi));
            garage.Park(new Bus("BUS001", "Gul", 6, "Scania", 50));



            Console.WriteLine($"{garage.Count}/{garage.Capacity} platser.");
        }
    }
}
