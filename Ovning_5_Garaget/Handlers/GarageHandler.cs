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

            return _garage.GetVehicles(); // returnerar en array från garagets metod (som i sig är en kopia av den riktiga arrayen)
        }

        public IVehicle? FindByRegNumber(string regNumber)
        {
           return _garage.FindByRegNumber(regNumber); // anropar metoden i garaget och returnerar svaret
        }


        public int Count => _garage.Count; // returnerar antalet, vi ropar på och returnerar direkt garagets count-property

        public int Capacity => _garage.Capacity; // returnerar totala storleken, vi ropar på och returnerar direkt garagets capacity-property


        // skriv ut hur många av varje typ
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


        // Sök på färg
        public IVehicle[] SearchByColor(string color)
        {
            // Loop 1: räkna träffar för att bestämma storleken på arrayen
            int count = 0;
            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                    count++;
            }

            // Loop 2: fyll arrayen 
            var result = new IVehicle[count];
            int index = 0;
            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle.Color.Equals(color, StringComparison.OrdinalIgnoreCase))
                {
                    result[index] = vehicle;
                    index++;
                }
            }

            return result;
        }



        // Sök på hjul
        public IVehicle[] SearchByWheels(int wheels)
        {
            // Loop 1: räkna träffar för att bestämma storleken på arrayen
            int count = 0;
            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle.Wheels == wheels)
                {
                    count++;
                }
                    
            }

            // Loop 2: fyll arrayen 
            var result = new IVehicle[count];
            int index = 0;
            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle.Wheels == wheels)
                {
                    result[index] = vehicle;
                    index++;
                }
            }

            return result;
        }

        // sök på cylindervolym
/*        public IVehicle[] SearchByCylinderVolume(int cylinderVolume)
        {
            // Loop 1: räkna träffar för att bestämma storleken på arrayen
            int count = 0;
            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle.Wheels == cylinderVolume)
                {
                    count++;
                }

            }

            // Loop 2: fyll arrayen 
            var result = new IVehicle[count];
            int index = 0;
            foreach (var vehicle in GetAllVehicles())
            {
                if (vehicle. == cylinderVolume)
                {
                    result[index] = vehicle;
                    index++;
                }
            }

            return result;
        }*/

    }
}


