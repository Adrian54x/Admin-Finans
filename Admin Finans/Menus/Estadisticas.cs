using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Admin_Finans.Menus
{
    public partial class Estadisticas : UserControl
    {
        private Panel panelPrincipal;
        public Estadisticas(Panel anterior)
        {
            InitializeComponent();
            panelPrincipal = anterior;
        }
    }
}
