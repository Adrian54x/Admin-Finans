using Admin_Finans.Ingresos;
using Admin_Finans.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Admin_Finans
{
    public partial class ControlFinansas : UserControl
    {
        private Panel panelOriginal;
        public ControlFinansas(Panel original)
        {
            InitializeComponent();
            panelOriginal = original;
        }

        private void Regresar(object sender, EventArgs e)
        {
            panelOriginal.Controls.Clear();
            MenuPrincipal principal = new MenuPrincipal(panelOriginal);
            principal.Dock = DockStyle.Fill;
            panelOriginal.Controls.Add(principal);
        }

        private void TipoImgreso(object sender, EventArgs e) 
        {
            panelOriginal.Controls.Clear();
            string tipo = (sender == ingreso) ? "Ingreso" : (sender == egreso) ? "Egreso" : "";
            Ingreso tipoIngreso = new Ingreso(panelOriginal,tipo);
            tipoIngreso.Dock = DockStyle.Fill;
            panelOriginal.Controls.Add(tipoIngreso);
        }
    }
}
