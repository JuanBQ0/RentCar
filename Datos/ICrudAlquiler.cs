using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudAlquiler<Alquiler>
    {
        string Insertar(Alquiler alquiler);
        Alquiler BuscarFactura(int id);
        List<Alquiler> ConsultarTodasFacturas(string alquileres);
    }
}
