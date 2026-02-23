using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_automotriz.BACKEND.DAOs
{
    internal class Conexion
    { 
        private string servidor = "4.227.177.122";
        private string bd = "dbTallerMecanico";
        private string usuario = "admin";
        private string password = "root";
        private string puerto = "3306";

        public MySqlConnection establecerConexion()
        {
            string cadenaConexion = $"server={servidor}; port={puerto}; user id={usuario}; password={password}; database={bd}; Connection Timeout=5;";
            MySqlConnection conex = new MySqlConnection(cadenaConexion);
            return conex;
        }
    }
}
