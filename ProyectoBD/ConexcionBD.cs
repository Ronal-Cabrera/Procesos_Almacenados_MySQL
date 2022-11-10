using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public class ConexcionBD
    {
        string servidor = "192.168.0.100";
        string bd = "bd";
        string usuario = "root";
        string password = "admin2";
        string port = "3305";

        public MySqlConnection conexion = new MySqlConnection();

        public ConexcionBD()
        {
            string cadenaConexion = "datasource=" + servidor + ";port=" + port + ";username=" + usuario + ";password=" + password + ";database=" + bd + ";";
            conexion.ConnectionString = cadenaConexion;
        }

        public void inicioConec()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conectado");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                MessageBox.Show("ERROR");
            }
        }

        public void inicioDeconec()
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Desonectado");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");
                MessageBox.Show("ERROR");
            }
        }
    }
}
