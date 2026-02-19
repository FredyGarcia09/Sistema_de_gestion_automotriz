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
    public partial class Detalles_Servicio : Form
    {
        public Detalles_Servicio()
        {
            InitializeComponent();
        }

        private void txtClaveServicio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClaveServicio.Text))
            {
                txtClaveServicio.Text = "Ex: SERV-001";
                txtClaveServicio.ForeColor = Color.Gainsboro;
            }
        }

        private void txtClaveServicio_Enter(object sender, EventArgs e)
        {
            txtClaveServicio.Text = "";
            txtClaveServicio.ForeColor = Color.Black;
        }

        private void txtNombreServicio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text))
            {
                txtNombreServicio.Text = "Mantenimiento Preventivo";
                txtNombreServicio.ForeColor = Color.Gainsboro;
            }
        }

        private void txtNombreServicio_Enter(object sender, EventArgs e)
        {
            txtNombreServicio.Text = "";
            txtNombreServicio.ForeColor = Color.Black;
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                txtDescripcion.Text = "Detalle los alcances técnicos  y requerimientos del servicio...";
                txtDescripcion.ForeColor = Color.Gainsboro;
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            txtDescripcion.Text = "";
            txtDescripcion.ForeColor = Color.Black;
        }

        private void txtCostoBase_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCostoBase.Text))
            {
                txtCostoBase.Text = " $ 0.00";
                txtCostoBase.ForeColor = Color.Gainsboro;
            }
        }

        private void txtCostoBase_Enter(object sender, EventArgs e)
        {
            txtCostoBase.Text = "";
            txtCostoBase.ForeColor = Color.Black;
        }

        private void txtTiempoEstimado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTiempoEstimado.Text))
            {
                txtTiempoEstimado.Text = "1.5                                                   HRS";
                txtTiempoEstimado.ForeColor = Color.Gainsboro;
            }

        }

        private void txtTiempoEstimado_Enter(object sender, EventArgs e)
        {
            txtTiempoEstimado.Text = "";
            txtTiempoEstimado.ForeColor = Color.Black;
        }

        private void txtClaveServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control (como borrar)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // "Bloquea" la tecla
            }
        }

        private void txtNombreServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control (como borrar)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // "Bloquea" la tecla
            }
        }

        private void txtCostoBase_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTiempoEstimado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains("."))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Bloqueamos la comilla simple (') y el punto y coma (;)
            if (e.KeyChar == '\'' || e.KeyChar == ';')
            {
                e.Handled = true; // Ignora la tecla
            }
            if (txtDescripcion.Text.Length > 50)
            {
                MessageBox.Show("La descripcion no puede tener más de 50 caracteres.");
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClaveServicio.Clear();
            txtCostoBase.Clear();
            txtNombreServicio.Clear();
            txtTiempoEstimado.Clear();
            txtDescripcion.Clear();

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogo_Servicio f2 = new Catalogo_Servicio();
            f2.Show();
        }
    }
}
