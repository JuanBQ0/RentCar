using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;
using Entidades;
namespace Presentacion
{
    public partial class FrmVehiculo : Form
    {
        private static FrmVehiculo instacias = null;
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        public static FrmVehiculo GetInstancias()
        {
            if (instacias == null || instacias.IsDisposed)
            {
                instacias = new FrmVehiculo();
            }
            return instacias;
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            CargarLista("");
            CargarGrillaVehiculos("");
            cargarcolor();
            cargarmarca();
        }

        void CargarLista(string condicion)
        {
            listavehiculos.DataSource = new RepositorioVehiculos().Todos(condicion);
            listavehiculos.DisplayMember = "Marca";
            listavehiculos.ValueMember = "PlacaVehiculo";
            if (listavehiculos.Items.Count > 0)
            {
                listavehiculos.SelectedIndex = 0;
                listavehiculos.Select();
            }
        }
        void CargarGrillaVehiculos(string condicion)
        {
            grillaVehiculos.DataSource = new RepositorioVehiculos().Todos(condicion);

        }

        private void listavehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string placa = listavehiculos.SelectedValue.ToString();
            Buscar(placa);
        }
        void Buscar(string placa)
        {
            try
            {
                var vehiculo = new RepositorioVehiculos().BuscarPlaca(placa);
                ver(vehiculo);
            }
            catch (Exception)
            {


            }
        }
        void refresh()
        {
            CargarLista("");
            CargarGrillaVehiculos("");
        }

        void ver(Entidades.Vehiculo vehiculo)
        {
            if (vehiculo == null)
            {
                return;
            }
            txtPlaca.Text = vehiculo.PlacaVehiculo;            
            cmbmarca.Text = vehiculo.Marca;
            cmbcolor.Text = vehiculo.Color;
            txtKilometraje.Text =Convert.ToString( vehiculo.KilometrajeActual);
            
        }

        private void grillaVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string placa = grillaVehiculos.Rows[e.RowIndex].Cells[0].Value.ToString();
            Buscar(placa);
            listavehiculos.SelectedIndex = e.RowIndex;
            this.tabControl1.TabPages[0].Show();
        }

        private void txtCondicion_TextChanged(object sender, EventArgs e)
        {
            string condicion = txtCondicion.Text.Trim();
            grillaVehiculos.DataSource = new RepositorioVehiculos().Buscar_Placafiltro(condicion);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtPlaca.Text.Length == 0)
            {
                return;
            }
            Eliminar(new RepositorioVehiculos().BuscarPlaca(txtPlaca.Text));
            refresh();
        }
        void Eliminar(Vehiculo vehiculo)
        {

            MessageBox.Show(new RepositorioVehiculos().Eliminar(vehiculo));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtPlaca.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var vehiculo = new Vehiculo(txtPlaca.Text,Convert.ToString( cmbmarca.SelectedValue),Convert.ToString( cmbcolor.SelectedValue), int.Parse( txtKilometraje.Text));
            Actualizar(vehiculo);
            refresh();
        }
        void Actualizar(Vehiculo vehiculo)
        {
            MessageBox.Show(new servicioVehiculo().Actualizar(vehiculo));
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo(false);
            txtPlaca.Enabled = true;
            txtPlaca.Focus();
        }
        void Nuevo(bool soloLectura)
        {
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    ((TextBox)item).ReadOnly = soloLectura;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var vehiculo = new Vehiculo(txtPlaca.Text, Convert.ToString(cmbmarca.SelectedValue), Convert.ToString(cmbcolor.SelectedValue), int.Parse(txtKilometraje.Text));
            Insertar(vehiculo);
            refresh();
        }
        void Insertar(Vehiculo vehiculo)
        {
            MessageBox.Show(new servicioVehiculo().Guardar(vehiculo));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form mv = new Form();
            this.Close();
        }
        RepositorioVehiculos reposv = new RepositorioVehiculos();
         void cargarcolor()
        {
            cmbcolor.DataSource = reposv.cargue_de_colores();
            cmbcolor.DisplayMember = "nombrecolor";
            cmbcolor.ValueMember = "idcolor";
        }
        void cargarmarca()
        {
            cmbmarca.DataSource = reposv.cargue_de_marca();
            cmbmarca.DisplayMember = "nombremarca";
            cmbmarca.ValueMember = "idmarca";
        }


    }
}
