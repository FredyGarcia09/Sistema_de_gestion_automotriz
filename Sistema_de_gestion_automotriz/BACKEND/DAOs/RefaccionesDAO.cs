using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_gestion_automotriz.BACKEND.DAOs
{
    internal class RefaccionesDAO
    {
        // Instancia de nuestra clase de conexión
        Conexion conexionDB = new Conexion();

        // 1. Método para INSERTAR (AGREGAR)
        public void GuardarRefaccion(string codigo, string marca, string nombre, string proveedor, double precio, int stockAct, int stockMin)
        {
            try
            {
                string query = "INSERT INTO refacciones (codigoRefaccion, nombre, marca, precioUnitario, stockActual, stockMinimo, proveedor) " +
                               "VALUES (@cod, @nom, @mar, @pre, @sta, @stm, @pro)";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());

                comando.Parameters.AddWithValue("@cod", codigo);
                comando.Parameters.AddWithValue("@mar", marca);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@pro", proveedor);
                comando.Parameters.AddWithValue("@pre", precio);
                comando.Parameters.AddWithValue("@sta", stockAct);
                comando.Parameters.AddWithValue("@stm", stockMin);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Refacción guardada exitosamente.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        // 2. Método para ACTUALIZAR (MODIFICAR)
        public void ModificarRefaccion(string codigo, string marca, string nombre, string proveedor, double precio, int stockAct, int stockMin)
        {
            try
            {
                string query = "UPDATE refacciones SET nombre = @nom, marca = @mar, precioUnitario = @pre, stockActual = @sta, stockMinimo = @stm, proveedor = @pro WHERE codigoRefaccion = @cod";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());

                comando.Parameters.AddWithValue("@cod", codigo);
                comando.Parameters.AddWithValue("@mar", marca);
                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@pro", proveedor);
                comando.Parameters.AddWithValue("@pre", precio);
                comando.Parameters.AddWithValue("@sta", stockAct);
                comando.Parameters.AddWithValue("@stm", stockMin);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Refacción actualizada correctamente.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        // 3. Método para ELIMINAR 
        public void EliminarRefaccion(string codigo)
        {
            try
            {
                string query = "DELETE FROM refacciones WHERE codigoRefaccion = @cod";

                MySqlCommand comando = new MySqlCommand(query, conexionDB.establecerConexion());
                comando.Parameters.AddWithValue("@cod", codigo);

                comando.Connection.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado correctamente.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar: " + ex.Message);
            }
        }

        // 4. Método para LEER (VER / LLENAR GRID)
        public void MostrarRefacciones(DataGridView tabla)
        {
            try
            {
                string query = "SELECT * FROM refacciones";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionDB.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tabla.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron mostrar los datos: " + ex.Message);
            }
        }
    }
}