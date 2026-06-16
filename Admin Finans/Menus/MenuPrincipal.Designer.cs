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
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // opcion1
            // 
            opcion1.BackColor = Color.Yellow;
            opcion1.FlatAppearance.BorderColor = Color.Black;
            opcion1.FlatAppearance.MouseDownBackColor = Color.Khaki;
            opcion1.FlatAppearance.MouseOverBackColor = Color.Yellow;
            opcion1.FlatStyle = FlatStyle.Flat;
            opcion1.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            opcion1.ForeColor = Color.DarkBlue;
            opcion1.Location = new Point(-1, 138);
            opcion1.Name = "opcion1";
            opcion1.Size = new Size(360, 70);
            opcion1.TabIndex = 0;
            opcion1.Text = "Control de Finanzas";
            opcion1.TextAlign = ContentAlignment.MiddleLeft;
            opcion1.UseVisualStyleBackColor = false;
            opcion1.Click += Opcion1;
            // 
            // opcion2
            // 
            opcion2.BackColor = Color.Yellow;
            opcion2.FlatAppearance.BorderColor = Color.Black;
            opcion2.FlatAppearance.MouseDownBackColor = Color.Khaki;
            opcion2.FlatAppearance.MouseOverBackColor = Color.Yellow;
            opcion2.FlatStyle = FlatStyle.Flat;
            opcion2.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            opcion2.ForeColor = Color.DarkBlue;
            opcion2.Location = new Point(-1, 226);
            opcion2.Name = "opcion2";
            opcion2.Size = new Size(302, 70);
            opcion2.TabIndex = 1;
            opcion2.Text = "Mis Finanzas";
            opcion2.TextAlign = ContentAlignment.MiddleLeft;
            opcion2.UseVisualStyleBackColor = false;
            // 
            // opcion3
            // 
            opcion3.BackColor = Color.Yellow;
            opcion3.FlatAppearance.BorderColor = Color.Black;
            opcion3.FlatAppearance.MouseDownBackColor = Color.Khaki;
            opcion3.FlatAppearance.MouseOverBackColor = Color.Yellow;
            opcion3.FlatStyle = FlatStyle.Flat;
            opcion3.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            opcion3.ForeColor = Color.DarkBlue;
            opcion3.Location = new Point(-1, 312);
            opcion3.Name = "opcion3";
            opcion3.Size = new Size(234, 70);
            opcion3.TabIndex = 2;
            opcion3.Text = "Estadisticas";
            opcion3.TextAlign = ContentAlignment.MiddleLeft;
            opcion3.UseVisualStyleBackColor = false;
            // 
            // salir
            // 
            salir.BackColor = Color.Yellow;
            salir.FlatAppearance.BorderColor = Color.Black;
            salir.FlatAppearance.MouseDownBackColor = Color.Khaki;
            salir.FlatAppearance.MouseOverBackColor = Color.Yellow;
            salir.FlatStyle = FlatStyle.Flat;
            salir.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            salir.ForeColor = Color.Red;
            salir.Location = new Point(-1, 399);
            salir.Name = "salir";
            salir.Size = new Size(155, 70);
            salir.TabIndex = 3;
            salir.Text = "Salir";
            salir.TextAlign = ContentAlignment.MiddleLeft;
            salir.UseVisualStyleBackColor = false;
            salir.Click += Salir;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(650, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 500);
            panel1.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SkyBlue;
            panel4.Location = new Point(13, 358);
            panel4.Name = "panel4";
            panel4.Size = new Size(225, 90);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Location = new Point(13, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 90);
            panel3.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Location = new Point(0, 196);
            panel5.Name = "panel5";
            panel5.Size = new Size(150, 45);
            panel5.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(142, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 80);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(85, 13);
            label1.Name = "label1";
            label1.Size = new Size(240, 45);
            label1.TabIndex = 0;
            label1.Text = "Admin Finans";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Orange;
            panel6.Location = new Point(650, 263);
            panel6.Name = "panel6";
            panel6.Size = new Size(150, 45);
            panel6.TabIndex = 7;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            Controls.Add(panel2);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(salir);
            Controls.Add(opcion3);
            Controls.Add(opcion2);
            Controls.Add(opcion1);
            Name = "MenuPrincipal";
            Size = new Size(900, 500);
            panel1.ResumeLayout(false);
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
        private Label label1;
    }
}
