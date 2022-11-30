using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using DatosDAO;

namespace Datos
  
{
    public class RepositorioClientes : ConexionBD, DatosDAO.ICRUD<Cliente>
    {
        public string Actualizar(Cliente obj)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    AbrirConnexion();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_CLIENTES.sp_modificar_c";
                    Comando.Parameters.Add("@idc", OracleDbType.Varchar2).Value = obj.IDC;
                    Comando.Parameters.Add("@nomb", OracleDbType.Varchar2).Value = obj.Nombre;
                    Comando.Parameters.Add("@tipocliente", OracleDbType.Varchar2).Value = obj.TipoCliente;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "se actualizo el registro con id: " + obj.IDC;
                    CerrarConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

       

        public string Eliminar(Cliente obj)
        {
            try
            {
                AbrirConnexion();
                using (var Comando = conexion.CreateCommand())
                {
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_CLIENTES.sp_eliminar_c";
                    Comando.Parameters.Add("@ced", OracleDbType.Varchar2).Value = obj.IDC;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "cliente con id = " + obj.IDC + " eliminado correctamente";
                    AbrirConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

        public string Insertar(Cliente obj)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    conexion.Open();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "GESTION_CLIENTES.sp_guardar_c";
                    Comando.Parameters.Add("@idc", OracleDbType.Varchar2).Value = obj.IDC;
                    Comando.Parameters.Add("@nomb", OracleDbType.Varchar2).Value = obj.Nombre;
                    Comando.Parameters.Add("@tipocliente", OracleDbType.Varchar2).Value = obj.TipoCliente;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "Datos guardados correctamente";
                    conexion.Close();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }

        public Vehiculo Buscar_Placa(string placa)
        {
            try
            {
                string _sql = string.Format("select * from Vehiculos where Placa like '{0}%'", placa);
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var vehiculo = new Vehiculo(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                CerrarConnexion();
                return vehiculo;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public Cliente Buscarcedula(string condicion)
        {
            try
            {
                string _sql = string.Format("select * from clientes where idcliente ='{0}'", condicion);
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var cliente = new Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                CerrarConnexion();
                return cliente;
            }
            catch (Exception ex)
            {

                return null;
            }

        }



        public List<Cliente> Buscar_ID(string condicion)
        {

            string _sql = string.Format("select * from clientes where IdCliente like '{0}%' or nombres like '{1}%'", condicion,condicion);
            DataTable tabla = new DataTable("Clientes");

            OracleDataAdapter command = new OracleDataAdapter(_sql, conexion);
            command.Fill(tabla);
            List<Cliente> lista = new List<Cliente>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;

        }

        public Cliente BuscarID(string id)
        {
            try
            {
                string _sql = string.Format("select * from clientes where IdCliente='{0}'", id);
                var cmd = new OracleCommand(_sql, conexion);
                AbrirConnexion();
                var reader = cmd.ExecuteReader();
                reader.Read();
                var cliente = new Cliente(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                CerrarConnexion();
                return cliente;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public List<Cliente> Todos(string condicion)
        {

            OracleCommand comando = new OracleCommand("GESTION_CLIENTES.sp_consultar_c", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("consultar", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            CerrarConnexion();

            List<Cliente> lista = new List<Cliente>();
            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }

            return lista;
        }

       

        Cliente map(DataRow fila)
        {
            Cliente cliente = new Cliente();
            cliente.IDC = (string)fila[0];
            cliente.Nombre = (string)fila[1];
            cliente.TipoCliente = (string)fila[2];
            return cliente;
        }
    }
}