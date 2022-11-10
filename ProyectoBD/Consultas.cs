using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public class Consultas
    {

        ConexcionBD conectar = new ConexcionBD();

        public void Actualizar(string query)
        {
            try
            {
                conectar.inicioConec();
                MySqlCommand cmdNom = new MySqlCommand(query, conectar.conexion);
                cmdNom.ExecuteNonQuery();
                conectar.inicioDeconec();
                MessageBox.Show("Datos Guardados Con Exito");

            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public void Eliminar(string query)
        {
            conectar.inicioConec();
            MySqlCommand cmdN = new MySqlCommand(query, conectar.conexion);
            cmdN.ExecuteNonQuery();
            MessageBox.Show("Datos eliminado Con Exito");
            conectar.inicioDeconec();
        }

        public void Insertar(string query)
        {
            conectar.inicioConec();
            MySqlCommand cmdNs = new MySqlCommand(query, conectar.conexion);
            cmdNs.ExecuteNonQuery();
            MessageBox.Show("Dato insertado Con Exito");
            conectar.inicioDeconec();
        }
    }
}
