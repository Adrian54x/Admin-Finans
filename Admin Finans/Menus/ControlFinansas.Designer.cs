namespace Admin_Finans
{
    partial class ControlFinansas
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
            panel2 = new Panel();
            label1 = new Label();
            regresar = new Button();
            deseo = new Button();
            presupuesto = new Button();
            egreso = new Button();
            ingreso = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(regresar);
            panel1.Controls.Add(deseo);
            panel1.Controls.Add(presupuesto);
            panel1.Controls.Add(egreso);
            panel1.Controls.Add(ingreso);
            panel1.Location = new Point(50, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 361);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(177, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 60);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGreen;
            label1.Location = new Point(75, 10);
            label1.Name = "label1";
            label1.Size = new Size(307, 41);
            label1.TabIndex = 0;
            label1.Text = "Control de Finansas";
            // 
            // regresar
            // 
            regresar.BackColor = Color.Yellow;
            regresar.FlatAppearance.BorderColor = Color.Black;
            regresar.FlatAppearance.MouseDownBackColor = Color.Khaki;
            regresar.FlatAppearance.MouseOverBackColor = Color.Yellow;
            regresar.FlatStyle = FlatStyle.Flat;
            regresar.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            regresar.ForeColor = Color.Red;
            regresar.Location = new Point(272, 270);
            regresar.Name = "regresar";
            regresar.Size = new Size(250, 60);
            regresar.TabIndex = 4;
            regresar.Text = "Regresar";
            regresar.UseVisualStyleBackColor = false;
            regresar.Click += Regresar;
            // 
            // deseo
            // 
            deseo.BackColor = Color.Yellow;
            deseo.FlatAppearance.BorderColor = Color.Black;
            deseo.FlatAppearance.MouseDownBackColor = Color.Khaki;
            deseo.FlatAppearance.MouseOverBackColor = Color.Yellow;
            deseo.FlatStyle = FlatStyle.Flat;
            deseo.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            deseo.ForeColor = Color.DarkBlue;
            deseo.Location = new Point(455, 189);
            deseo.Name = "deseo";
            deseo.Size = new Size(250, 60);
            deseo.TabIndex = 3;
            deseo.Text = "Deseo";
            deseo.UseVisualStyleBackColor = false;
            // 
            // presupuesto
            // 
            presupuesto.BackColor = Color.Yellow;
            presupuesto.FlatAppearance.BorderColor = Color.Black;
            presupuesto.FlatAppearance.MouseDownBackColor = Color.Khaki;
            presupuesto.FlatAppearance.MouseOverBackColor = Color.Yellow;
            presupuesto.FlatStyle = FlatStyle.Flat;
            presupuesto.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            presupuesto.ForeColor = Color.DarkBlue;
            presupuesto.Location = new Point(109, 189);
            presupuesto.Name = "presupuesto";
            presupuesto.Size = new Size(250, 60);
            presupuesto.TabIndex = 2;
            presupuesto.Text = "Presupuesto";
            presupuesto.UseVisualStyleBackColor = false;
            // 
            // egreso
            // 
            egreso.BackColor = Color.Yellow;
            egreso.FlatAppearance.BorderColor = Color.Black;
            egreso.FlatAppearance.MouseDownBackColor = Color.Khaki;
            egreso.FlatAppearance.MouseOverBackColor = Color.Yellow;
            egreso.FlatStyle = FlatStyle.Flat;
            egreso.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            egreso.ForeColor = Color.DarkBlue;
            egreso.Location = new Point(455, 110);
            egreso.Name = "egreso";
            egreso.Size = new Size(250, 60);
            egreso.TabIndex = 1;
            egreso.Text = "Egreso";
            egreso.UseVisualStyleBackColor = false;
            // 
            // ingreso
            // 
            ingreso.BackColor = Color.Yellow;
            ingreso.FlatAppearance.BorderColor = Color.Black;
            ingreso.FlatAppearance.MouseDownBackColor = Color.Khaki;
            ingreso.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ingreso.FlatStyle = FlatStyle.Flat;
            ingreso.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            ingreso.ForeColor = Color.DarkBlue;
            ingreso.Location = new Point(109, 110);
            ingreso.Name = "ingreso";
            ingreso.Size = new Size(250, 60);
            ingreso.TabIndex = 0;
            ingreso.Text = "Ingreso";
            ingreso.UseVisualStyleBackColor = false;
            // 
            // ControlFinansas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            Controls.Add(panel1);
            Name = "ControlFinansas";
            Size = new Size(900, 500);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button regresar;
        private Button deseo;
        private Button presupuesto;
        private Button egreso;
        private Button ingreso;
    }
}
