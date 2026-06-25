using Admin_Finans.Ingresos;
using Mis_finansas_Consola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Admin_Finans.Menus
{
    public partial class MostrarFinanzas : UserControl
    {
        private Panel panelPrincipal;
        public MostrarFinanzas(Panel original)
        {
            InitializeComponent();
            panelPrincipal = original;
        }

        public void MostrarTabla(object sender, EventArgs e)
        {
            Finansas tabla = new Finansas();
            Mostrar.DataSource = tabla.MostarDatos(TipoTabla(sender, e));
        }

        public string TipoTabla(object sender, EventArgs e)
        {
            if (sender == ingresosOP1)
                return "Ingreso";
            else if (sender == egresosOP2)
                return "Egreso";
            else
            {
                MessageBox.Show("Opcion no valida");
                return "Egreso";
            }
        }

        private void Cargar(object sender, EventArgs e)
        {
            Finansas tabla = new Finansas();
            Mostrar.DataSource = tabla.MostarDatos("Ingreso");
        }
    }
}
