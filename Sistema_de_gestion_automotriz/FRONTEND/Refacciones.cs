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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Refacciones_Load(object sender, EventArgs e)
        {

        }

        private void txtFuncionalidad_Enter(object sender, EventArgs e)
        {
            txtCodigoRefaccion.Text = "";
            txtCodigoRefaccion.ForeColor = Color.Black;
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
            txtMarca.Text = "";
            txtMarca.ForeColor = Color.Black;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogo_Refacciones f2 = new Catalogo_Refacciones();
            f2.Show();
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
            txtNombreRefaccion.Text = "";
            txtNombreRefaccion.ForeColor = Color.Black;
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
            txtPrecioUnitario.Text = "";
            txtPrecioUnitario.ForeColor = Color.Black;
        }

        private void txtCodigoRefaccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control (como borrar)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // "Bloquea" la tecla
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
            txtCodigoRefaccion.Clear();
            txtMarca.Clear();
            txtNombreRefaccion.Clear();
            txtPrecioUnitario.Clear();
            txtStockMinimo.Clear();
            txtAtockActual.Clear();

            // Para el ComboBox del proveedor
            cboProveedor.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cboProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona un proveedor de la lista.");
                return;
            }

            try
            {
                // Creamos el objeto del DAO para procesar los datos 
                BACKEND.DAOs.RefaccionesDAO dao = new BACKEND.DAOs.RefaccionesDAO();

                // Le mandamos todos los datos, incluyendo el .Text del ComboBox
                dao.GuardarRefaccion(
                    txtCodigoRefaccion.Text,
                    txtMarca.Text,
                    txtNombreRefaccion.Text,
                    cboProveedor.Text, // <--- Aquí es donde metes el proveedor
                    Convert.ToDouble(txtPrecioUnitario.Text),
                    Convert.ToInt32(txtAtockActual.Text), // Usando tu variable 'Atock'
                    Convert.ToInt32(txtStockMinimo.Text)
                );

                MessageBox.Show("Datos guardados. Volviendo al catálogo...");
                this.btnCerrar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Verifica que los campos numéricos sean correctos.");
            }
        }

        // Método para recibir datos y decidir si se puede editar o no 
        public void LlenarCampos(string codigo, string nombre, string marca, string precio, string stockA, string stockM, string prov, bool esEditable)
        {
            // Llenamos los textos
            txtCodigoRefaccion.Text = codigo;
            txtNombreRefaccion.Text = nombre;
            txtMarca.Text = marca;
            txtPrecioUnitario.Text = precio;
            txtAtockActual.Text = stockA;
            txtStockMinimo.Text = stockM;
            cboProveedor.Text = prov;

            // Ajustamos colores para que no parezcan placeholders
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) { c.ForeColor = Color.Black; }
            }

            // BLOQUEAR O DESBLOQUEAR 
                        // Usamos ReadOnly para que el usuario pueda copiar el texto pero no borrarlo
            txtCodigoRefaccion.ReadOnly = !esEditable;
            txtNombreRefaccion.ReadOnly = !esEditable;
            txtMarca.ReadOnly = !esEditable;
            txtPrecioUnitario.ReadOnly = !esEditable;
            txtAtockActual.ReadOnly = !esEditable;
            txtStockMinimo.ReadOnly = !esEditable;

            // El ComboBox se bloquea con Enabled
            cboProveedor.Enabled = esEditable;

            // Si es modo "Ver", ocultamos el botón de Guardar para que no intenten picarle
            btnGuardar.Visible = esEditable;
        }
    }
}
