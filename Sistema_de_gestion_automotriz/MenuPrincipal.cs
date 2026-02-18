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
            Application.Run(new Catalogo_Refacciones());
        }
    }
}
