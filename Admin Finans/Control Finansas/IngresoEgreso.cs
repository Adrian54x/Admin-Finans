using Mis_finansas_Consola.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Admin_Finans.Ingresos
{
    public partial class IngresoEgreso : UserControl
    {
        private Panel panelOriginal;
        private Funciones funcion = new Funciones();
        private int contCaracter1 = 0, contCaracter2 = 0;
        public IngresoEgreso(Panel panel, string tipo)
        {
            InitializeComponent();
            panelOriginal = panel;
            label1.Text = tipo;
            this.tipo.FlatStyle = FlatStyle.Popup;
            opcionesIngreso.Visible = false;
            opcionesEgreso.Visible = false;
        }

        private void Regresar(object sender, EventArgs e)
        {
            panelOriginal.Controls.Clear();
            ControlFinansas regresar = new ControlFinansas(panelOriginal);
            regresar.Dock = DockStyle.Fill;
            panelOriginal.Controls.Add(regresar);
        }

        private void Agregar(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Parse(this.fecha.Text);
                decimal monto = decimal.Parse(this.monto.Value.ToString());
                string tipo = this.tipo.Text;
                string descripcion = this.descripcion.Text;
                string asignatura = this.asignatura.Text;
                Transacciones agregar = new Transacciones(codigo.Text, fecha, monto, tipo, descripcion, asignatura);
            }
            catch (Exception ex) 
            {
                Console.Beep(1000, 1000);
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarCodigo(object sender, EventArgs e)
        {
            codigo.Text = (label1.Text == "Ingreso") ? "#I" + funcion.GeneradorCodigos(DatosGlobales.cantidadIngresos) : "#E" + funcion.GeneradorCodigos(DatosGlobales.cantidadEgresos);
        }

        private void Ver(object sender, EventArgs e)
        {
            if (label1.Text == "Ingreso")
            {
                opcionesIngreso.Visible = true;
            }
            else
            {
                opcionesEgreso.Location = new Point(581, 274);
                opcionesEgreso.Visible = true;
            }
        }


        private void Asignar(object sender, EventArgs e)
        {
            if (label1.Text == "Ingreso")
            {
                asignatura.Text = (sender == asignaturasIOP1) ? asignaturasIOP1.SelectedItem.ToString()
                                : (sender == asignaturasIOP2) ? asignaturasIOP2.SelectedItem.ToString()
                                : (sender == asignaturasIOP3) ? asignaturasIOP3.SelectedItem.ToString()
                                : "";
            }
            else
            {
                asignatura.Text = (sender == asignaturasEOP1) ? asignaturasEOP1.SelectedItem.ToString()
                                : (sender == asignaturasEOP2) ? asignaturasEOP2.SelectedItem.ToString()
                                : (sender == asignaturasEOP3) ? asignaturasEOP3.SelectedItem.ToString()
                                : (sender == asignaturasEOP4) ? asignaturasEOP4.SelectedItem.ToString() 
                                : "";
            }
        }

        private void Tamaño(object sender, EventArgs e)
        {

            if (descripcion.Text.Length == 79 && contCaracter1 == 0 || descripcion.Text.Length == 158 && contCaracter2 == 0)
            {
                descripcion.Height += 36;
                if (descripcion.Text.Length == 79)
                    contCaracter1++;
                if (descripcion.Text.Length == 158)
                    contCaracter2++;
            }
            else if (descripcion.Text.Length == 78 && contCaracter1 == 1 || descripcion.Text.Length == 157 && contCaracter2 == 1)
            {
                descripcion.Height -= 36;
                if (descripcion.Text.Length == 78)
                    contCaracter1--;
                if (descripcion.Text.Length == 15)
                    contCaracter2--;
            }
        }
    }
}
