using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Admin_Finans.Menus
{
    public partial class MenuPrincipal : UserControl
    {
        private Panel panelPrincipal;

        public MenuPrincipal(Panel original)
        {
            InitializeComponent();
            panelPrincipal = original;
        }

        private void Opcion1(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            ControlFinansas principal = new ControlFinansas(panelPrincipal);
            principal.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(principal);
        }

        private void Salir(object sender, EventArgs e)
        {
            FindForm().Close();
        }
    }
}
