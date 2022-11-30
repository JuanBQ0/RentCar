using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class servicioDep
    {
        RepositorioDepartamento departamentoRepository = new RepositorioDepartamento();
        List<Departamento> lista = new List<Departamento>();
        public string Guardar(Departamento departamento)
        {
            string mensaje = string.Empty;
            try
            {

                if (departamentoRepository.BuscarID(departamento.Codigo) == null)
                {
                    mensaje = departamentoRepository.Insertar(departamento);
                    return mensaje;

                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "Error:" + e.Message;
            }
        }
    }
}
