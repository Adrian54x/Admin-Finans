namespace Admin_Finans
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Opcion1 = new Button();
            Opcion2 = new Button();
            Opcion3 = new Button();
            panel1 = new Panel();
            Salir = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Opcion1
            // 
            Opcion1.BackColor = Color.Yellow;
            Opcion1.Cursor = Cursors.Hand;
            Opcion1.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            Opcion1.ForeColor = Color.DarkBlue;
            Opcion1.Location = new Point(0, 115);
            Opcion1.Margin = new Padding(4, 5, 4, 5);
            Opcion1.Name = "Opcion1";
            Opcion1.RightToLeft = RightToLeft.No;
            Opcion1.Size = new Size(307, 59);
            Opcion1.TabIndex = 0;
            Opcion1.Text = "Control de Finanzas";
            Opcion1.TextAlign = ContentAlignment.MiddleLeft;
            Opcion1.UseVisualStyleBackColor = false;
            // 
            // Opcion2
            // 
            Opcion2.BackColor = Color.Yellow;
            Opcion2.Cursor = Cursors.Hand;
            Opcion2.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            Opcion2.ForeColor = Color.DarkBlue;
            Opcion2.Location = new Point(0, 187);
            Opcion2.Margin = new Padding(4, 5, 4, 5);
            Opcion2.Name = "Opcion2";
            Opcion2.Size = new Size(211, 59);
            Opcion2.TabIndex = 1;
            Opcion2.Text = "Mis finanzas";
            Opcion2.TextAlign = ContentAlignment.MiddleLeft;
            Opcion2.UseVisualStyleBackColor = false;
            // 
            // Opcion3
            // 
            Opcion3.BackColor = Color.Yellow;
            Opcion3.Cursor = Cursors.Hand;
            Opcion3.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            Opcion3.ForeColor = Color.DarkBlue;
            Opcion3.Location = new Point(0, 256);
            Opcion3.Margin = new Padding(4, 5, 4, 5);
            Opcion3.Name = "Opcion3";
            Opcion3.Size = new Size(176, 59);
            Opcion3.TabIndex = 2;
            Opcion3.Text = "Estadisticas";
            Opcion3.TextAlign = ContentAlignment.MiddleLeft;
            Opcion3.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(Opcion1);
            panel1.Controls.Add(Salir);
            panel1.Controls.Add(Opcion2);
            panel1.Controls.Add(Opcion3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 410);
            panel1.TabIndex = 4;
            // 
            // Salir
            // 
            Salir.BackColor = Color.Yellow;
            Salir.Cursor = Cursors.Hand;
            Salir.Font = new Font("Corbel", 16.2F, FontStyle.Bold);
            Salir.ForeColor = Color.DarkBlue;
            Salir.Location = new Point(0, 325);
            Salir.Margin = new Padding(4, 5, 4, 5);
            Salir.Name = "Salir";
            Salir.Size = new Size(105, 57);
            Salir.TabIndex = 4;
            Salir.Text = "Salir";
            Salir.TextAlign = ContentAlignment.MiddleLeft;
            Salir.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGreen;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(139, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 81);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Turquoise;
            label1.Location = new Point(89, 22);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 0;
            label1.Text = "Admin Finans";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DeepSkyBlue;
            ClientSize = new Size(855, 409);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Menu";
            Text = "Admin finans";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Opcion1;
        private Button Opcion2;
        private Button Opcion3;
        private Button Salir;
        private Panel panel1;      
        private Panel panel2;
        private Label label1;
    }
}
