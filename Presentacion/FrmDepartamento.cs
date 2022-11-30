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
using Entidades;
using Logica;

namespace Presentacion
{
    public partial class FrmDepartamento : Form
    {
        public FrmDepartamento()
        {


            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux = int.Parse(textBox1.Text.ToString());
            string aux2 = textBox2.Text.ToString();
            var departamento = new Departamento(aux, aux2);
            Insertar(departamento);
        }
        void Insertar(Departamento departamento)
        {
            MessageBox.Show(new servicioDep().Guardar(departamento));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
