using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gestionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form gest = new Gestion();
            gest.Show();
        }
        E_Agenda objEntidad = new E_Agenda();
        N_Agenda objNegocio = new N_Agenda();
        private void button1_Click(object sender, EventArgs e)
        {
            E_Agenda categoria = ObtenerCategoriaDesdeInterfaz();
            objNegocio.Insertando(categoria);
            MessageBox.Show("Insertado");
        }
        private E_Agenda ObtenerCategoriaDesdeInterfaz()
        {
            E_Agenda categoria = new E_Agenda();

            categoria.Nombre = textBox1.Text;
            categoria.Apellido = textBox2.Text;
            categoria.Direccion = textBox4.Text;

            categoria.Fecha_Nacimiento = textBox3.Text;

            categoria.Celular = textBox5.Text;

            return categoria;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }


}

