using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosDAO;
using Entidades;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class RepositorioVehiculos : ConexionBD, ICRUDVehiculo<Vehiculo>
    {
        public string Actualizar(Vehiculo objs)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    AbrirConnexion();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_VEHICULOS.sp_modificar_v";
                    Comando.Parameters.Add("@plac", OracleDbType.Varchar2).Value = objs.PlacaVehiculo;
                    Comando.Parameters.Add("@marc", OracleDbType.Int32).Value = objs.Marca;
                    Comando.Parameters.Add("@color", OracleDbType.Int32).Value = objs.Color;
                    Comando.Parameters.Add("@kmact", OracleDbType.Int32).Value = objs.KilometrajeActual;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "se actualizo el vehiculo con placa: " + objs.PlacaVehiculo;
                    CerrarConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }


        public Vehiculo BuscarPlaca(string placa)
        {
            try
            {
                string _sql = string.Format("select * from Vehiculos where Placa='{0}'", placa);
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var vehiculo = new Entidades.Vehiculo(reader.GetString(0), reader.GetString(1),reader.GetString(2),reader.GetInt32(3));
                CerrarConnexion();
                return vehiculo;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string Eliminar(Vehiculo objs)
        {
            try
            {
                AbrirConnexion();
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_VEHICULOS.sp_eliminar_v";
                    Comando.Parameters.Add("@plac", OracleDbType.Varchar2).Value = objs.PlacaVehiculo;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "vehiculo con placa = " + objs.PlacaVehiculo + " eliminado correctamente";
                    AbrirConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string Insertar(Vehiculo objs)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_VEHICULOS.sp_guardar_v";
                    Comando.Parameters.Add("@plac", OracleDbType.Varchar2).Value = objs.PlacaVehiculo;
                    Comando.Parameters.Add("@marc", OracleDbType.Int32).Value = objs.Marca;
                    Comando.Parameters.Add("@color", OracleDbType.Int32).Value = objs.Color;
                    Comando.Parameters.Add("@kmact", OracleDbType.Int32).Value = objs.KilometrajeActual;
                    OracleTransaction tx = conexion.BeginTransaction();
                    Comando.ExecuteNonQuery();
                    tx.Commit();
                    Comando.Parameters.Clear();
                    return "Datos guardados correctamente";
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public List<Vehiculo> Buscar_Placafiltro(string condicion)
        {
            string _sql = string.Format("select * from vehiculos where placa like '{0}%'", condicion);
            DataTable tabla = new DataTable("vehiculos");

            OracleDataAdapter command = new OracleDataAdapter(_sql, conexion);
            command.Fill(tabla);
            List<Vehiculo> lista = new List<Vehiculo>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;


        }



        public Vehiculo Buscar_Placa(string condicion)
        {
            try
            {
                string _sql = string.Format("select * from vehiculos where placa ='{0}'", condicion);
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var vehiculo = new Vehiculo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                CerrarConnexion();
                return vehiculo;
            }
            catch (Exception ex)
            {

                return null;
            }
          
        }


        public DataTable cargue_de_colores()
        {
            OracleCommand dt = new OracleCommand("sp_color", conexion);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("color", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }
        public DataTable cargue_de_marca()
        {
            OracleCommand dt = new OracleCommand("sp_marca", conexion);
            dt.CommandType = CommandType.StoredProcedure;
            dt.Parameters.Add("marcas", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = dt;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            return tabla;
        }

        public List<Vehiculo> Todos(string condicion)
        {
            OracleCommand comando = new OracleCommand("GESTION_VEHICULOS.sp_consultar_v", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("consultar", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            CerrarConnexion();

            List<Vehiculo> lista = new List<Vehiculo>();
            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }

            return lista;
        }

        Vehiculo map(DataRow fila)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.PlacaVehiculo = (string)fila[0];
            vehiculo.Marca =Convert.ToString( (decimal)fila[1]);
            vehiculo.Color = Convert.ToString((decimal)fila[2]);
            vehiculo.KilometrajeActual = (Int32)(decimal)fila[3];
            return vehiculo;
        }
    }
}
