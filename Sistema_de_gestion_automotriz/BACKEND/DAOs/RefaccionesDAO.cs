using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_gestion_automotriz.BACKEND.DAOs
{
    internal class RefaccionesDAO
    {
        // Instancia de nuestra clase de conexión
        Cconexion conexionDB = new Cconexion();

        // Método para INSERTAR 
        public void GuardarRefaccion(string codigo, string marca, string nombre, string proveedor, double precio, int stockAct, int stockMin)
        {
            try
            {
                // 1. Agregamos el campo 'proveedor' a la consulta SQL 
                string query = "INSERT INTO refacciones (codigoRefaccion, nombre, marca, precioUnitario, stockActual, stockMinimo, proveedor) " +
                               "VALUES (@cod, @nom, @mar, @pre, @sta, @stm, @pro)";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());

               // 2. Pasamos los parámetros
                comando.Parameters.AddWithValue("@cod", codigo);
                comando.Parameters.AddWithValue("@mar", marca);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@pro", proveedor); 
                comando.Parameters.AddWithValue("@pre", precio);
                comando.Parameters.AddWithValue("@sta", stockAct);
                comando.Parameters.AddWithValue("@stm", stockMin);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Refacción y Proveedor guardados en Azure exitosamente."); 
        comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message);
            }
        }
        // Método para ELIMINAR una refacción de la base de datos 
        public void EliminarRefaccion(string codigo)
        {
            try
            {
                Cconexion conexionDB = new Cconexion();
                // Sentencia SQL para borrar el registro específico 
                string query = "DELETE FROM refacciones WHERE codigoRefaccion = @cod";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());
                comando.Parameters.AddWithValue("@cod", codigo);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente de la nube.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar: " + ex.Message);
            }
        }
        // Método para OBTENER los datos de la nube y llenar un DataTable
        public void MostrarRefacciones(DataGridView tabla)
        {
            Cconexion objetoConexion = new Cconexion();
            try
            {
                // Consulta SQL para traer todo de la tabla refacciones
                string query = "SELECT * FROM refacciones";

                // El Adapter sirve para llenar la tabla con los datos de MySQL
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);

                // Asignamos los datos a la cuadrícula del diseño
                tabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos de Azure: " + ex.Message);
            }
        }
    }
}
