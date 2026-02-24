using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sistema_de_gestion_automotriz
{
    public partial class Catalogo_Servicio : Form
    {
        public Catalogo_Servicio()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        public void RefrescarTabla()
        {
            BACKEND.DAOs.ServiciosDAO objetoDAO = new BACKEND.DAOs.ServiciosDAO();
            objetoDAO.MostrarServicios(dgvServicios);
        }

        private void ConfigurarGrid()
        {
            dgvServicios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvServicios.AllowUserToAddRows = false;
            dgvServicios.ReadOnly = true;
            dgvServicios.BackgroundColor = Color.White;
            dgvServicios.BorderStyle = BorderStyle.None;
            dgvServicios.EnableHeadersVisualStyles = false;
            dgvServicios.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#006400");
            dgvServicios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvServicios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvServicios.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E8F5E9");
        }

        private void EnviarDatos(Detalles_Servicio ventana, bool editable, bool nuevo)
        {
            string cla = dgvServicios.CurrentRow.Cells[0].Value.ToString();
            string nom = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            string des = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            string cos = dgvServicios.CurrentRow.Cells[3].Value.ToString();
            string tie = dgvServicios.CurrentRow.Cells[4].Value.ToString();

            ventana.LlenarCampos(cla, nom, des, cos, tie, editable, nuevo);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Detalles_Servicio ventana = new Detalles_Servicio();
            ventana.LlenarCampos("", "", "", "", "", true, true);
            ventana.Show();
            this.Hide();
        }
        private void AbrirNuevoFormulario()
        {
            Application.Run(new Detalles_Servicio());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["MenuPrincipal"].Show();
            this.Close();
        }

        private void btnExtender_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                Detalles_Servicio ventana = new Detalles_Servicio();
                EnviarDatos(ventana, true, false);
                ventana.Show();
                this.Hide();
            }
            else { MessageBox.Show("Selecciona un servicio."); }
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
            if (txtBuscar_Clave_Nombre.Text == "🔍Buscar por Clave del Servicio" || string.IsNullOrWhiteSpace(txtBuscar_Clave_Nombre.Text))
            {
                if (dgvServicios.DataSource is DataTable dtVacio) dtVacio.DefaultView.RowFilter = "";
                return;
            }

            if (dgvServicios.DataSource is DataTable dt)
            {
                string textoBuscado = txtBuscar_Clave_Nombre.Text.Trim().Replace("'", "''");
                dt.DefaultView.RowFilter = $"claveServicio LIKE '%{textoBuscado}%' OR nombreServicio LIKE '%{textoBuscado}%'";
            }
        }

        private void txtBuscar_Clave_Nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar_Clave_Nombre.Text)) { 
                txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave del Servicio"; 
                txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro; 
            }
        }

        private void txtBuscar_Clave_Nombre_Enter(object sender, EventArgs e)
        {
            if (txtBuscar_Clave_Nombre.ForeColor != Color.Black) { 
                txtBuscar_Clave_Nombre.Text = ""; 
                txtBuscar_Clave_Nombre.ForeColor = Color.Black; 
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                Detalles_Servicio ventana = new Detalles_Servicio();
                EnviarDatos(ventana, false, false);
                ventana.Show();
                this.Hide();
            }
            else { MessageBox.Show("Selecciona un servicio."); }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave del Servicio";
            txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            if (dgvServicios.DataSource is DataTable dt) dt.DefaultView.RowFilter = "";
            RefrescarTabla();
        }

        private void Catalogo_Servicio_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvServicios.SelectedRows.Count > 0)
            {
                string clave = dgvServicios.CurrentRow.Cells[0].Value.ToString();
                string nombre = dgvServicios.CurrentRow.Cells[1].Value.ToString();

                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro que deseas eliminar el servicio: " + nombre + "?",
                    "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    BACKEND.DAOs.ServiciosDAO dao = new BACKEND.DAOs.ServiciosDAO();
                    dao.EliminarServicio(clave);
                    RefrescarTabla();
                }
            }
            else { MessageBox.Show("Selecciona un servicio para eliminar."); }
        }

        private void dgvServicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { btnVer_Click(sender, e); }
        }
    }
}
