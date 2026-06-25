using Admin_Finans.Menus;
using Mis_finansas_Consola;

namespace Admin_Finans
{
    public partial class Ventana1 : Form
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void Cargar(object sender, EventArgs e)
        {
            Principal.Controls.Clear();
            MenuPrincipal menuPrincipal = new MenuPrincipal(Principal);
            menuPrincipal.Dock = DockStyle.Fill;
            Principal.Controls.Add(menuPrincipal);
            Finansas crear = new Finansas();
            crear.CrearTablas();
        }
    }
}
