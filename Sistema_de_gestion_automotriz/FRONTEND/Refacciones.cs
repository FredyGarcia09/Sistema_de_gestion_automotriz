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
            // 1. Creamos una lista de los campos que queremos validar longitud (tipo varchar/text)
            TextBox[] camposTexto = { txtCodigoRefaccion, txtMarca, txtNombreRefaccion };

            foreach (TextBox txt in camposTexto)
            {
                // Primero revisamos si el usuario escribió algo real (que no sea el placeholder)
                // Usamos el color Gainsboro que tú definiste para saber si es el ejemplo
                if (txt.ForeColor == Color.Gainsboro || string.IsNullOrWhiteSpace(txt.Text))
                {
                    MessageBox.Show("El campo " + txt.Name.Replace("txt", "") + " es obligatorio.", "Atención");
                    txt.Focus();
                    return; // Detiene el proceso
                }

                // Ahora validamos los 50 caracteres
                if (txt.Text.Length > 50)
                {
                    MessageBox.Show("El campo " + txt.Name.Replace("txt", "") + " solo permite hasta 50 caracteres.", "Límite excedido");
                    txt.Focus();
                    return; // Detiene el proceso
                }
            }

            // 2. Validaciones extras para números (Precio y Stock)
            if (txtPrecioUnitario.ForeColor == Color.Gainsboro || txtAtockActual.ForeColor == Color.Gainsboro)
            {
                MessageBox.Show("Por favor ingresa valores numéricos en Precio y Stock.");
                return;
            }

            // Si llegó hasta aquí, ¡todo está perfecto!
            MessageBox.Show("¡Refacción guardada con éxito!", "Sistema de Gestión", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
