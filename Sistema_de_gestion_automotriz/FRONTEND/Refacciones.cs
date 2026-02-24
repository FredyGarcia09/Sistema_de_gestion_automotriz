using MySql.Data.MySqlClient;
using Sistema_de_gestion_automotriz.BACKEND.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_gestion_automotriz
{
    public partial class Refacciones : Form
    {
        public Refacciones()
        {
            InitializeComponent();

            grbStock.BackColor = ColorTranslator.FromHtml("#81C784");
        }

        private bool esModificacion = false;
        private bool esSoloLectura = false;

        // Configura la UI según el modo (Ver, Agregar, Modificar)
        public void LlenarCampos(string codigo, string nombre, string marca, string precio, string stockA, string stockM, string prov, bool esEditable, bool esNuevo)
        {
            txtCodigoRefaccion.Text = codigo;
            txtNombreRefaccion.Text = nombre;
            txtMarca.Text = marca;
            txtPrecioUnitario.Text = precio;
            txtAtockActual.Text = stockA;
            txtStockMinimo.Text = stockM;
            txtProveedor.Text = prov; // <--- Asumiendo que cambiaste el ComboBox por un TextBox

            // Guardamos el estado en las variables globales
            esSoloLectura = !esEditable;
            esModificacion = !esNuevo;

            // BLOQUEOS REALES
            txtCodigoRefaccion.Enabled = esEditable;
            txtNombreRefaccion.Enabled = esEditable;
            txtMarca.Enabled = esEditable;
            txtPrecioUnitario.Enabled = esEditable;
            txtAtockActual.Enabled = esEditable;
            txtStockMinimo.Enabled = esEditable;
            txtProveedor.Enabled = esEditable;

            // VISIBILIDAD DE BOTONES
            btnGuardar.Visible = esEditable;
            btnCancelar.Visible = esEditable; // Ocultamos cancelar en modo "Ver"

            // GESTIÓN DE LA ETIQUETA "MODO"
            if (!esEditable)
            {
                lblModo.Text = "MODO: Sólo Lectura";
                lblModo.ForeColor = Color.Gray;
            }
            else if (esNuevo)
            {
                lblModo.Text = "MODO: Agregar Refacción";
                lblModo.ForeColor = ColorTranslator.FromHtml("#006400"); // Verde oscuro
            }
            else
            {
                lblModo.Text = "MODO: Edición";
                lblModo.ForeColor = Color.Orange;
                // Si es edición, bloqueamos forzosamente la Llave Primaria
                txtCodigoRefaccion.Enabled = false;
            }

            var todosLosControles = this.Controls.Cast<Control>().Concat(grbStock.Controls.Cast<Control>());

            foreach (Control c in todosLosControles)
            {
                if (c is TextBox txt && !string.IsNullOrWhiteSpace(txt.Text))
                {
                    // Si el texto NO es un ejemplo, lo ponemos en negro
                    if (txt.Text != "SKU-00000" &&
                        txt.Text != "Ej. Bosch, Mazda.." &&
                        txt.Text != "Ej.Filtro de Aceite de Alto Rendimiento" &&
                        txt.Text != "$ 0.00" &&
                        txt.Text != "Ej. Nombre del Proveedor o Empresa" &&
                        txt.Text != "0") // Agregamos el 0 por si acaso
                    {
                        txt.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Refacciones_Load(object sender, EventArgs e)
        {

        }

        private void txtFuncionalidad_Enter(object sender, EventArgs e)
        {
            // Solo borramos si el color es gris (es un placeholder)
            if (txtCodigoRefaccion.ForeColor == Color.Gainsboro)
            {
                txtCodigoRefaccion.Text = "";
                txtCodigoRefaccion.ForeColor = Color.Black;
            }
        }

        private void txtFuncionalidad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoRefaccion.Text))
            {
                txtCodigoRefaccion.Text = "SKU-00000";
                txtCodigoRefaccion.ForeColor = Color.Gainsboro;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                txtMarca.Text = "Ej. Bosch, Mazda..";
                txtMarca.ForeColor = Color.Gainsboro;
            }
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            // Solo borramos si el color es gris (es un placeholder)
            if (txtMarca.ForeColor == Color.Gainsboro)
            {
                txtMarca.Text = "";
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            // Recuperamos el catálogo oculto para actualizar la tabla y mostrarlo
            Catalogo_Refacciones catalogo = (Catalogo_Refacciones)Application.OpenForms["Catalogo_Refacciones"];
            if (catalogo != null)
            {
                catalogo.RefrescarTabla();
                catalogo.Show();
            }
            this.Close(); // Liberamos memoria de esta pantalla
        }

        private void txtNombreRefaccion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreRefaccion.Text))
            {
                txtNombreRefaccion.Text = "Ej.Filtro de Aceite de Alto Rendimiento";
                txtNombreRefaccion.ForeColor = Color.Gainsboro;
            }
        }

        private void txtNombreRefaccion_Enter(object sender, EventArgs e)
        {
            // Solo borramos si el color es gris (es un placeholder)
            if (txtNombreRefaccion.ForeColor == Color.Gainsboro)
            {
                txtNombreRefaccion.Text = "";
                txtNombreRefaccion.ForeColor = Color.Black;
            }
        }

        private void txtPrecioUnitario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text))
            {
                txtPrecioUnitario.Text = "$ 0.00";
                txtPrecioUnitario.ForeColor = Color.Gainsboro;
            }
        }

        private void txtPrecioUnitario_Enter(object sender, EventArgs e)
        {
            // Solo borramos si el color es gris (es un placeholder)
            if (txtPrecioUnitario.ForeColor == Color.Gainsboro)
            {
                txtPrecioUnitario.Text = "";
                txtPrecioUnitario.ForeColor = Color.Black;
            }
        }

        private void txtCodigoRefaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Opcional: Convertir a mayúsculas automáticamente para que se vea mejor
            e.KeyChar = char.ToUpper(e.KeyChar);

            // 2. Permitir Letras o Números
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            // 3. Permitir el guion '-' PERO SOLO SI NO EXISTE YA UNO
            else if (e.KeyChar == '-')
            {
                TextBox txt = (TextBox)sender;

                if (txt.Text.Contains("-"))
                {
                    e.Handled = true; // Ya existe uno, así que bloqueamos este segundo intento
                }
                else
                {
                    e.Handled = false; // No hay ninguno, adelante
                }
            }
            // 4. Permitir teclas de control (como borrar)
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // 5. Bloquear todo lo demás (espacios, comas, puntos, etc.)
            else
            {
                e.Handled = true;
            }
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreRefaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAtockActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números y la tecla de borrar
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números y teclas de control
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            // Permite el punto decimal solo si no existe ya uno en el texto
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; // Bloquea cualquier otra cosa (letras, comas, etc.)
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Si el usuario estaba editando o agregando, le lanzamos la advertencia
            if (!esSoloLectura)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de que deseas cancelar?\nLos cambios realizados no se guardarán.",
                    "Confirmar Cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (respuesta == DialogResult.No)
                {
                    return; // Aborta la cancelación y se queda en la pantalla
                }
            }

            // Si respondió "Sí" (o si estaba en modo lectura), cerramos la ventana
            this.btnCerrar_Click(null, null);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Limpieza del formato de moneda
            string precioLimpio = txtPrecioUnitario.Text.Replace("$", "").Trim();

            try
            {
                BACKEND.DAOs.RefaccionesDAO dao = new BACKEND.DAOs.RefaccionesDAO();

                if (esModificacion)
                {
                    dao.ModificarRefaccion(txtCodigoRefaccion.Text, txtMarca.Text, txtNombreRefaccion.Text, txtProveedor.Text, Convert.ToDouble(precioLimpio), Convert.ToInt32(txtAtockActual.Text), Convert.ToInt32(txtStockMinimo.Text));
                }
                else
                {
                    dao.GuardarRefaccion(txtCodigoRefaccion.Text, txtMarca.Text, txtNombreRefaccion.Text, txtProveedor.Text, Convert.ToDouble(precioLimpio), Convert.ToInt32(txtAtockActual.Text), Convert.ToInt32(txtStockMinimo.Text));
                }

                // Si no hubo errores, forzamos el cierre directo saltándonos la advertencia
                esSoloLectura = true;
                this.btnCerrar_Click(null, null);
            }
            catch (Exception ex)
            {
                // Manejo inteligente del error de Llave Primaria Duplicada
                if (ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("El Código de Refacción '" + txtCodigoRefaccion.Text + "' ya existe en el sistema.\nPor favor, utiliza un código distinto.", "Código Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Error al procesar los datos. Verifica que los campos numéricos sean correctos.\nDetalle: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Método para MODIFICAR una refacción existente
        public void ModificarRefaccion(string codigo, string marca, string nombre, string proveedor, double precio, int stockAct, int stockMin)
        {
            try
            {
                Conexion conexionDB = new Conexion();
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
                MessageBox.Show("Refacción actualizada correctamente en Azure.");
                comando.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar en la base de datos: " + ex.Message);
            }
        }

        private void txtProveedor_Enter(object sender, EventArgs e)
        {
            if (txtProveedor.ForeColor == Color.Gainsboro)
            {
                txtProveedor.Text = "";
                txtProveedor.ForeColor = Color.Black;
            }
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProveedor.Text))
            {
                txtProveedor.Text = "Ej. Nombre del Proveedor o Empresa";
                txtProveedor.ForeColor = Color.Gainsboro;
            }
        }

        private void txtAtockActual_Enter(object sender, EventArgs e)
        {
            // Solo borra si el color es gris (Gainsboro)
            if (txtAtockActual.ForeColor == Color.Gainsboro)
            {
                txtAtockActual.Text = "";
                txtAtockActual.ForeColor = Color.Black;
            }
        }

        private void txtAtockActual_Leave(object sender, EventArgs e)
        {
            // Si el usuario no escribió nada, regresamos el texto de ejemplo
            if (string.IsNullOrWhiteSpace(txtAtockActual.Text))
            {
                txtAtockActual.Text = "0";
                txtAtockActual.ForeColor = Color.Gainsboro;
            }
        }

        private void txtStockMinimo_Enter(object sender, EventArgs e)
        {
            // Si el color es gris, significa que es el placeholder (ejemplo)
            if (txtStockMinimo.ForeColor == Color.Gainsboro)
            {
                txtStockMinimo.Text = "";
                txtStockMinimo.ForeColor = Color.Black;
            }
        }

        private void txtStockMinimo_Leave(object sender, EventArgs e)
        {
            // Si el usuario no escribió nada, regresamos el texto de ejemplo
            if (string.IsNullOrWhiteSpace(txtStockMinimo.Text))
            {
                txtStockMinimo.Text = "0";
                txtStockMinimo.ForeColor = Color.Gainsboro;
            }
        }
    }
}
