using Mis_finansas_Consola.General;

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
            asignatura = new TextBox();
            descripcion = new TextBox();
            fecha = new DateTimePicker();
            tipo = new ComboBox();
            monto = new NumericUpDown();
            codigo = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            opcionesIngreso = new MenuStrip();
            trabajoOp1 = new ToolStripMenuItem();
            asignaturasIOP1 = new ToolStripComboBox();
            bonoOp2 = new ToolStripMenuItem();
            asignaturasIOP2 = new ToolStripComboBox();
            regaloOp3 = new ToolStripMenuItem();
            asignaturasIOP3 = new ToolStripComboBox();
            opcionesEgreso = new MenuStrip();
            hogarOP1 = new ToolStripMenuItem();
            asignaturasEOP1 = new ToolStripComboBox();
            entretenimientoOP2 = new ToolStripMenuItem();
            asignaturasEOP2 = new ToolStripComboBox();
            emergenciaOp3 = new ToolStripMenuItem();
            asignaturasEOP3 = new ToolStripComboBox();
            gustoOp4 = new ToolStripMenuItem();
            asignaturasEOP4 = new ToolStripComboBox();
            panel2 = new Panel();
            regresar = new Button();
            agregar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monto).BeginInit();
            opcionesIngreso.SuspendLayout();
            opcionesEgreso.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(asignatura);
            panel1.Controls.Add(descripcion);
            panel1.Controls.Add(fecha);
            panel1.Controls.Add(tipo);
            panel1.Controls.Add(monto);
            panel1.Controls.Add(codigo);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(opcionesIngreso);
            panel1.Controls.Add(opcionesEgreso);
            panel1.Location = new Point(0, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 500);
            panel1.TabIndex = 0;
            // 
            // asignatura
            // 
            asignatura.BackColor = Color.LightBlue;
            asignatura.BorderStyle = BorderStyle.FixedSingle;
            asignatura.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            asignatura.ForeColor = Color.DarkSlateGray;
            asignatura.Location = new Point(581, 235);
            asignatura.Name = "asignatura";
            asignatura.ReadOnly = true;
            asignatura.Size = new Size(289, 37);
            asignatura.TabIndex = 12;
            asignatura.Click += Ver;
            // 
            // descripcion
            // 
            descripcion.BackColor = Color.LightBlue;
            descripcion.Font = new Font("Ebrima", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descripcion.ForeColor = Color.DarkSlateGray;
            descripcion.Location = new Point(85, 364);
            descripcion.MaxLength = 234;
            descripcion.Multiline = true;
            descripcion.Name = "descripcion";
            descripcion.Size = new Size(289, 44);
            descripcion.TabIndex = 11;
            descripcion.TextChanged += Tamaño;
            // 
            // fecha
            // 
            fecha.CalendarForeColor = Color.DarkSlateGray;
            fecha.CalendarMonthBackground = Color.LightBlue;
            fecha.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fecha.Format = DateTimePickerFormat.Short;
            fecha.Location = new Point(581, 101);
            fecha.MinDate = new DateTime(2026, 1, 1, 0, 0, 0, 0);
            fecha.Name = "fecha";
            fecha.Size = new Size(289, 37);
            fecha.TabIndex = 10;
            // 
            // tipo
            // 
            tipo.BackColor = Color.LightBlue;
            tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            tipo.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tipo.ForeColor = Color.DarkSlateGray;
            tipo.FormattingEnabled = true;
            tipo.Items.AddRange(new object[] { "Unico", "Semanal", "Mes", "Año" });
            tipo.Location = new Point(581, 364);
            tipo.Name = "tipo";
            tipo.Size = new Size(289, 39);
            tipo.TabIndex = 9;
            // 
            // monto
            // 
            monto.BackColor = Color.LightBlue;
            monto.DecimalPlaces = 2;
            monto.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monto.ForeColor = Color.DarkSlateGray;
            monto.Location = new Point(85, 235);
            monto.Maximum = new decimal(new int[] { 276447232, 23283, 0, 0 });
            monto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            monto.Name = "monto";
            monto.Size = new Size(289, 37);
            monto.TabIndex = 7;
            monto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // codigo
            // 
            codigo.BackColor = Color.LightBlue;
            codigo.BorderStyle = BorderStyle.FixedSingle;
            codigo.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            codigo.ForeColor = Color.DarkSlateGray;
            codigo.Location = new Point(85, 101);
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Size = new Size(289, 37);
            codigo.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Corbel", 18F, FontStyle.Bold);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(581, 194);
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
            label5.Location = new Point(581, 324);
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
            // opcionesIngreso
            // 
            opcionesIngreso.BackColor = Color.SkyBlue;
            opcionesIngreso.Dock = DockStyle.None;
            opcionesIngreso.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            opcionesIngreso.ImageScalingSize = new Size(20, 20);
            opcionesIngreso.Items.AddRange(new ToolStripItem[] { trabajoOp1, bonoOp2, regaloOp3 });
            opcionesIngreso.Location = new Point(581, 274);
            opcionesIngreso.Name = "opcionesIngreso";
            opcionesIngreso.Size = new Size(220, 26);
            opcionesIngreso.TabIndex = 13;
            opcionesIngreso.Text = "opcionesIngreso";
            // 
            // trabajoOp1
            // 
            trabajoOp1.DropDownItems.AddRange(new ToolStripItem[] { asignaturasIOP1 });
            trabajoOp1.ForeColor = SystemColors.ControlText;
            trabajoOp1.Name = "trabajoOp1";
            trabajoOp1.Size = new Size(79, 22);
            trabajoOp1.Text = "Trabajo";
            // 
            // asignaturasIOP1
            // 
            asignaturasIOP1.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasIOP1.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasIOP1.Items.AddRange(new object[] { "Trabajo" });
            asignaturasIOP1.Name = "asignaturasIOP1";
            asignaturasIOP1.Size = new Size(121, 28);
            asignaturasIOP1.SelectedIndexChanged += Asignar;
            // 
            // bonoOp2
            // 
            bonoOp2.DropDownItems.AddRange(new ToolStripItem[] { asignaturasIOP2 });
            bonoOp2.Name = "bonoOp2";
            bonoOp2.Size = new Size(59, 22);
            bonoOp2.Text = "Bono";
            // 
            // asignaturasIOP2
            // 
            asignaturasIOP2.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasIOP2.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasIOP2.Items.AddRange(new object[] { "Bono" });
            asignaturasIOP2.Name = "asignaturasIOP2";
            asignaturasIOP2.Size = new Size(121, 28);
            asignaturasIOP2.SelectedIndexChanged += Asignar;
            // 
            // regaloOp3
            // 
            regaloOp3.DropDownItems.AddRange(new ToolStripItem[] { asignaturasIOP3 });
            regaloOp3.ForeColor = Color.Black;
            regaloOp3.Name = "regaloOp3";
            regaloOp3.Size = new Size(74, 22);
            regaloOp3.Text = "Regalo";
            // 
            // asignaturasIOP3
            // 
            asignaturasIOP3.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasIOP3.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasIOP3.Items.AddRange(new object[] { "Regalo" });
            asignaturasIOP3.Name = "asignaturasIOP3";
            asignaturasIOP3.Size = new Size(121, 28);
            asignaturasIOP3.SelectedIndexChanged += Asignar;
            // 
            // opcionesEgreso
            // 
            opcionesEgreso.BackColor = Color.SkyBlue;
            opcionesEgreso.Dock = DockStyle.None;
            opcionesEgreso.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            opcionesEgreso.ImageScalingSize = new Size(20, 20);
            opcionesEgreso.Items.AddRange(new ToolStripItem[] { hogarOP1, entretenimientoOP2, emergenciaOp3, gustoOp4 });
            opcionesEgreso.Location = new Point(581, 302);
            opcionesEgreso.Name = "opcionesEgreso";
            opcionesEgreso.Size = new Size(391, 26);
            opcionesEgreso.TabIndex = 14;
            opcionesEgreso.Text = "OpcionesEgreso";
            // 
            // hogarOP1
            // 
            hogarOP1.DropDownItems.AddRange(new ToolStripItem[] { asignaturasEOP1 });
            hogarOP1.Name = "hogarOP1";
            hogarOP1.Size = new Size(67, 22);
            hogarOP1.Text = "Hogar";
            // 
            // asignaturasEOP1
            // 
            asignaturasEOP1.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasEOP1.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasEOP1.Items.AddRange(new object[] { "Hogar" });
            asignaturasEOP1.Name = "asignaturasEOP1";
            asignaturasEOP1.Size = new Size(121, 28);
            asignaturasEOP1.SelectedIndexChanged += Asignar;
            // 
            // entretenimientoOP2
            // 
            entretenimientoOP2.DropDownItems.AddRange(new ToolStripItem[] { asignaturasEOP2 });
            entretenimientoOP2.Name = "entretenimientoOP2";
            entretenimientoOP2.Size = new Size(142, 22);
            entretenimientoOP2.Text = "Entretenimiento";
            // 
            // asignaturasEOP2
            // 
            asignaturasEOP2.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasEOP2.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasEOP2.Items.AddRange(new object[] { "Entretenimiento" });
            asignaturasEOP2.Name = "asignaturasEOP2";
            asignaturasEOP2.Size = new Size(121, 28);
            asignaturasEOP2.SelectedIndexChanged += Asignar;
            // 
            // emergenciaOp3
            // 
            emergenciaOp3.DropDownItems.AddRange(new ToolStripItem[] { asignaturasEOP3 });
            emergenciaOp3.Name = "emergenciaOp3";
            emergenciaOp3.Size = new Size(109, 22);
            emergenciaOp3.Text = "Emergencia";
            // 
            // asignaturasEOP3
            // 
            asignaturasEOP3.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasEOP3.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasEOP3.Items.AddRange(new object[] { "Emergencia" });
            asignaturasEOP3.Name = "asignaturasEOP3";
            asignaturasEOP3.Size = new Size(121, 28);
            asignaturasEOP3.SelectedIndexChanged += Asignar;
            // 
            // gustoOp4
            // 
            gustoOp4.DropDownItems.AddRange(new ToolStripItem[] { asignaturasEOP4 });
            gustoOp4.Name = "gustoOp4";
            gustoOp4.Size = new Size(65, 22);
            gustoOp4.Text = "Gusto";
            // 
            // asignaturasEOP4
            // 
            asignaturasEOP4.BackColor = Color.FromArgb(224, 224, 224);
            asignaturasEOP4.DropDownStyle = ComboBoxStyle.DropDownList;
            asignaturasEOP4.Items.AddRange(new object[] { "Gusto" });
            asignaturasEOP4.Name = "asignaturasEOP4";
            asignaturasEOP4.Size = new Size(121, 28);
            asignaturasEOP4.SelectedIndexChanged += Asignar;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(regresar);
            panel2.Controls.Add(agregar);
            panel2.Location = new Point(1029, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(345, 498);
            panel2.TabIndex = 1;
            // 
            // regresar
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
            regresar.Name = "regresar";
            regresar.Size = new Size(290, 75);
            regresar.TabIndex = 1;
            regresar.Text = "Regresar";
            regresar.UseVisualStyleBackColor = false;
            regresar.Click += Regresar;
            // 
            // agregar
            // 
            agregar.BackColor = Color.DarkBlue;
            agregar.FlatAppearance.BorderColor = Color.Black;
            agregar.FlatAppearance.BorderSize = 2;
            agregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            agregar.FlatAppearance.MouseOverBackColor = Color.DarkBlue;
            agregar.FlatStyle = FlatStyle.Flat;
            agregar.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold);
            agregar.ForeColor = Color.LightSkyBlue;
            agregar.Location = new Point(26, 194);
            agregar.Name = "agregar";
            agregar.Size = new Size(290, 94);
            agregar.TabIndex = 0;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = false;
            agregar.Click += Agregar;
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
            Load += CargarCodigo;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monto).EndInit();
            opcionesIngreso.ResumeLayout(false);
            opcionesIngreso.PerformLayout();
            opcionesEgreso.ResumeLayout(false);
            opcionesEgreso.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button regresar;
        private Button agregar;
        private TextBox codigo;
        private TextBox descripcion;
        private TextBox asignatura;
        private ComboBox tipo;
        private NumericUpDown monto;
        private DateTimePicker fecha;
        private MenuStrip opcionesIngreso;
        private ToolStripMenuItem trabajoOp1;
        private ToolStripMenuItem bonoOp2;
        private ToolStripMenuItem regaloOp3;
        private ToolStripComboBox asignaturasIOP1;
        private ToolStripComboBox asignaturasIOP2;
        private ToolStripComboBox asignaturasIOP3;
        private MenuStrip opcionesEgreso;
        private ToolStripMenuItem hogarOP1;
        private ToolStripMenuItem entretenimientoOP2;
        private ToolStripMenuItem emergenciaOp3;
        private ToolStripMenuItem gustoOp4;
        private ToolStripComboBox asignaturasEOP1;
        private ToolStripComboBox asignaturasEOP2;
        private ToolStripComboBox asignaturasEOP3;
        private ToolStripComboBox asignaturasEOP4;
    }
}
