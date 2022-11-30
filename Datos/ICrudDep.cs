using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface ICrudDep<Departamento>
    {
        string Insertar(Departamento obj);
        Departamento BuscarID(int id);
        List<Departamento> Todos(string obj);
    }
    
}
