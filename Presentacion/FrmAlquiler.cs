using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmAlquiler : Form
    {
        servicioCliente servicioCliente;
        servicioVehiculo servicioVehiculo;
        servicioAlquiler servicioAlquiler;
        public FrmAlquiler()
        {
            InitializeComponent();
            servicioCliente = new servicioCliente();
            servicioVehiculo = new servicioVehiculo();
            servicioAlquiler = new servicioAlquiler();
        }

        void ver2(Vehiculo veh)
        {
            if (veh == null)
            {
                return;
            }
            textBox1.Text = veh.Marca;
            KilometrajeActualTxt.Text = veh.KilometrajeActual.ToString(); 
        }
        void ver(Cliente cliente)
        {
            if (cliente == null)
            {
                return;
            }
            TextNombre.Text = cliente.Nombre;
            TextTipoid.Text = cliente.TipoCliente;


        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var respuesta = servicioCliente.BuscarPorid(TextCedula.Text);
            ver(respuesta.Cliente);
        }

        private void BtnBuscarPlaca_Click(object sender, EventArgs e)
        {
            var respuesta = servicioVehiculo.BuscarPorid(PlacaTxt.Text);
            ver2(respuesta.Vehiculo);
        }
        
        private Alquiler CrearAlquiler()
        {
            Dtp1.CustomFormat = ("yyyy-MM-dd");
            Dtp2.CustomFormat = ("yyyy/MM/dd");
            int aux = (int.Parse(KmRecepcionTxt.Text) - int.Parse(KilometrajeActualTxt.Text));
            double Total1 = double.Parse(ValorTxt.Text) * aux;
            double Descuento = double.Parse(DescuentoTxt.Text) / 100;
            Descuento = Descuento * Total1;
            Total1 = Total1 - Descuento;
            DateTime nuevoFormato = Dtp1.Value;
            DateTime nuevoFormato2 = Dtp2.Value;
            int KmEntrega = int.Parse(KilometrajeActualTxt.Text);
            int KmRecepcion = int.Parse(KmRecepcionTxt.Text);
            double Valor = double.Parse(ValorTxt.Text);
            Alquiler alquiler = new Alquiler
            {
                IdCliente = TextCedula.Text,
                Placa = PlacaTxt.Text,
                FechaEntrega = nuevoFormato,
                FechaRecepcion = (nuevoFormato2),
                KmEntrega = KmEntrega,
                KmRecepcion = KmRecepcion,
                KmRecorridos = aux,
                ValorKm = Valor,
                Descuento = Descuento,
                Total = Total1
            };
            textBox6.Text = alquiler.Total.ToString();

            return alquiler;
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string message = servicioAlquiler.Guardar(CrearAlquiler());
            
            MessageBox.Show(message);
        }

        private void FrmAlquiler_Load(object sender, EventArgs e)
        {

        }

        private void Dtp1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KmRecepcionTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
