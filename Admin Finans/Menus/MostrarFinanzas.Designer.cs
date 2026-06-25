namespace Admin_Finans.Menus
{
    partial class MostrarFinanzas
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
            panel3 = new Panel();
            panel4 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            Mostrar = new DataGridView();
            opciones = new MenuStrip();
            ingresosOP1 = new ToolStripMenuItem();
            egresosOP2 = new ToolStripMenuItem();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Mostrar).BeginInit();
            opciones.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 150);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Location = new Point(457, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 150);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSkyBlue;
            panel3.Location = new Point(914, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(458, 150);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.ForestGreen;
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Location = new Point(1100, 150);
            panel4.Name = "panel4";
            panel4.Size = new Size(272, 488);
            panel4.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(38, 398);
            button4.Name = "button4";
            button4.Size = new Size(205, 53);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(51, 278);
            button3.Name = "button3";
            button3.Size = new Size(179, 76);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(51, 171);
            button2.Name = "button2";
            button2.Size = new Size(179, 76);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(38, 69);
            button1.Name = "button1";
            button1.Size = new Size(205, 43);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Mostrar
            // 
            Mostrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Mostrar.BackgroundColor = Color.SteelBlue;
            Mostrar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Mostrar.Location = new Point(0, 184);
            Mostrar.Name = "Mostrar";
            Mostrar.ReadOnly = true;
            Mostrar.RowHeadersWidth = 51;
            Mostrar.Size = new Size(1100, 454);
            Mostrar.TabIndex = 4;
            // 
            // opciones
            // 
            opciones.Dock = DockStyle.None;
            opciones.ImageScalingSize = new Size(20, 20);
            opciones.Items.AddRange(new ToolStripItem[] { ingresosOP1, egresosOP2 });
            opciones.Location = new Point(0, 153);
            opciones.Name = "opciones";
            opciones.Size = new Size(160, 28);
            opciones.TabIndex = 5;
            opciones.Text = "menuStrip1";
            // 
            // ingresosOP1
            // 
            ingresosOP1.Name = "ingresosOP1";
            ingresosOP1.Size = new Size(78, 24);
            ingresosOP1.Text = "Ingresos";
            // 
            // egresosOP2
            // 
            egresosOP2.Name = "egresosOP2";
            egresosOP2.Size = new Size(74, 24);
            egresosOP2.Text = "Egresos";
            // 
            // MostrarFinanzas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            Controls.Add(opciones);
            Controls.Add(Mostrar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MostrarFinanzas";
            Size = new Size(1372, 638);
            Load += Cargar;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Mostrar).EndInit();
            opciones.ResumeLayout(false);
            opciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView Mostrar;
        private MenuStrip opciones;
        private ToolStripMenuItem ingresosOP1;
        private ToolStripMenuItem egresosOP2;
    }
}
