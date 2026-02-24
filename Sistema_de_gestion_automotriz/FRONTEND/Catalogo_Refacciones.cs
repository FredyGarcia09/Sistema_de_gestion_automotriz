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
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            // Selección de toda la fila
            dgvRefacciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Evita que el usuario edite o agregue filas
            dgvRefacciones.AllowUserToAddRows = false;
            dgvRefacciones.ReadOnly = true;

            // Diseño visual 
            dgvRefacciones.BackgroundColor = Color.White;
            dgvRefacciones.BorderStyle = BorderStyle.None;
            dgvRefacciones.EnableHeadersVisualStyles = false;

            // Encabezados
            dgvRefacciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#006400");
            dgvRefacciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRefacciones.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // Filas alternadas
            dgvRefacciones.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#E8F5E9");
        }

        public void RefrescarTabla()
        {
            // DAO de conexiones
            BACKEND.DAOs.RefaccionesDAO objetoDAO = new BACKEND.DAOs.RefaccionesDAO();

            // LLenar Grid
            objetoDAO.MostrarRefacciones(dgvRefacciones);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Refacciones ventana = new Refacciones();
            // Parámetros vacíos. esEditable = true, esNuevo = true
            ventana.LlenarCampos("", "", "", "", "", "", "", true, true);
            ventana.Show();
            this.Hide();
        }

        private void txtBuscar_Clave_Nombre_TextChanged(object sender, EventArgs e)
        {
            // Condicion para buscar
            if (txtBuscar_Clave_Nombre.Text == "🔍Buscar por Clave o Nombre." || string.IsNullOrWhiteSpace(txtBuscar_Clave_Nombre.Text))
            {
                // Si la tabla ya tiene datos, le quitamos los filtros
                if (dgvRefacciones.DataSource is DataTable dtVacio)
                {
                    dtVacio.DefaultView.RowFilter = "";
                }
                return;
            }

            // Aplicar filtro en memoria local
            if (dgvRefacciones.DataSource is DataTable dt)
            {
                // Limpiar el texto ingresado
                string textoBuscado = txtBuscar_Clave_Nombre.Text.Trim().Replace("'", "''");

                // Filtramos donde la clave O el nombre contengan el texto ingresado
                dt.DefaultView.RowFilter = $"codigoRefaccion LIKE '%{textoBuscado}%' OR nombre LIKE '%{textoBuscado}%'";
            }
        }

        private void txtBuscar_Clave_Nombre_Enter(object sender, EventArgs e)
        {
            txtBuscar_Clave_Nombre.Text = "";
            txtBuscar_Clave_Nombre.ForeColor = Color.Black;
        }

        private void txtBuscar_Clave_Nombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar_Clave_Nombre.Text))
            {
                txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre.";
                txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            }
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
            // Mostrar menú principal
            Application.OpenForms["MenuPrincipal"].Show();
            this.Close();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvRefacciones.SelectedRows.Count > 0)
            {
                Refacciones ventana = new Refacciones();
                EnviarDatos(ventana, false, false); // esEditable = false, esNuevo = false
                ventana.Show();
                this.Hide();
            }
            else { MessageBox.Show("Selecciona una refacción."); }
        }


        private void EnviarDatos(Refacciones ventana, bool editable, bool nuevo)
        {
            string cod = dgvRefacciones.CurrentRow.Cells[0].Value.ToString();
            string nom = dgvRefacciones.CurrentRow.Cells[1].Value.ToString();
            string mar = dgvRefacciones.CurrentRow.Cells[2].Value.ToString();
            string pre = dgvRefacciones.CurrentRow.Cells[3].Value.ToString();
            string sA = dgvRefacciones.CurrentRow.Cells[4].Value.ToString();
            string sM = dgvRefacciones.CurrentRow.Cells[5].Value.ToString();
            string pro = dgvRefacciones.CurrentRow.Cells[6].Value.ToString();

            ventana.LlenarCampos(cod, nom, mar, pre, sA, sM, pro, editable, nuevo);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre.";
            txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;

            // Quitar el filtro de memoria
            if (dgvRefacciones.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = "";
            }

            // Volver a descargar los datos de Azure
            RefrescarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verificamos que se seleccionó una fila en el grid
            if (dgvRefacciones.SelectedRows.Count > 0)
            {
                string codigo = dgvRefacciones.CurrentRow.Cells[0].Value.ToString();
                string nombre = dgvRefacciones.CurrentRow.Cells[1].Value.ToString();

                // Mostramos la ventana de confirmación 
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro que deseas eliminar la refacción: " + nombre + "?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // Procedemos a borrar
                if (resultado == DialogResult.Yes)
                {
                    BACKEND.DAOs.RefaccionesDAO dao = new BACKEND.DAOs.RefaccionesDAO();
                    dao.EliminarRefaccion(codigo);

                    // Actualizamos la tabla automáticamente para ver el cambio
                    RefrescarTabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.");
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvRefacciones.SelectedRows.Count > 0)
            {
                Refacciones ventana = new Refacciones();
                EnviarDatos(ventana, true, false); // esEditable = true, esNuevo = false
                ventana.Show();
                this.Hide();
            }
            else { MessageBox.Show("Selecciona una refacción."); }
        }

        private void Catalogo_Refacciones_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }

        private void dgvRefacciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validar clic a una fila y no a los títulos
            if (e.RowIndex >= 0)
            {
                btnVer_Click(sender, e);
            }
        }

        private void txtBuscar_Clave_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convertir automáticamente a MAYÚSCULAS al teclear
            e.KeyChar = char.ToUpper(e.KeyChar);

            // Permitir letras o números
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false; 
            }
            // Permitir teclas de control (Borrar, flechas, etc.)
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false; 
            }
            // Permitir el guion '-' solo una vez
            else if (e.KeyChar == '-')
            {
                TextBox txt = (TextBox)sender; 

                if (txt.Text.Contains("-"))
                {
                    e.Handled = true; 
                }
                else
                {
                    e.Handled = false; 
                }
            }
            // Bloquear todo lo demás (espacios, puntos, comas, etc.)
            else
            {
                e.Handled = true; 
            }
        }
    }
}
