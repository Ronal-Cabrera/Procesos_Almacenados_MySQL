using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class MostrarConsultas : Form
    {
        public MostrarConsultas()
        {
            InitializeComponent();
        }
        ConexcionBD conectar = new ConexcionBD();

        void buscar(string query)
        {
            try
            {
                conectar.inicioConec();
                MySqlCommand comando = new MySqlCommand(query, conectar.conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable table = new DataTable();
                adaptador.Fill(table);
                dataGridView1.DataSource = table;
                conectar.inicioDeconec();
                this.label2.Text = "Busqueda realizada con exito";
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "call bd.Consulta1();";
            buscar(query);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "call bd.Consulta2();";
            buscar(query);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "call bd.Consulta3();";
            buscar(query);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string query = "call bd.Consulta4();";
            buscar(query);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = "call bd.Consulta5();";
            buscar(query);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
