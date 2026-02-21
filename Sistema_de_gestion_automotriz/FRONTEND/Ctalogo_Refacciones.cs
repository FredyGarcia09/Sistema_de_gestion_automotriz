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

        // Esta es la función que el botón de guardar intentaba llamar
        public void RefrescarTabla()
        {
            // 1. Creamos el objeto del DAO que está en tu carpeta BACKEND
            BACKEND.DAOs.RefaccionesDAO objetoDAO = new BACKEND.DAOs.RefaccionesDAO();

            // 2. Llamamos al método que creamos arriba pasándole el nombre de tu DataGridView
            // IMPORTANTE: Asegúrate de que tu grid se llame 'dgvRefacciones' en las propiedades
            objetoDAO.MostrarRefacciones(dgvRefacciones);
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
            if (string.IsNullOrWhiteSpace(txtBuscar_Clave_Nombre.Text))
            {
                txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre."; // Restaura la sugerencia
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
            this.Hide();
            MenuPrincipal f2 = new MenuPrincipal();
            f2.Show();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvRefacciones.SelectedRows.Count > 0)
            {
                Refacciones ventana = new Refacciones();
                EnviarDatos(ventana, false); // false = NO editable
                ventana.Show();
                this.Hide();
            }
        }

        // Método para extraer datos del grid respetando el orden de tu DB 
        private void EnviarDatos(Refacciones ventana, bool editable)
        {
            // Índice según tu tabla: 0:cod, 1:nom, 2:mar, 3:pre, 4:stA, 5:stM, 6:prov
            string cod = dgvRefacciones.CurrentRow.Cells[0].Value.ToString();
            string nom = dgvRefacciones.CurrentRow.Cells[1].Value.ToString();
            string mar = dgvRefacciones.CurrentRow.Cells[2].Value.ToString();
            string pre = dgvRefacciones.CurrentRow.Cells[3].Value.ToString();
            string sA = dgvRefacciones.CurrentRow.Cells[4].Value.ToString();
            string sM = dgvRefacciones.CurrentRow.Cells[5].Value.ToString();
            string pro = dgvRefacciones.CurrentRow.Cells[6].Value.ToString();

            ventana.LlenarCampos(cod, nom, mar, pre, sA, sM, pro, editable);
        }
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            if (txtBuscar_Clave_Nombre.Text != null)
            {
                txtBuscar_Clave_Nombre.Text = "🔍Buscar por Clave o Nombre.";
                txtBuscar_Clave_Nombre.ForeColor = Color.Gainsboro;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que el usuario seleccionó una fila en el grid [cite: 20]
            if (dgvRefacciones.SelectedRows.Count > 0)
            {
                // Extraemos el código de la refacción (Columna 0 según tu script SQL)
                string codigo = dgvRefacciones.CurrentRow.Cells[0].Value.ToString();
                string nombre = dgvRefacciones.CurrentRow.Cells[1].Value.ToString();

                // 2. Mostramos la ventana de confirmación 
                DialogResult resultado = MessageBox.Show(
                    "¿Estás seguro que deseas eliminar la refacción: " + nombre + "?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                // 3. Si el usuario le pica a "SÍ", procedemos a borrar
                if (resultado == DialogResult.Yes)
                {
                    BACKEND.DAOs.RefaccionesDAO dao = new BACKEND.DAOs.RefaccionesDAO();
                    dao.EliminarRefaccion(codigo);

                    // 4. Actualizamos la tabla automáticamente para ver el cambio [cite: 5, 20]
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
                EnviarDatos(ventana, true); // true = SÍ editable
                ventana.Show();
                this.Hide();
            }
        }

        private void Catalogo_Refacciones_Load(object sender, EventArgs e)
        {
            RefrescarTabla();
        }
    }
}
