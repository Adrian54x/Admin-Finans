using Mis_finansas_Consola.General;
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

        private void Opcion2(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            MostrarFinanzas principal = new MostrarFinanzas(panelPrincipal);
            principal.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(principal);
        }

        private void Opcion3(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            Estadisticas principal = new Estadisticas(panelPrincipal);
            principal.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(principal);
        }

        private void Salir(object sender, EventArgs e)
        {
            FindForm().Close();
        }

        private void Cargar(object sender, EventArgs e)
        {
            ahorro.Text = DatosGlobales.Ahorro.ToString() + "%";
            gasto.Text = DatosGlobales.Gasto.ToString() + "%";
            gusto.Text = DatosGlobales.Gusto.ToString() + "%";
            totalIngreso.Text += DatosGlobales.TotalIngresos.ToString();
            totalEgresos.Text += DatosGlobales.TotalEgresos.ToString();
            total.Text += DatosGlobales.Total.ToString();
            int barAhorro = (int)(barra.Width * (int.Parse(DatosGlobales.Ahorro.ToString()) / 100.0));
            barraAhorro.Width = barAhorro;
            int barGasto = (int)(barra.Width * (int.Parse(DatosGlobales.Gasto.ToString()) / 100.0));
            barraGasto.Location = new Point(barAhorro, 0);
            barraGasto.Width = barGasto;
            int barGusto = (int)(barra.Width * (int.Parse(DatosGlobales.Gusto.ToString()) / 100.0));
            barraGusto.Location = new Point(barAhorro + barGasto, 0);
            barraGusto.Width = barGusto;
        }
    }
}
