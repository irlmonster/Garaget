using Ovning_5_Garaget.Garages;
using Ovning_5_Garaget.Vehicles;

namespace Ovning_5_Garaget.Handlers
{
    public class GarageHandler
    {
        private readonly Garage<IVehicle> _garage;

        public GarageHandler(int capacity)
        {
            _garage = new Garage<IVehicle>(capacity);
        }

        public bool Park(IVehicle vehicle)
        {
            return _garage.Park(vehicle); // returnerar true eller false från garagets Park-metod
        }

        public bool Remove(string regNumber)
        {
            return _garage.Remove(regNumber); // returnerar true eller false från garagets Remove-metod
        }

        public IVehicle[] GetAllVehicles()
        {
            return _garage.GetVehicles(); // returnerar en kopia av garagets array
        }

        public IVehicle? FindByRegNumber(string regNumber)
        {
            return _garage.FindByRegNumber(regNumber); // anropar metoden i garaget och returnerar svaret
        }

        public int Count => _garage.Count; // antal parkerade fordon, direkt från garaget

        public int Capacity => _garage.Capacity; // totala antalet platser, direkt från garaget



        // Räknar hur många fordon det finns av en viss typ
        public int CountByType(string typeName)
        {
            int count = 0;

            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle.GetType().Name == typeName)
                {
                    count++;
                }
            }

            return count;
        }

        // Fritextsökning: returnerar alla fordon där något fält matchar söktermen.
        // Varje fordon avgör själv vad som matchar via sin egen Matches-metod.
        public IVehicle[] Search(string searchTerm)
        {
            var term = searchTerm.Trim();

            return Filter(vehicle => vehicle.Matches(term));
        }

        // Sök på färg (skiftlägesokänsligt, strängjämförelse)
        public IVehicle[] SearchByColor(string color)
        {
            return Filter(vehicle => vehicle.Color.Equals(color, StringComparison.OrdinalIgnoreCase));
        }





        // Sök på antal hjul (talsjämförelse, därför ==)
        public IVehicle[] SearchByWheels(int wheels)
        {
            return Filter(vehicle => vehicle.Wheels == wheels);
        }




        // Hjälpmetod: går igenom alla fordon och returnerar de som uppfyller villkoret.
        // Enda stället som vet att vi använder arrayer, byts mot LINQ senare.
        private IVehicle[] Filter(Func<IVehicle, bool> condition)
        {
            // Hämta fordonen en gång, så vi inte skapar en ny kopia per loop
            var vehicles = GetAllVehicles();

            // Loop 1: räkna träffar för att veta hur stor arrayen ska vara
            int count = 0;
            foreach (var vehicle in vehicles)
            {
                if (condition(vehicle))
                {
                    count++;
                }
            }

            // Loop 2: fyll arrayen med träffarna
            var result = new IVehicle[count];
            int index = 0;
            foreach (var vehicle in vehicles)
            {
                if (condition(vehicle))
                {
                    result[index] = vehicle;
                    index++;
                }
            }

            return result;
        }
    }
}