using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
//using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Client;

namespace Datos
{
    public class AlquilerRepository : ConexionBD, ICrudAlquiler<Alquiler>
    {
        public Alquiler BuscarFactura(int id)
        {
            throw new NotImplementedException();
        }

        public List<Alquiler> ConsultarTodasFacturas(string condicion)
        {
            string _sql = string.Format("select * from alquileres where IdAlquiler like '{0}%' or idcliente like '{1}%'", condicion, condicion);
            System.Data.DataTable tabla = new DataTable("alquileres");
            OracleDataAdapter adapter = new OracleDataAdapter(_sql, conexion);

            adapter.Fill(tabla);

            List<Alquiler> lista = new List<Alquiler>();

            foreach (var fila in tabla.Rows)
            {

                lista.Add(map((DataRow)fila));
            }
            return lista;

        }
        Alquiler map(DataRow fila)
        {
            Alquiler alquiler = new Alquiler();
            alquiler.IdAlquiler = (int)(decimal)fila[0];
            alquiler.IdCliente = (string)fila[1];
            alquiler.Placa = (string)fila[2];
            alquiler.FechaEntrega = (DateTime)fila[3];
            alquiler.FechaRecepcion = (DateTime)fila[4];
            alquiler.KmEntrega = (int)(decimal)fila[5];
            alquiler.KmRecepcion = (int)(decimal)fila[6];
            alquiler.KmRecorridos = (int)(decimal)fila[7];
            alquiler.ValorKm = (int)(decimal)fila[8];
            alquiler.Descuento = (int)(decimal)fila[9];
            alquiler.Total = (int)(decimal)fila[10];
            return alquiler;
        }

        public string Insertar(Alquiler alquileres)
        {
            try
            {
                using (var Comando = conexion.CreateCommand())
                {
                    AbrirConnexion();
                    Comando.CommandType = System.Data.CommandType.StoredProcedure;
                    Comando.CommandText = "sp_guardar";
                    Comando.Parameters.Add("@plac", OracleDbType.Int32).Value = alquileres.IdAlquiler;
                    Comando.Parameters.Add("@mar", OracleDbType.Varchar2).Value = alquileres.IdCliente;
                    Comando.Parameters.Add("@kilo", OracleDbType.Varchar2).Value = alquileres.Placa;
                    Comando.Parameters.Add("@fechae", OracleDbType.Date).Value = alquileres.FechaEntrega;
                    Comando.Parameters.Add("@fechaen", OracleDbType.Date).Value = alquileres.FechaRecepcion;
                    Comando.Parameters.Add("@kmentre", OracleDbType.Int32).Value = alquileres.KmEntrega;
                    Comando.Parameters.Add("@kmrecep", OracleDbType.Int32).Value = alquileres.KmRecepcion;
                    Comando.Parameters.Add("@kmrecorr", OracleDbType.Int32).Value = alquileres.KmRecorridos;
                    Comando.Parameters.Add("@valorkm", OracleDbType.Int32).Value = alquileres.ValorKm;
                    Comando.Parameters.Add("@descu", OracleDbType.Double).Value = alquileres.Descuento;
                    Comando.Parameters.Add("@total", OracleDbType.Double).Value = alquileres.Total;
                    Comando.ExecuteNonQuery();
                    Comando.Parameters.Clear();
                    return "Datos guardados correctamente";
                    CerrarConnexion();
                }
            }
            catch (Exception e)
            {

                return e.Message;
            }
        }

      
    }
}
