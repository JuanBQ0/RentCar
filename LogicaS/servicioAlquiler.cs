using Datos;
using Entidades;
using System;
using System.Collections.Generic;

namespace Logica
{
    public class servicioAlquiler
    {
        AlquilerRepository repositorioAlquiler = new AlquilerRepository();
        List<Alquiler> lista = new List<Alquiler>();

        public string Guardar(Alquiler alquiler)
        {
            string mensaje = string.Empty;
            try
            {
                mensaje = repositorioAlquiler.Insertar(alquiler);
                return mensaje;

            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
        public Alquiler Buscar(int id)
        {
            foreach (var item in lista)
            {
                if (item.IdAlquiler == id)
                {
                    return item;
                }

            }
            return null;

        }
    }
}
