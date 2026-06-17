using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Admin_Finans.Ingresos
{
    public partial class Ingreso : UserControl
    {
        private Panel panelOriginal;
        public Ingreso(Panel panel, string tipo)
        {
            InitializeComponent();
            panelOriginal = panel;
            label1.Text = tipo;
        }

        private void Regresar(object sender, EventArgs e)
        {
            panelOriginal.Controls.Clear();
            ControlFinansas regresar = new ControlFinansas(panelOriginal);
            regresar.Dock = DockStyle.Fill;
            panelOriginal.Controls.Add(regresar);
        }
    }
}
