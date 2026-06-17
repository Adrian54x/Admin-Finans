namespace Admin_Finans
{
    partial class Ventana1
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
            Principal = new Panel();
            SuspendLayout();
            // 
            // Principal
            // 
            Principal.Dock = DockStyle.Fill;
            Principal.Location = new Point(0, 0);
            Principal.Name = "Principal";
            Principal.Size = new Size(1372, 638);
            Principal.TabIndex = 0;
            // 
            // Ventana1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1372, 638);
            Controls.Add(Principal);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(1390, 685);
            MinimumSize = new Size(1390, 685);
            Name = "Ventana1";
            Text = "Admin finans";
            Load += Cargar;
            ResumeLayout(false);
        }

        #endregion

        private Panel Principal;
    }
}
