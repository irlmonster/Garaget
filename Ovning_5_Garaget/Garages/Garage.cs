using Ovning_5_Garaget.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ovning_5_Garaget.Garages
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private readonly T?[] _vehicles;

        public int Capacity => _vehicles.Length;
        public int Count { get; private set; }
        public bool IsFull => Count >= Capacity;

        public Garage (int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(capacity), "Kapaciteten måste vara större än 0.");
            }

            _vehicles = new T?[capacity];
        }

        public bool Park(T vehicle)
        {
            if (IsFull) return false;
            if (this.Any(v => v.RegNumber == vehicle.RegNumber)) return false;

            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] is null)
                {
                    _vehicles[i] = vehicle;
                    Count++;
                    return true;
                }
            }
            return false;
        }


        public bool Remove(string regNumber)
        {
            for (int i = 0; i < _vehicles.Length; i++)
            {
                if (_vehicles[i] is not null &&
                    _vehicles[i]!.RegNumber.Equals(regNumber, StringComparison.OrdinalIgnoreCase))
                {
                    _vehicles[i] = default;
                    Count--;
                    return true;
                }
            }
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in _vehicles)
            {
                if (vehicle is not null)
                    yield return vehicle;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
