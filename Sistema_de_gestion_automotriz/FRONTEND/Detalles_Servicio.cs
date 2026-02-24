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
        private bool esModificacion = false;
        private bool esSoloLectura = false;

        public Detalles_Servicio()
        {
            InitializeComponent();
        }

        // Método principal de configuración de estado
        public void LlenarCampos(string clave, string nombre, string descripcion, string costo, string tiempo, bool esEditable, bool esNuevo)
        {
            txtClaveServicio.Text = clave;
            txtNombreServicio.Text = nombre;
            txtDescripcion.Text = descripcion;
            txtCostoBase.Text = costo;
            txtTiempoEstimado.Text = tiempo;

            esSoloLectura = !esEditable;
            esModificacion = !esNuevo;

            // BLOQUEOS REALES 
            txtClaveServicio.Enabled = esEditable;
            txtNombreServicio.Enabled = esEditable;
            txtDescripcion.Enabled = esEditable;
            txtCostoBase.Enabled = esEditable;
            txtTiempoEstimado.Enabled = esEditable;

            btnGuardar.Visible = esEditable;
            btnCancelar.Visible = esEditable;

            if (!esEditable)
            {
                lblModo.Text = "MODO: Sólo Lectura";
                lblModo.ForeColor = Color.Gray;
            }
            else if (esNuevo)
            {
                lblModo.Text = "MODO: Agregar Servicio";
                lblModo.ForeColor = ColorTranslator.FromHtml("#006400");
            }
            else
            {
                lblModo.Text = "MODO: Edición";
                lblModo.ForeColor = Color.Orange;
                txtClaveServicio.Enabled = false;
            }

            
            // Buscamos todos los TextBox del formulario, sin importar si están en un GroupBox
            var todosLosTextBox = this.Controls.Cast<Control>()
                                  .SelectMany(c => GetAllControls(c))
                                  .OfType<TextBox>();

            foreach (TextBox txt in todosLosTextBox)
            {
                // Si el campo tiene texto y NO es el texto de ejemplo, lo ponemos negro
                if (!string.IsNullOrWhiteSpace(txt.Text) &&
                    txt.Text != "Ex: SERV-001" &&
                    txt.Text != "SKU-00000" &&
                    txt.Text != " $ 0.00" &&
                    txt.ForeColor == Color.Gainsboro)
                {
                    txt.ForeColor = Color.Black;
                }
            }
        }

        private void txtClaveServicio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClaveServicio.Text)) { 
                txtClaveServicio.Text = "Ex: SERV-001"; txtClaveServicio.ForeColor = Color.Gainsboro; 
            }
        }

        private void txtClaveServicio_Enter(object sender, EventArgs e)
        {
            if (txtClaveServicio.ForeColor == Color.Gainsboro)
            {
                txtClaveServicio.Text = ""; txtClaveServicio.ForeColor = Color.Black;
            }
        }

        private void txtNombreServicio_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text)) { 
                txtNombreServicio.Text = "Mantenimiento Preventivo"; 
                txtNombreServicio.ForeColor = Color.Gainsboro; 
            }
        }

        private void txtNombreServicio_Enter(object sender, EventArgs e)
        {
            if (txtNombreServicio.ForeColor == Color.Gainsboro)
            {
                txtNombreServicio.Text = ""; txtNombreServicio.ForeColor = Color.Black;
            }
        }

        private void txtDescripcion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) { 
                    txtDescripcion.Text = "Detalle los alcances técnicos..."; 
                    txtDescripcion.ForeColor = Color.Gainsboro; 
                }
            }
        }

        private void txtDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtDescripcion.ForeColor == Color.Gainsboro)
            {
                txtDescripcion.Text = ""; txtDescripcion.ForeColor = Color.Black;
            }
        }

        private void txtCostoBase_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCostoBase.Text)) { 
                txtCostoBase.Text = " $ 0.00"; 
                txtCostoBase.ForeColor = Color.Gainsboro; 
            }
        }

        private void txtCostoBase_Enter(object sender, EventArgs e)
        {
            if (txtCostoBase.ForeColor == Color.Gainsboro)
            {
                txtCostoBase.Text = ""; txtCostoBase.ForeColor = Color.Black;
            }
        }

        private void txtTiempoEstimado_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTiempoEstimado.Text)) { 
                txtTiempoEstimado.Text = "1.5 HRS"; 
                txtTiempoEstimado.ForeColor = Color.Gainsboro; 
            }

        }

        private void txtTiempoEstimado_Enter(object sender, EventArgs e)
        {
            if (txtTiempoEstimado.ForeColor == Color.Gainsboro)
            {
                txtTiempoEstimado.Text = ""; txtTiempoEstimado.ForeColor = Color.Black;
            }
        }

        private void txtClaveServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar); // Forzar Mayúsculas

            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-' && !txtClaveServicio.Text.Contains("-"))
            {
                e.Handled = false; // Permite el guion solo si no hay uno
            }
            else
            {
                e.Handled = true; // Bloquea todo lo demás
            }
        }

        private void txtNombreServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCostoBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) e.Handled = false;
            else if (e.KeyChar == '.' && !txtCostoBase.Text.Contains(".")) e.Handled = false;
            else e.Handled = true;
        }

        private void txtTiempoEstimado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) e.Handled = false;
            else if (e.KeyChar == '.' && !txtTiempoEstimado.Text.Contains(".")) e.Handled = false;
            else e.Handled = true;
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\'' || e.KeyChar == ';') e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (!esSoloLectura)
            {
                DialogResult respuesta = MessageBox.Show(
                    "¿Estás seguro de que deseas cancelar?\nLos cambios realizados no se guardarán.",
                    "Confirmar Cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.No) return;
            }
            this.btnCerrar_Click(null, null);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Catalogo_Servicio catalogo = (Catalogo_Servicio)Application.OpenForms["Catalogo_Servicio"];
            if (catalogo != null)
            {
                catalogo.RefrescarTabla();
                catalogo.Show();
            }
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string costoLimpio = txtCostoBase.Text.Replace("$", "").Trim();
            string tiempoLimpio = txtTiempoEstimado.Text.Replace("HRS", "").Trim();

            try
            {
                BACKEND.DAOs.ServiciosDAO dao = new BACKEND.DAOs.ServiciosDAO();

                if (esModificacion)
                {
                    dao.ModificarServicio(txtClaveServicio.Text, txtNombreServicio.Text, txtDescripcion.Text, Convert.ToDouble(costoLimpio), Convert.ToDouble(tiempoLimpio));
                }
                else
                {
                    dao.GuardarServicio(txtClaveServicio.Text, txtNombreServicio.Text, txtDescripcion.Text, Convert.ToDouble(costoLimpio), Convert.ToDouble(tiempoLimpio));
                }

                esSoloLectura = true;
                this.btnCerrar_Click(null, null);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    MessageBox.Show("La Clave de Servicio '" + txtClaveServicio.Text + "' ya existe. Usa una distinta.", "Clave Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Revisa los formatos numéricos. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Esta función es la que ayuda a encontrar los TextBox que están escondidos dentro de GroupBoxes
        public IEnumerable<Control> GetAllControls(Control container)
        {
            var controls = container.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllControls(ctrl)).Concat(controls);
        }
    }
}
