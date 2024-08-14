using CapaEntidad;
using CapaNegocio;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class Gestion : Form
    {

        private string ID;
        private bool editar=false;
        public Gestion()
        {
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            
        }

        E_Agenda objEntidad = new E_Agenda();
        N_Agenda objNegocio = new N_Agenda();

        public void acciontabla()
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            E_Agenda categoria = ObtenerCategoriaDesdeInterfaz();
            objNegocio.Modificando(categoria);
            MessageBox.Show("modificado");
        }
        private E_Agenda ObtenerCategoriaDesdeInterfaz()
        {
            E_Agenda categoria = new E_Agenda();
            categoria.ID = Convert.ToInt32(textBox6.Text);
            categoria.Nombre = textBox1.Text;
            categoria.Apellido = textBox2.Text;
            categoria.Direccion = textBox4.Text;

            categoria.Fecha_Nacimiento = textBox3.Text;

            categoria.Celular = textBox5.Text;

            return categoria;                      
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                
                bool esNumero = int.TryParse(textBox6.Text, out int id);

                if (esNumero)
                {
                    
                    E_Agenda registroParaEliminar = new E_Agenda();
                    registroParaEliminar.ID = id;

                   
                    objNegocio.EliminandoRegistro(registroParaEliminar);

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número de ID válido.");
                }
            }
            else
            {
                MessageBox.Show("El campo ID no puede estar vacío.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection coneexion = new SqlConnection("server= EVANGELINE\\SQLEXPRESS; database=Agenda; integrated security= true;");
            coneexion.Open();

            string consulta = "SELECT * FROM Agenda_Electronica";
            SqlDataAdapter adaptar = new SqlDataAdapter(consulta, coneexion);
            DataTable dataTable = new DataTable();
            adaptar.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            SqlConnection coneexion = new SqlConnection("server= EVANGELINE\\SQLEXPRESS; database=Agenda; integrated security= true;");
            coneexion.Open();

            string query = "SELECT * FROM Agenda_Electronica WHERE Id = '" + id + "'";
            SqlCommand comando2 = new SqlCommand(query, coneexion);

            using (SqlDataReader reader = comando2.ExecuteReader())
            {
                if (reader.Read())
                {
                    textBox1.Text = reader["Nombre"].ToString();
                    textBox2.Text = reader["Apellido"].ToString();
                    textBox3.Text = reader["Fecha_nacimiento"].ToString();
                    textBox4.Text = reader["Direccion"].ToString();
                    textBox5.Text = reader["Celular"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el ID proporcionado.");
                }
            }
            coneexion.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void doubleBitmapControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
