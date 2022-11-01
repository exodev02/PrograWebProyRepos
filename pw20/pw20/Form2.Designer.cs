namespace pw20
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoctrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMesesdelaño = new System.Windows.Forms.ComboBox();
            this.dtpFecha_ing = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApe_materno = new System.Windows.Forms.TextBox();
            this.txtApe_paterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkJunio = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkAbril = new System.Windows.Forms.CheckBox();
            this.chkMarzo = new System.Windows.Forms.CheckBox();
            this.chkFebrero = new System.Windows.Forms.CheckBox();
            this.chkEnero = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbJunio = new System.Windows.Forms.RadioButton();
            this.rbMayo = new System.Windows.Forms.RadioButton();
            this.rbAbril = new System.Windows.Forms.RadioButton();
            this.rbMarzo = new System.Windows.Forms.RadioButton();
            this.rbFebrero = new System.Windows.Forms.RadioButton();
            this.rbEnero = new System.Windows.Forms.RadioButton();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.COM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_CONTROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APE_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APE_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(239, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "PROGRAMACION WEB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "INSTITUTO TECNOLOGICO DE NUEVO LEON";
            // 
            // txtNoctrl
            // 
            this.txtNoctrl.Location = new System.Drawing.Point(120, 95);
            this.txtNoctrl.Multiline = true;
            this.txtNoctrl.Name = "txtNoctrl";
            this.txtNoctrl.Size = new System.Drawing.Size(120, 20);
            this.txtNoctrl.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Control:";
            // 
            // cboMesesdelaño
            // 
            this.cboMesesdelaño.FormattingEnabled = true;
            this.cboMesesdelaño.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMesesdelaño.Location = new System.Drawing.Point(567, 168);
            this.cboMesesdelaño.Name = "cboMesesdelaño";
            this.cboMesesdelaño.Size = new System.Drawing.Size(201, 21);
            this.cboMesesdelaño.TabIndex = 23;
            // 
            // dtpFecha_ing
            // 
            this.dtpFecha_ing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha_ing.Location = new System.Drawing.Point(165, 165);
            this.dtpFecha_ing.Name = "dtpFecha_ing";
            this.dtpFecha_ing.Size = new System.Drawing.Size(197, 20);
            this.dtpFecha_ing.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(436, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Meses del Año:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(418, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Apellido Materno:";
            // 
            // txtApe_materno
            // 
            this.txtApe_materno.Location = new System.Drawing.Point(567, 132);
            this.txtApe_materno.Multiline = true;
            this.txtApe_materno.Name = "txtApe_materno";
            this.txtApe_materno.Size = new System.Drawing.Size(201, 20);
            this.txtApe_materno.TabIndex = 18;
            // 
            // txtApe_paterno
            // 
            this.txtApe_paterno.Location = new System.Drawing.Point(159, 132);
            this.txtApe_paterno.Multiline = true;
            this.txtApe_paterno.Name = "txtApe_paterno";
            this.txtApe_paterno.Size = new System.Drawing.Size(203, 20);
            this.txtApe_paterno.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(440, 95);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(328, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(269, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre del Alumno:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkJunio);
            this.groupBox2.Controls.Add(this.chkMayo);
            this.groupBox2.Controls.Add(this.chkAbril);
            this.groupBox2.Controls.Add(this.chkMarzo);
            this.groupBox2.Controls.Add(this.chkFebrero);
            this.groupBox2.Controls.Add(this.chkEnero);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(752, 66);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meses del Año";
            // 
            // chkJunio
            // 
            this.chkJunio.AutoSize = true;
            this.chkJunio.ForeColor = System.Drawing.Color.OliveDrab;
            this.chkJunio.Location = new System.Drawing.Point(675, 25);
            this.chkJunio.Name = "chkJunio";
            this.chkJunio.Size = new System.Drawing.Size(71, 23);
            this.chkJunio.TabIndex = 5;
            this.chkJunio.Text = "Junio";
            this.chkJunio.UseVisualStyleBackColor = true;
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.ForeColor = System.Drawing.Color.OliveDrab;
            this.chkMayo.Location = new System.Drawing.Point(551, 25);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(69, 23);
            this.chkMayo.TabIndex = 4;
            this.chkMayo.Text = "Mayo";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkAbril
            // 
            this.chkAbril.AutoSize = true;
            this.chkAbril.ForeColor = System.Drawing.Color.OliveDrab;
            this.chkAbril.Location = new System.Drawing.Point(424, 25);
            this.chkAbril.Name = "chkAbril";
            this.chkAbril.Size = new System.Drawing.Size(63, 23);
            this.chkAbril.TabIndex = 3;
            this.chkAbril.Text = "Abril";
            this.chkAbril.UseVisualStyleBackColor = true;
            // 
            // chkMarzo
            // 
            this.chkMarzo.AutoSize = true;
            this.chkMarzo.ForeColor = System.Drawing.Color.OliveDrab;
            this.chkMarzo.Location = new System.Drawing.Point(288, 26);
            this.chkMarzo.Name = "chkMarzo";
            this.chkMarzo.Size = new System.Drawing.Size(75, 23);
            this.chkMarzo.TabIndex = 2;
            this.chkMarzo.Text = "Marzo";
            this.chkMarzo.UseVisualStyleBackColor = true;
            // 
            // chkFebrero
            // 
            this.chkFebrero.AutoSize = true;
            this.chkFebrero.ForeColor = System.Drawing.Color.OliveDrab;
            this.chkFebrero.Location = new System.Drawing.Point(149, 26);
            this.chkFebrero.Name = "chkFebrero";
            this.chkFebrero.Size = new System.Drawing.Size(88, 23);
            this.chkFebrero.TabIndex = 1;
            this.chkFebrero.Text = "Febrero";
            this.chkFebrero.UseVisualStyleBackColor = true;
            // 
            // chkEnero
            // 
            this.chkEnero.AutoSize = true;
            this.chkEnero.ForeColor = System.Drawing.Color.OliveDrab;
            this.chkEnero.Location = new System.Drawing.Point(12, 26);
            this.chkEnero.Name = "chkEnero";
            this.chkEnero.Size = new System.Drawing.Size(74, 23);
            this.chkEnero.TabIndex = 0;
            this.chkEnero.Text = "Enero";
            this.chkEnero.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbJunio);
            this.groupBox1.Controls.Add(this.rbMayo);
            this.groupBox1.Controls.Add(this.rbAbril);
            this.groupBox1.Controls.Add(this.rbMarzo);
            this.groupBox1.Controls.Add(this.rbFebrero);
            this.groupBox1.Controls.Add(this.rbEnero);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(16, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 56);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meses del Año";
            // 
            // rbJunio
            // 
            this.rbJunio.AutoSize = true;
            this.rbJunio.ForeColor = System.Drawing.Color.OliveDrab;
            this.rbJunio.Location = new System.Drawing.Point(676, 20);
            this.rbJunio.Name = "rbJunio";
            this.rbJunio.Size = new System.Drawing.Size(70, 23);
            this.rbJunio.TabIndex = 5;
            this.rbJunio.TabStop = true;
            this.rbJunio.Text = "Junio";
            this.rbJunio.UseVisualStyleBackColor = true;
            // 
            // rbMayo
            // 
            this.rbMayo.AutoSize = true;
            this.rbMayo.ForeColor = System.Drawing.Color.OliveDrab;
            this.rbMayo.Location = new System.Drawing.Point(551, 20);
            this.rbMayo.Name = "rbMayo";
            this.rbMayo.Size = new System.Drawing.Size(68, 23);
            this.rbMayo.TabIndex = 4;
            this.rbMayo.TabStop = true;
            this.rbMayo.Text = "Mayo";
            this.rbMayo.UseVisualStyleBackColor = true;
            // 
            // rbAbril
            // 
            this.rbAbril.AutoSize = true;
            this.rbAbril.ForeColor = System.Drawing.Color.OliveDrab;
            this.rbAbril.Location = new System.Drawing.Point(424, 20);
            this.rbAbril.Name = "rbAbril";
            this.rbAbril.Size = new System.Drawing.Size(62, 23);
            this.rbAbril.TabIndex = 3;
            this.rbAbril.TabStop = true;
            this.rbAbril.Text = "Abril";
            this.rbAbril.UseVisualStyleBackColor = true;
            // 
            // rbMarzo
            // 
            this.rbMarzo.AutoSize = true;
            this.rbMarzo.ForeColor = System.Drawing.Color.OliveDrab;
            this.rbMarzo.Location = new System.Drawing.Point(288, 20);
            this.rbMarzo.Name = "rbMarzo";
            this.rbMarzo.Size = new System.Drawing.Size(74, 23);
            this.rbMarzo.TabIndex = 2;
            this.rbMarzo.TabStop = true;
            this.rbMarzo.Text = "Marzo";
            this.rbMarzo.UseVisualStyleBackColor = true;
            // 
            // rbFebrero
            // 
            this.rbFebrero.AutoSize = true;
            this.rbFebrero.ForeColor = System.Drawing.Color.OliveDrab;
            this.rbFebrero.Location = new System.Drawing.Point(149, 20);
            this.rbFebrero.Name = "rbFebrero";
            this.rbFebrero.Size = new System.Drawing.Size(87, 23);
            this.rbFebrero.TabIndex = 1;
            this.rbFebrero.TabStop = true;
            this.rbFebrero.Text = "Febrero";
            this.rbFebrero.UseVisualStyleBackColor = true;
            // 
            // rbEnero
            // 
            this.rbEnero.AutoSize = true;
            this.rbEnero.ForeColor = System.Drawing.Color.OliveDrab;
            this.rbEnero.Location = new System.Drawing.Point(12, 20);
            this.rbEnero.Name = "rbEnero";
            this.rbEnero.Size = new System.Drawing.Size(73, 23);
            this.rbEnero.TabIndex = 0;
            this.rbEnero.TabStop = true;
            this.rbEnero.Text = "Enero";
            this.rbEnero.UseVisualStyleBackColor = true;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COM,
            this.NO_CONTROL,
            this.NOMBRE,
            this.APE_PATERNO,
            this.APE_MATERNO,
            this.FECHA_INGRESO});
            this.dgvAgregar.Location = new System.Drawing.Point(16, 375);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.Size = new System.Drawing.Size(752, 146);
            this.dgvAgregar.TabIndex = 26;
            // 
            // COM
            // 
            this.COM.HeaderText = "COM";
            this.COM.Name = "COM";
            // 
            // NO_CONTROL
            // 
            this.NO_CONTROL.HeaderText = "NO_CONTROL";
            this.NO_CONTROL.Name = "NO_CONTROL";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // APE_PATERNO
            // 
            this.APE_PATERNO.HeaderText = "APE_PATERNO";
            this.APE_PATERNO.Name = "APE_PATERNO";
            // 
            // APE_MATERNO
            // 
            this.APE_MATERNO.HeaderText = "APE_MATERNO";
            this.APE_MATERNO.Name = "APE_MATERNO";
            // 
            // FECHA_INGRESO
            // 
            this.FECHA_INGRESO.HeaderText = "FECHA_INGRESO";
            this.FECHA_INGRESO.Name = "FECHA_INGRESO";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(688, 526);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(80, 23);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(607, 526);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 27;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMesesdelaño);
            this.Controls.Add(this.dtpFecha_ing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApe_materno);
            this.Controls.Add(this.txtApe_paterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoctrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoctrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMesesdelaño;
        private System.Windows.Forms.DateTimePicker dtpFecha_ing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApe_materno;
        private System.Windows.Forms.TextBox txtApe_paterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkJunio;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkAbril;
        private System.Windows.Forms.CheckBox chkMarzo;
        private System.Windows.Forms.CheckBox chkFebrero;
        private System.Windows.Forms.CheckBox chkEnero;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbJunio;
        private System.Windows.Forms.RadioButton rbMayo;
        private System.Windows.Forms.RadioButton rbAbril;
        private System.Windows.Forms.RadioButton rbMarzo;
        private System.Windows.Forms.RadioButton rbFebrero;
        private System.Windows.Forms.RadioButton rbEnero;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_CONTROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APE_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APE_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRESO;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAceptar;
    }
}