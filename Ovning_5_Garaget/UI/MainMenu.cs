using Ovning_5_Garaget.Handlers;
using Ovning_5_Garaget.Vehicles;

namespace Ovning_5_Garaget.UI
{
    public class MainMenu
    {
        private GarageHandler _handler;

        public MainMenu()
        {
            // Tillfälligt 10 platser, byts mot användarens input när input-hjälparen finns
            _handler = new GarageHandler(10);
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                ConsoleOutput.WriteHeader($"=== Garaget ({_handler.Count}/{_handler.Capacity} platser) ===");
                Console.WriteLine();
                Console.WriteLine("1. Lista alla fordon");
                Console.WriteLine("2. Lista fordonstyper och antal");
                Console.WriteLine("3. Parkera fordon");
                Console.WriteLine("4. Hämta ut fordon");
                Console.WriteLine("5. Hitta fordon via regnummer");
                Console.WriteLine("6. Sök fordon");
                Console.WriteLine("7. Fyll garaget med testfordon");
                Console.WriteLine("8. Skapa nytt garage");
                Console.WriteLine("0. Avsluta");
                Console.WriteLine();
                Console.Write("Välj (0-8): ");

                string input = Console.ReadLine() ?? "";
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        ListAllVehicles();
                        ConsoleOutput.Pause();
                        break;

                    case "2":
                        ListVehicleTypes();
                        ConsoleOutput.Pause();
                        break;

                    case "3":
                        ParkVehicle();
                        ConsoleOutput.Pause();
                        break;

                    case "4":
                        RemoveVehicle();
                        ConsoleOutput.Pause();
                        break;

                    case "5":
                        FindVehicle();
                        ConsoleOutput.Pause();
                        break;

                    case "6":
                        SearchVehicles();
                        ConsoleOutput.Pause();
                        break;

                    case "7":
                        PopulateGarage();
                        ConsoleOutput.Pause();
                        break;

                    case "8":
                        CreateNewGarage();
                        ConsoleOutput.Pause();
                        break;

                    case "0":
                        isRunning = false;
                        ConsoleOutput.WriteSuccess("Hej då!");
                        break;

                    default:
                        ConsoleOutput.WriteError("Ogiltigt val, försök igen.");
                        ConsoleOutput.Pause();
                        break;
                }
            }
        }

        // Privata metoder, en per menyval inklusive färgklassen

        private void ListAllVehicles()
        {
            ConsoleOutput.WriteHeader("Alla parkerade fordon:");

            var vehicles = _handler.GetAllVehicles();

            if (vehicles.Length == 0)
            {
                ConsoleOutput.WriteWarning("Garaget är tomt.");
                return;
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        private void ListVehicleTypes()
        {
            ConsoleOutput.WriteHeader("Alla fordonstyper i garaget:");

            var typeCounts = _handler.GetTypeCounts();

            if (typeCounts.Length == 0)
            {
                ConsoleOutput.WriteWarning("Garaget är tomt.");
                return;
            }

            foreach (var typeCount in typeCounts)
            {
                Console.WriteLine($"{typeCount.TypeName}: {typeCount.Count}");
            }

        }

        private void ParkVehicle()
        {
        }

        private void RemoveVehicle()
        {
        }

        private void FindVehicle()
        {
            ConsoleOutput.WriteHeader("Leta efter fordon baserat på regnummer");
            string regNumber = ConsoleInput.ReadRegNumber("Ange regnummer: ");
        }

        private void SearchVehicles()
        {
        }

        private void PopulateGarage()
        {
            ConsoleOutput.WriteHeader("Fyller garaget med testfordon");

            // En array med färdiga fordon. Måsvingarna fyller den direkt vid skapandet.
            var vehicles = new IVehicle[]
            {
                new Car("ABC123", "Röd", 4, "Volvo", "Bensin", CarType.Kombi),
                new Car("ABC321", "Lila", 4, "Ford", "Bensin", CarType.Sedan),
                new Car("ATR123", "Vit", 4, "Tesla", "El", CarType.Suv),
                new Car("PPC123", "Röd", 4, "SAAB", "Diesel", CarType.Cab),
                new Car("WKA727", "Svart", 4, "Volvo", "Bensin", CarType.Sedan),
                new Bus("BUS001", "Gul", 6, "Scania", 50),
                new Bus("BSS001", "Blå", 10, "Volvo", 50),
                new Motorcycle("EXC500", "Orange", 2, "KTM", 500, MotorcycleType.Enduro),
                new Boat("BTA125", "Vit", 0, "Flipper", 12.5),
                new Airplane("FLY747", "Vit", 18, "Boeing", 4)
            };

            // Försök parkera varje fordon, räkna hur många som lyckades
            int parked = 0;
            foreach (var vehicle in vehicles)
            {
                if (_handler.Park(vehicle))
                {
                    parked++;
                }
            }

            ConsoleOutput.WriteSuccess($"{parked} fordon parkerades.");

            // Om inte alla fick plats
            if (parked < vehicles.Length)
            {
                ConsoleOutput.WriteWarning($"{vehicles.Length - parked} fordon kunde inte parkeras (garaget är fullt eller regnumret finns redan).");
            }
        }

        private void CreateNewGarage()
        {
        }
    }
}