namespace Sistema_de_gestion_automotriz
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            Catalogo_Refacciones ventanaRefacciones = new Catalogo_Refacciones();
            ventanaRefacciones.Show();
            this.Hide();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Catalogo_Servicio ventanaServicios = new Catalogo_Servicio();
            ventanaServicios.Show();
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
