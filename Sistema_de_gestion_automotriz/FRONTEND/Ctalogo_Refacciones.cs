using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Sistema_de_gestion_automotriz
{
    public partial class Catalogo_Refacciones : Form
    {
        public Catalogo_Refacciones()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Creamos un hilo para abrir el nuevo formulario
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirNuevoFormulario));

            // 2. Iniciamos el hilo
            hilo.SetApartmentState(System.Threading.ApartmentState.STA);
            hilo.Start();

            // 3. Cerramos el formulario actual definitivamente
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1. Creamos un hilo para abrir el nuevo formulario
            System.Threading.Thread hilo = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirNuevoFormulario));

            // 2. Iniciamos el hilo
            hilo.SetApartmentState(System.Threading.ApartmentState.STA);
            hilo.Start();

            // 3. Cerramos el formulario actual definitivamente
            this.Close();
        }
        private void AbrirNuevoFormulario()
        {
            // Cambia de form
            Application.Run(new Refacciones());
        }

        private void txtBuscar_Clave_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Clave_Nombre_Enter(object sender, EventArgs e)
        {
            txtBuscar_Clave_Nombre.Text = "";
            txtBuscar_Clave_Nombre.ForeColor = Color.Black;
        }

        private void txtBuscar_Clave_Nombre_Leave(object sender, EventArgs e)
        {
            txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre."; // Restaura la sugerencia
            txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MenuPrincipal f2 = new MenuPrincipal();
            f2.Show();
        }
    }
}
