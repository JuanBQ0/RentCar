using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RepositorioDepartamento: ConexionBD, Datos.ICrudDep<Departamento>
    {
        public Departamento BuscarID(string id)
        {
            throw new NotImplementedException();
        }

        public string Insertar(Departamento obj)
        {
            try
            {
                string _sql = string.Format("INSERT INTO Departamento VALUES('" + obj.Codigo + "','" + obj.Nombre + "')");
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                int filas = cmd.ExecuteNonQuery();
                CerrarConnexion();
                if (filas > 0)
                {
                    return "Datos guardados satisfactoriamente";
                }
                return "No se pudo guardar los datos";

            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public Departamento BuscarID(int id)
        {
            try
            {
                string _sql = string.Format("select * from departamento where Codigo ='{0}'", id);
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var Departamento = new Departamento(int.Parse(reader.GetString(0)), reader.GetString(1));
                CerrarConnexion();
                return Departamento;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Departamento> Todos(string condicion)
        {
            string _sql = string.Format("select * from departamento where Codigo like '{0}%'", condicion);
            System.Data.DataTable tabla = new DataTable("departamento");
            OracleDataAdapter adapter = new OracleDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Departamento> lista = new List<Departamento>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;
        }
        Departamento map(DataRow fila)
        {
            Departamento departamento = new Departamento();
            departamento.Codigo = (int)fila[0];
            departamento.Nombre = (string)fila[1];

            return departamento;
        }
    }
}
