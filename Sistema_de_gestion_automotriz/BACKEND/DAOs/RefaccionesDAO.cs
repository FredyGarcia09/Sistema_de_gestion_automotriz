using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sistema_de_gestion_automotriz.BACKEND.DAOs
{
    internal class RefaccionesDAO
    {
        Conexion conexionDB = new Conexion();

        /// <summary>
        /// Inserta un nuevo registro en la tabla de refacciones.
        /// </summary>
        /// <param name="codigo">Código único de la refacción.</param>
        /// <param name="marca">Marca de la pieza.</param>
        /// <param name="nombre">Nombre descriptivo de la refacción.</param>
        /// <param name="proveedor">Nombre del proveedor.</param>
        /// <param name="precio">Precio unitario.</param>
        /// <param name="stockAct">Cantidad actual disponible en inventario.</param>
        /// <param name="stockMin">Cantidad mínima requerida en inventario.</param>
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

        /// <summary>
        /// Actualiza los datos de un registro existente en la tabla de refacciones.
        /// </summary>
        /// <param name="codigo">Código único de la refacción (no modificable).</param>
        /// <param name="marca">Nueva marca de la pieza.</param>
        /// <param name="nombre">Nuevo nombre descriptivo.</param>
        /// <param name="proveedor">Nuevo proveedor.</param>
        /// <param name="precio">Nuevo precio unitario.</param>
        /// <param name="stockAct">Nueva cantidad en inventario.</param>
        /// <param name="stockMin">Nuevo stock mínimo permitido.</param>
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

        /// <summary>
        /// Elimina de forma permanente un registro de la tabla de refacciones.
        /// </summary>
        /// <param name="codigo">Código de la refacción a eliminar.</param>
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

        /// <summary>
        /// Recupera todos los registros de la tabla de refacciones y los asigna a un componente visual.
        /// </summary>
        /// <param name="tabla">El DataGridView donde se volcarán los datos recuperados.</param>
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