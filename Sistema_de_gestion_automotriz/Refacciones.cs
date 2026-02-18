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
            txtCodigoRefaccion.Text = "SKU-00000"; // Restaura la sugerencia
            txtCodigoRefaccion.ForeColor = Color.Gainsboro;
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            txtMarca.Text = "Ej. Bosch, Mazda..";
            txtMarca.ForeColor = Color.Gainsboro;
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtMarca.ForeColor = Color.Black;
        }

    }
}
