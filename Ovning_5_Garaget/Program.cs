using Ovning_5_Garaget.Garages;
using Ovning_5_Garaget.Handlers;
using Ovning_5_Garaget.Vehicles;


namespace Ovning_5_Garaget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var handler = new GarageHandler(10);

            handler.Park(new Car("ABC123", "Röd", 4, "Volvo", "Bensin", CarType.Kombi));
            handler.Park(new Bus("BUS001", "Gul", 6, "Scania", 50));
            handler.Park(new Car("ABC321", "Lila", 4, "Ford", "Bensin", CarType.Sedan));
            handler.Park(new Bus("BSS001", "Blå", 10, "Volvo", 50));
            handler.Park(new Car("ATR123", "Vit", 4, "Tesla", "El", CarType.Suv));
            handler.Park(new Bus("BUS221", "Orange", 6, "KIA", 50));
            handler.Park(new Car("PPC123", "Grå", 4, "SAAB", "Diesel", CarType.Cab));
            handler.Park(new Car("WKA727", "Svart", 4, "Volvo", "Bensin", CarType.Sedan));


            // skriv ut alla fordon
            foreach (var vehicle in handler.GetAllVehicles())
            {
                Console.WriteLine(vehicle);
            }


            Console.Write("Sök regnummer: ");
            string input = Console.ReadLine() ?? "";

            var found = handler.FindByRegNumber(input);

            if (found is null)
            {
                Console.WriteLine("Inget fordon hittades.");
            }
            else
            {
                Console.WriteLine(found);
            }
        }
    }
}
