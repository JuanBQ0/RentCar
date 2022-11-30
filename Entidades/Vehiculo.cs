using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {

        public string PlacaVehiculo { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int KilometrajeActual { get; set; }
        public Vehiculo()
        {

        }

        public Vehiculo(string placaVehiculo, string marca, string color, int kilometrajeActual)
        {
            PlacaVehiculo = placaVehiculo;
            Marca = marca;
            Color = color;
            KilometrajeActual = kilometrajeActual;
        }

  
    }
}
