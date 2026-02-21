using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_automotriz.BACKEND.DAOs
{
    internal class Cconexion
    {
        // Datos para la conexión a Azure 
        private string servidor = "tu-servidor.mysql.database.azure.com";
        private string bd = "tu_base_de_datos";
        private string usuario = "tu_usuario";
        private string password = "tu_password";
        private string puerto = "3306"; // Puerto estándar de MySQL

        public MySqlConnection establecerConexion()
        {
            // La cadena de conexión incluye SslMode=Required para la seguridad de Azure
            string cadenaConexion = $"server={servidor}; port={puerto}; user id={usuario}; password={password}; database={bd}; SslMode=Required;";
            MySqlConnection conex = new MySqlConnection(cadenaConexion);
            return conex;
        }
    }
}
