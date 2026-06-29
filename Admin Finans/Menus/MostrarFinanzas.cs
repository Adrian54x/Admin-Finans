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
            //if (sender == ingresosop1)
            //    return "ingreso";
            //else if (sender == egresosop2)
            //    return "egreso";
            //else
            //{
            //    messagebox.show("opcion no valida");
               return "egreso";
            //}
        }

        private void Cargar(object sender, EventArgs e)
        {
            Finansas tabla = new Finansas();
            Mostrar.DataSource = tabla.MostarDatos("Ingreso");
        }

        private void Regresar(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            MenuPrincipal regresar = new MenuPrincipal(panelPrincipal);
            panelPrincipal.Controls.Add(regresar);
        }
    }
}
