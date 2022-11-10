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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string query = "";
        ConexcionBD conec = new ConexcionBD();
        Consultas consulData = new Consultas();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text != "")
            {
                try
                {
                    if (this.radioButton1.Checked == true)
                    {
                        query = "SELECT codcomunidad,comunidad FROM tablacomunidades where " + this.comboBox1.Text + " = " + this.textBox1.Text + ";";
                    }
                    else if (this.radioButton2.Checked == true)
                    {
                        query = "SELECT codcomunidad,comunidad FROM tablacomunidades where " + this.comboBox1.Text + " != " + this.textBox1.Text + ";";
                    }
                    conec.inicioConec();
                    MySqlCommand comando = new MySqlCommand(query, conec.conexion);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    DataTable table = new DataTable();
                    adaptador.Fill(table);
                    dataGrid.DataSource = table;
                    conec.inicioDeconec();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
        }
        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataGrid.Visible = false;
            this.button3.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.panel4.Visible = true; 
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (this.cambio.Text != "")
            {
                try
                {
                    query = "UPDATE tablacomunidades SET comunidad = '" + this.cambio.Text + "' where codcomunidad = '" + this.codd.Text + "'";
                    consulData.Actualizar(query);
                    btnactualizar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            btnactualizar();
        }
        void btnactualizar()
        {
            this.dataGrid.Visible = true;
            this.button3.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.panel4.Visible = false;
            this.codd.Text = "";
            this.cambio.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.dataGrid.Visible = false;
            this.button3.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.panel6.Visible = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.dataGrid.Visible = false;
            this.button3.Visible = false;
            this.button6.Visible = false;
            this.button7.Visible = false;
            this.panel5.Visible = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text != "")
            {
                try
                {
                    query = "DELETE FROM tablacomunidades where codcomunidad = '" + this.textBox2.Text + "'";
                    consulData.Eliminar(query);

                    btneliminar();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button8_Click(object sender, EventArgs e)
        {
            btneliminar();
        }
        void btneliminar()
        {
            this.dataGrid.Visible = true;
            this.button3.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.panel5.Visible = false;
            this.textBox2.Text = "";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox05.Text != "")
            {
                try
                {
                    query = "INSERT INTO tablacomunidades (coddepto,codmuni,coddistrito,codcomunidad,comunidad)VALUES('" + this.textBox01.Text + "','" + this.textBox02.Text + "','" + this.textBox03.Text + "','" + this.textBox04.Text + "','" + this.textBox05.Text + "')";
                    consulData.Insertar(query);

                    btninsert();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button10_Click(object sender, EventArgs e)
        {
            btninsert();
        }
        
        void btninsert()
        {
            this.dataGrid.Visible = true;
            this.button3.Visible = true;
            this.button6.Visible = true;
            this.button7.Visible = true;
            this.panel6.Visible = false;
            this.textBox01.Text = "";
            this.textBox02.Text = "";
            this.textBox03.Text = "";
            this.textBox04.Text = "";
            this.textBox05.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarConsultas muestra = new MostrarConsultas();
            muestra.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
