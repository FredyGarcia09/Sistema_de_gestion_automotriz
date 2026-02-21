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
    public partial class Catalogo_Servicio : Form
    {
        public Catalogo_Servicio()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirNuevoFormulario));
            hilo.SetApartmentState(System.Threading.ApartmentState.STA);
            hilo.Start();
            this.Close();
        }
        private void AbrirNuevoFormulario()
        {
            Application.Run(new Detalles_Servicio());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal f2 = new MenuPrincipal();
            f2.Show();
        }

        private void btnExtender_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirNuevoFormulario));
            hilo.SetApartmentState(System.Threading.ApartmentState.STA);
            hilo.Start();
            this.Close();
        }

        private void txtBuscar_Clave_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo letras, espacios y teclas de control (como borrar)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // "Bloquea" la tecla
            }
        }

        private void txtBuscar_Clave_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Clave_Nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar_Clave_Nombre.Text))
            {
                txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave del Servicio";
                txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            }
        }

        private void txtBuscar_Clave_Nombre_Enter(object sender, EventArgs e)
        {
            txtBuscar_Clave_Nombre.Text = "";
            txtBuscar_Clave_Nombre.ForeColor = Color.Black;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detalles_Servicio f2 = new Detalles_Servicio();
            f2.Show();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (txtBuscar_Clave_Nombre.Text != null)
            {
                txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre.";
                txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            }
        }
    }
}
