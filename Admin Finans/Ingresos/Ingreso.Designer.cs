namespace Admin_Finans.Ingresos
{
    partial class Ingreso
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            regresar = new Button();
            Agregar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 500);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(581, 324);
            label7.Name = "label7";
            label7.Size = new Size(167, 37);
            label7.TabIndex = 5;
            label7.Text = "Asignatura:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(85, 324);
            label6.Name = "label6";
            label6.Size = new Size(176, 37);
            label6.TabIndex = 4;
            label6.Text = "Descripción:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(581, 194);
            label5.Name = "label5";
            label5.Size = new Size(84, 37);
            label5.TabIndex = 3;
            label5.Text = "Tipo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(85, 194);
            label4.Name = "label4";
            label4.Size = new Size(113, 37);
            label4.TabIndex = 2;
            label4.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(581, 61);
            label3.Name = "label3";
            label3.Size = new Size(102, 37);
            label3.TabIndex = 1;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(85, 61);
            label2.Name = "label2";
            label2.Size = new Size(119, 37);
            label2.TabIndex = 0;
            label2.Text = "Código:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(regresar);
            panel2.Controls.Add(Agregar);
            panel2.Location = new Point(1029, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 498);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            regresar.BackColor = Color.LightGreen;
            regresar.FlatAppearance.BorderColor = Color.Black;
            regresar.FlatAppearance.BorderSize = 2;
            regresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 255, 192);
            regresar.FlatAppearance.MouseOverBackColor = Color.LightGreen;
            regresar.FlatStyle = FlatStyle.Flat;
            regresar.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold);
            regresar.ForeColor = Color.Red;
            regresar.Location = new Point(26, 346);
            regresar.Name = "button2";
            regresar.Size = new Size(290, 75);
            regresar.TabIndex = 1;
            regresar.Text = "Regresar";
            regresar.UseVisualStyleBackColor = false;
            regresar.Click += Regresar;
            // 
            // button1
            // 
            Agregar.BackColor = Color.DarkBlue;
            Agregar.FlatAppearance.BorderColor = Color.Black;
            Agregar.FlatAppearance.BorderSize = 2;
            Agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            Agregar.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            Agregar.FlatStyle = FlatStyle.Flat;
            Agregar.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold);
            Agregar.ForeColor = Color.LightSkyBlue;
            Agregar.Location = new Point(26, 194);
            Agregar.Name = "button1";
            Agregar.Size = new Size(290, 94);
            Agregar.TabIndex = 0;
            Agregar.Text = "Agregar";
            Agregar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(286, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 92);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(316, 18);
            label1.Name = "label1";
            label1.Size = new Size(146, 58);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // Ingreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Ingreso";
            Size = new Size(1372, 638);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button regresar;
        private Button Agregar;
        private Panel panel3;
        private Label label1;
    }
}
