using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
namespace Logica
{
    public class ServicioVehiculo
    {
        RepositorioVehiculos repositoriovehiculos = new RepositorioVehiculos();
        List<Vehiculo> lista = new List<Vehiculo>();

        public string Guardar(Vehiculo vehiculo)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositoriovehiculos.BuscarPlaca(vehiculo.PlacaVehiculo) == null)
                {
                    mensaje = repositoriovehiculos.Insertar(vehiculo);
                    return mensaje;

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }

        //private void Actualizar()
        //{
        //    clientes = repositorioClientes.ConsultarTodos();
        //}
        //public string BuscarPlaca(string placa)
        //{
        //    if (repositoriovehiculos.BuscarPlaca == placa)
        //    {

        //    }
        //    return clientes;
        //}

        public Vehiculo Buscar(string placa)
        {

            foreach (var item in lista)
            {
                if (item.PlacaVehiculo == placa)
                {
                    return item;
                }

            }
            return null;

        }

        public string Eliminar(Vehiculo vehiculo)
        {
            string mensaje = string.Empty;
            if (repositoriovehiculos.BuscarPlaca(vehiculo.PlacaVehiculo) == null)
            {
                mensaje = repositoriovehiculos.Eliminar(vehiculo);
                return mensaje;

            }
            return mensaje;
        }
        public string Actualizar(string placa)
        {
            Vehiculo vehiculo = Buscar(placa);
            if (vehiculo == null)
            {
                return Guardar(vehiculo);

            }
            else
            {
                vehiculo.PlacaVehiculo = vehiculo.PlacaVehiculo;
                return repositoriovehiculos.Actualizar(vehiculo);
            }


        }



    }

}
