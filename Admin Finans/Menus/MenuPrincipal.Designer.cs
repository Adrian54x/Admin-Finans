namespace Admin_Finans.Menus
{
    partial class MenuPrincipal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            opcion1 = new Button();
            opcion2 = new Button();
            opcion3 = new Button();
            salir = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            barra = new Panel();
            barraGusto = new Panel();
            barraGasto = new Panel();
            barraAhorro = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel9 = new Panel();
            gusto = new Label();
            panel8 = new Panel();
            gasto = new Label();
            panel7 = new Panel();
            ahorro = new Label();
            panel4 = new Panel();
            total = new Label();
            panel6 = new Panel();
            totalEgresos = new Label();
            panel5 = new Panel();
            totalIngreso = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            barra.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // opcion1
            // 
            opcion1.BackColor = Color.Yellow;
            opcion1.Cursor = Cursors.Hand;
            opcion1.FlatAppearance.BorderColor = Color.Black;
            opcion1.FlatAppearance.BorderSize = 2;
            opcion1.FlatAppearance.MouseDownBackColor = Color.Khaki;
            opcion1.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            opcion1.FlatStyle = FlatStyle.Flat;
            opcion1.Font = new Font("Corbel", 25.8000011F, FontStyle.Bold);
            opcion1.ForeColor = Color.DarkBlue;
            opcion1.Location = new Point(-1, 169);
            opcion1.Name = "opcion1";
            opcion1.Size = new Size(560, 90);
            opcion1.TabIndex = 0;
            opcion1.Text = "Control de Finanzas";
            opcion1.TextAlign = ContentAlignment.MiddleLeft;
            opcion1.UseVisualStyleBackColor = false;
            opcion1.Click += Opcion1;
            // 
            // opcion2
            // 
            opcion2.BackColor = Color.Yellow;
            opcion2.Cursor = Cursors.Hand;
            opcion2.FlatAppearance.BorderColor = Color.Black;
            opcion2.FlatAppearance.BorderSize = 2;
            opcion2.FlatAppearance.MouseDownBackColor = Color.Khaki;
            opcion2.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            opcion2.FlatStyle = FlatStyle.Flat;
            opcion2.Font = new Font("Corbel", 25.8000011F, FontStyle.Bold);
            opcion2.ForeColor = Color.DarkBlue;
            opcion2.Location = new Point(-1, 280);
            opcion2.Name = "opcion2";
            opcion2.Size = new Size(470, 90);
            opcion2.TabIndex = 1;
            opcion2.Text = "Mis Finanzas";
            opcion2.TextAlign = ContentAlignment.MiddleLeft;
            opcion2.UseVisualStyleBackColor = false;
            opcion2.Click += Opcion2;
            // 
            // opcion3
            // 
            opcion3.BackColor = Color.Yellow;
            opcion3.Cursor = Cursors.Hand;
            opcion3.FlatAppearance.BorderColor = Color.Black;
            opcion3.FlatAppearance.BorderSize = 2;
            opcion3.FlatAppearance.MouseDownBackColor = Color.Khaki;
            opcion3.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            opcion3.FlatStyle = FlatStyle.Flat;
            opcion3.Font = new Font("Corbel", 25.8000011F, FontStyle.Bold);
            opcion3.ForeColor = Color.DarkBlue;
            opcion3.Location = new Point(-1, 391);
            opcion3.Name = "opcion3";
            opcion3.Size = new Size(380, 90);
            opcion3.TabIndex = 2;
            opcion3.Text = "Estadisticas";
            opcion3.TextAlign = ContentAlignment.MiddleLeft;
            opcion3.UseVisualStyleBackColor = false;
            opcion3.Click += Opcion3;
            // 
            // salir
            // 
            salir.BackColor = Color.Yellow;
            salir.Cursor = Cursors.Hand;
            salir.FlatAppearance.BorderColor = Color.Black;
            salir.FlatAppearance.BorderSize = 2;
            salir.FlatAppearance.MouseDownBackColor = Color.Khaki;
            salir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            salir.FlatStyle = FlatStyle.Flat;
            salir.Font = new Font("Corbel", 25.8000011F, FontStyle.Bold);
            salir.ForeColor = Color.Red;
            salir.Location = new Point(-1, 504);
            salir.Name = "salir";
            salir.Size = new Size(250, 90);
            salir.TabIndex = 3;
            salir.Text = "Salir";
            salir.TextAlign = ContentAlignment.MiddleLeft;
            salir.UseVisualStyleBackColor = false;
            salir.Click += Salir;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(873, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 638);
            panel1.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Controls.Add(barra);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Location = new Point(51, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(415, 165);
            panel3.TabIndex = 0;
            // 
            // barra
            // 
            barra.Controls.Add(barraGusto);
            barra.Controls.Add(barraGasto);
            barra.Controls.Add(barraAhorro);
            barra.Location = new Point(32, 117);
            barra.Name = "barra";
            barra.Size = new Size(351, 37);
            barra.TabIndex = 5;
            // 
            // barraGusto
            // 
            barraGusto.BackColor = Color.Cyan;
            barraGusto.BorderStyle = BorderStyle.FixedSingle;
            barraGusto.Location = new Point(240, 0);
            barraGusto.Name = "barraGusto";
            barraGusto.Size = new Size(111, 34);
            barraGusto.TabIndex = 8;
            // 
            // barraGasto
            // 
            barraGasto.BackColor = Color.Crimson;
            barraGasto.BorderStyle = BorderStyle.FixedSingle;
            barraGasto.Location = new Point(120, 0);
            barraGasto.Name = "barraGasto";
            barraGasto.Size = new Size(120, 34);
            barraGasto.TabIndex = 6;
            // 
            // barraAhorro
            // 
            barraAhorro.BackColor = Color.Lime;
            barraAhorro.BorderStyle = BorderStyle.FixedSingle;
            barraAhorro.Location = new Point(0, 0);
            barraAhorro.Name = "barraAhorro";
            barraAhorro.Size = new Size(120, 34);
            barraAhorro.TabIndex = 6;
            // 
            // label7
            // 
            label7.BackColor = Color.SkyBlue;
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(293, 20);
            label7.Name = "label7";
            label7.Size = new Size(90, 25);
            label7.TabIndex = 1;
            label7.Text = "Gusto";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.SkyBlue;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(159, 20);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 4;
            label6.Text = "Gasto";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.SkyBlue;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(32, 20);
            label5.Name = "label5";
            label5.Size = new Size(90, 26);
            label5.TabIndex = 3;
            label5.Text = "Ahorro";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            panel9.BackColor = Color.SteelBlue;
            panel9.Controls.Add(gusto);
            panel9.Location = new Point(293, 57);
            panel9.Name = "panel9";
            panel9.Size = new Size(90, 50);
            panel9.TabIndex = 2;
            // 
            // gusto
            // 
            gusto.AutoSize = true;
            gusto.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gusto.ForeColor = Color.White;
            gusto.Location = new Point(18, 10);
            gusto.Name = "gusto";
            gusto.Size = new Size(60, 28);
            gusto.TabIndex = 0;
            gusto.Text = "30%";
            // 
            // panel8
            // 
            panel8.BackColor = Color.SteelBlue;
            panel8.Controls.Add(gasto);
            panel8.Location = new Point(159, 57);
            panel8.Name = "panel8";
            panel8.Size = new Size(90, 50);
            panel8.TabIndex = 1;
            // 
            // gasto
            // 
            gasto.AutoSize = true;
            gasto.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gasto.ForeColor = Color.White;
            gasto.Location = new Point(16, 10);
            gasto.Name = "gasto";
            gasto.Size = new Size(60, 28);
            gasto.TabIndex = 0;
            gasto.Text = "30%";
            // 
            // panel7
            // 
            panel7.BackColor = Color.SteelBlue;
            panel7.Controls.Add(ahorro);
            panel7.Location = new Point(32, 57);
            panel7.Name = "panel7";
            panel7.Size = new Size(90, 50);
            panel7.TabIndex = 0;
            // 
            // ahorro
            // 
            ahorro.AutoSize = true;
            ahorro.Font = new Font("Century", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ahorro.ForeColor = Color.White;
            ahorro.Location = new Point(16, 10);
            ahorro.Name = "ahorro";
            ahorro.Size = new Size(60, 28);
            ahorro.TabIndex = 8;
            ahorro.Text = "40%";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSkyBlue;
            panel4.Controls.Add(total);
            panel4.Location = new Point(51, 459);
            panel4.Name = "panel4";
            panel4.Size = new Size(415, 135);
            panel4.TabIndex = 0;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Corbel", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.DarkBlue;
            total.Location = new Point(3, 45);
            total.Name = "total";
            total.Size = new Size(179, 58);
            total.TabIndex = 0;
            total.Text = "Total:Q";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Orange;
            panel6.Controls.Add(totalEgresos);
            panel6.Location = new Point(0, 340);
            panel6.Name = "panel6";
            panel6.Size = new Size(311, 70);
            panel6.TabIndex = 7;
            // 
            // totalEgresos
            // 
            totalEgresos.AutoSize = true;
            totalEgresos.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalEgresos.ForeColor = Color.DarkBlue;
            totalEgresos.Location = new Point(0, 23);
            totalEgresos.Name = "totalEgresos";
            totalEgresos.Size = new Size(190, 28);
            totalEgresos.TabIndex = 0;
            totalEgresos.Text = "Total de Egrsos:Q";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Controls.Add(totalIngreso);
            panel5.Location = new Point(0, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(311, 70);
            panel5.TabIndex = 6;
            // 
            // totalIngreso
            // 
            totalIngreso.AutoSize = true;
            totalIngreso.Font = new Font("Corbel", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIngreso.ForeColor = Color.DarkBlue;
            totalIngreso.Location = new Point(0, 24);
            totalIngreso.Name = "totalIngreso";
            totalIngreso.Size = new Size(208, 28);
            totalIngreso.TabIndex = 0;
            totalIngreso.Text = "Total de Ingresos:Q";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(138, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 103);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(99, 17);
            label1.Name = "label1";
            label1.Size = new Size(383, 73);
            label1.TabIndex = 0;
            label1.Text = "Admin Finans";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(salir);
            Controls.Add(opcion3);
            Controls.Add(opcion2);
            Controls.Add(opcion1);
            Name = "MenuPrincipal";
            Size = new Size(1372, 638);
            Load += Cargar;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            barra.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button opcion1;
        private Button opcion2;
        private Button opcion3;
        private Button salir;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Label label1;
        private Label ahorro;
        private Label gasto;
        private Label gusto;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label totalIngreso;
        private Label totalEgresos;
        private Label total;
        private Panel barra;
        private Panel barraAhorro;
        private Panel barraGasto;
        private Panel barraGusto;
    }
}
