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
    }
}


