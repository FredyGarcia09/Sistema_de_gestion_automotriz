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
            // Creamos la nueva ventana
            Catalogo_Refacciones ventanaRefacciones = new Catalogo_Refacciones();
            // La mostramos
            ventanaRefacciones.Show();
            // Ocultamos el menú principal (no lo cerramos, para no matar la app)
            this.Hide();
        }
        private void AbrirNuevoFormulario()
        {
            // Cambia de form
            Application.Run(new Catalogo_Refacciones());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Catalogo_Servicio ventanaServicios = new Catalogo_Servicio();
            ventanaServicios.Show();
            this.Hide();
        }
        private void AbrirNuevoFormularioServicio()
        {
            // Cambia de form
            Application.Run(new Catalogo_Servicio());
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
