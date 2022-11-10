using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBD
{
    public class Clas
    {
        string servidor = "127.0.0.1";
        string bd = "bd";
        string usuario = "root";
        string password = "admin";
        string port = "3305";
        string query = "";

        public MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

        public Clas(){
            string cadenaConexion = "datasource=" + servidor + ";port=" + port + ";username=" + usuario + ";password=" + password + ";database=" + bd + ";";  
        }

    }
}
