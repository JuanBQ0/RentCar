using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Departamento
    {
        public Departamento()
        {
        }

        public Departamento(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
}
