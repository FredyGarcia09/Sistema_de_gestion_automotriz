using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_gestion_automotriz.BACKEND.DAOs
{
    internal class ServiciosDAO
    {
        Conexion conexionDB = new Conexion();

        /// <summary>
        /// Inserta un nuevo registro en la tabla servicios.
        /// </summary>
        public void GuardarServicio(string clave, string nombre, string descripcion, double costo, double tiempo)
        {
            try
            {
                string query = "INSERT INTO servicios (claveServicio, nombreServicio, descripcion, costoBase, tiempoEstimadoHrs) " +
                               "VALUES (@cla, @nom, @des, @cos, @tie)";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());

                comando.Parameters.AddWithValue("@cla", clave);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@des", descripcion);
                comando.Parameters.AddWithValue("@cos", costo);
                comando.Parameters.AddWithValue("@tie", tiempo);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio guardado exitosamente.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el servicio: " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente usando la claveServicio como identificador.
        /// </summary>
        public void ModificarServicio(string clave, string nombre, string descripcion, double costo, double tiempo)
        {
            try
            {
                string query = "UPDATE servicios SET nombreServicio = @nom, descripcion = @des, costoBase = @cos, tiempoEstimadoHrs = @tie WHERE claveServicio = @cla";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());

                comando.Parameters.AddWithValue("@cla", clave);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@des", descripcion);
                comando.Parameters.AddWithValue("@cos", costo);
                comando.Parameters.AddWithValue("@tie", tiempo);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio actualizado correctamente.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el servicio: " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un registro permanentemente de la tabla servicios.
        /// </summary>
        public void EliminarServicio(string clave)
        {
            try
            {
                string query = "DELETE FROM servicios WHERE claveServicio = @cla";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());
                comando.Parameters.AddWithValue("@cla", clave);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Servicio eliminado correctamente.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar: " + ex.Message);
            }
        }

        /// <summary>
        /// Recupera todos los servicios y los asigna a un DataGridView.
        /// </summary>
        public void MostrarServicios(DataGridView tabla)
        {
            try
            {
                string query = "SELECT * FROM servicios";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionDB.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los servicios: " + ex.Message);
            }
        }
    }
}