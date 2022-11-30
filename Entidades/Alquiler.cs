using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alquiler
    {
        public Alquiler(string idCliente, string placa, DateTime fechaEntrega, DateTime fechaRecepcion, double kmEntrega, double kmRecepcion, double kmRecorridos, double valorKm, double descuento, double total)
        {

            IdCliente = idCliente;
            Placa = placa;
            FechaEntrega = fechaEntrega;
            FechaRecepcion = fechaRecepcion;
            KmEntrega = kmEntrega;
            KmRecepcion = kmRecepcion;
            KmRecorridos = kmRecorridos;
            ValorKm = valorKm;
            Descuento = descuento;
            Total = total;
        }

        public int IdAlquiler { get; set; }
        public string IdCliente { get; set; }
        public string Placa { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public double KmEntrega { get; set; }
        public double KmRecepcion { get; set; }
        public double KmRecorridos { get; set; }
        public double ValorKm { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        public Alquiler()
        {

        }


    }
}
