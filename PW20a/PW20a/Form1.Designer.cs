namespace PW20a
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNocontrol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomalumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFechaing = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMesesaño = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbJunio = new System.Windows.Forms.RadioButton();
            this.rbMayo = new System.Windows.Forms.RadioButton();
            this.rbAbril = new System.Windows.Forms.RadioButton();
            this.rbMarzo = new System.Windows.Forms.RadioButton();
            this.rbFebrero = new System.Windows.Forms.RadioButton();
            this.rbEnero = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkJunio = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkAbril = new System.Windows.Forms.CheckBox();
            this.chkMarzo = new System.Windows.Forms.CheckBox();
            this.chkFebrero = new System.Windows.Forms.CheckBox();
            this.chkEnero = new System.Windows.Forms.CheckBox();
            this.dgvAgregar = new System.Windows.Forms.DataGridView();
            this.COM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NO_CONTROL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_ALUMNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APE_PATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APE_MATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes_Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSTITUTO TECNOLÓGICO DE NUEVO LEÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(170, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROGRAMACIÓN WEB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "No. Control:";
            // 
            // txtNocontrol
            // 
            this.txtNocontrol.Location = new System.Drawing.Point(183, 95);
            this.txtNocontrol.Multiline = true;
            this.txtNocontrol.Name = "txtNocontrol";
            this.txtNocontrol.Size = new System.Drawing.Size(153, 20);
            this.txtNocontrol.TabIndex = 3;
            this.txtNocontrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNocontrol_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Alumno:";
            // 
            // txtNomalumno
            // 
            this.txtNomalumno.Location = new System.Drawing.Point(183, 130);
            this.txtNomalumno.Multiline = true;
            this.txtNomalumno.Name = "txtNomalumno";
            this.txtNomalumno.Size = new System.Drawing.Size(389, 20);
            this.txtNomalumno.TabIndex = 5;
            this.txtNomalumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomalumno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Apellido Paterno:";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(183, 166);
            this.txtApaterno.Multiline = true;
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(264, 20);
            this.txtApaterno.TabIndex = 7;
            this.txtApaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApaterno_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "Apellido Materno:";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Location = new System.Drawing.Point(183, 204);
            this.txtAmaterno.Multiline = true;
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(264, 20);
            this.txtAmaterno.TabIndex = 9;
            this.txtAmaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmaterno_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // dtpFechaing
            // 
            this.dtpFechaing.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaing.Location = new System.Drawing.Point(183, 239);
            this.dtpFechaing.Name = "dtpFechaing";
            this.dtpFechaing.Size = new System.Drawing.Size(153, 20);
            this.dtpFechaing.TabIndex = 11;
            this.dtpFechaing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaing_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(12, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mes del Año:";
            // 
            // cboMesesaño
            // 
            this.cboMesesaño.FormattingEnabled = true;
            this.cboMesesaño.Items.AddRange(new object[] {
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
            this.cboMesesaño.Location = new System.Drawing.Point(183, 277);
            this.cboMesesaño.Name = "cboMesesaño";
            this.cboMesesaño.Size = new System.Drawing.Size(153, 21);
            this.cboMesesaño.TabIndex = 13;
            this.cboMesesaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMesesaño_KeyPress);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 61);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meses del Año";
            // 
            // rbJunio
            // 
            this.rbJunio.AutoSize = true;
            this.rbJunio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbJunio.Location = new System.Drawing.Point(400, 25);
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
            this.rbMayo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbMayo.Location = new System.Drawing.Point(326, 25);
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
            this.rbAbril.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbAbril.Location = new System.Drawing.Point(258, 25);
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
            this.rbMarzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbMarzo.Location = new System.Drawing.Point(178, 25);
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
            this.rbFebrero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbFebrero.Location = new System.Drawing.Point(85, 25);
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
            this.rbEnero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.rbEnero.Location = new System.Drawing.Point(6, 25);
            this.rbEnero.Name = "rbEnero";
            this.rbEnero.Size = new System.Drawing.Size(73, 23);
            this.rbEnero.TabIndex = 0;
            this.rbEnero.TabStop = true;
            this.rbEnero.Text = "Enero";
            this.rbEnero.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(16, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 61);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meses del Año";
            // 
            // chkJunio
            // 
            this.chkJunio.AutoSize = true;
            this.chkJunio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkJunio.Location = new System.Drawing.Point(405, 24);
            this.chkJunio.Name = "chkJunio";
            this.chkJunio.Size = new System.Drawing.Size(71, 23);
            this.chkJunio.TabIndex = 5;
            this.chkJunio.Text = "Junio";
            this.chkJunio.UseVisualStyleBackColor = true;
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkMayo.Location = new System.Drawing.Point(330, 24);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(69, 23);
            this.chkMayo.TabIndex = 4;
            this.chkMayo.Text = "Mayo";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkAbril
            // 
            this.chkAbril.AutoSize = true;
            this.chkAbril.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkAbril.Location = new System.Drawing.Point(261, 24);
            this.chkAbril.Name = "chkAbril";
            this.chkAbril.Size = new System.Drawing.Size(63, 23);
            this.chkAbril.TabIndex = 3;
            this.chkAbril.Text = "Abril";
            this.chkAbril.UseVisualStyleBackColor = true;
            // 
            // chkMarzo
            // 
            this.chkMarzo.AutoSize = true;
            this.chkMarzo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkMarzo.Location = new System.Drawing.Point(180, 24);
            this.chkMarzo.Name = "chkMarzo";
            this.chkMarzo.Size = new System.Drawing.Size(75, 23);
            this.chkMarzo.TabIndex = 2;
            this.chkMarzo.Text = "Marzo";
            this.chkMarzo.UseVisualStyleBackColor = true;
            // 
            // chkFebrero
            // 
            this.chkFebrero.AutoSize = true;
            this.chkFebrero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkFebrero.Location = new System.Drawing.Point(86, 24);
            this.chkFebrero.Name = "chkFebrero";
            this.chkFebrero.Size = new System.Drawing.Size(88, 23);
            this.chkFebrero.TabIndex = 1;
            this.chkFebrero.Text = "Febrero";
            this.chkFebrero.UseVisualStyleBackColor = true;
            // 
            // chkEnero
            // 
            this.chkEnero.AutoSize = true;
            this.chkEnero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkEnero.Location = new System.Drawing.Point(6, 24);
            this.chkEnero.Name = "chkEnero";
            this.chkEnero.Size = new System.Drawing.Size(74, 23);
            this.chkEnero.TabIndex = 0;
            this.chkEnero.Text = "Enero";
            this.chkEnero.UseVisualStyleBackColor = true;
            // 
            // dgvAgregar
            // 
            this.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COM,
            this.NO_CONTROL,
            this.NOM_ALUMNO,
            this.APE_PATERNO,
            this.APE_MATERNO,
            this.FECHA_INGRESO,
            this.Mes_Año});
            this.dgvAgregar.Location = new System.Drawing.Point(16, 449);
            this.dgvAgregar.Name = "dgvAgregar";
            this.dgvAgregar.Size = new System.Drawing.Size(596, 100);
            this.dgvAgregar.TabIndex = 16;
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
            // NOM_ALUMNO
            // 
            this.NOM_ALUMNO.HeaderText = "NOM_ALUMNO";
            this.NOM_ALUMNO.Name = "NOM_ALUMNO";
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
            // Mes_Año
            // 
            this.Mes_Año.HeaderText = "Mes_Año";
            this.Mes_Año.Name = "Mes_Año";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(516, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 17;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(430, 555);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 18;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 586);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvAgregar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboMesesaño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaing);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomalumno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNocontrol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNocontrol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomalumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFechaing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMesesaño;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbJunio;
        private System.Windows.Forms.RadioButton rbMayo;
        private System.Windows.Forms.RadioButton rbAbril;
        private System.Windows.Forms.RadioButton rbMarzo;
        private System.Windows.Forms.RadioButton rbFebrero;
        private System.Windows.Forms.RadioButton rbEnero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkJunio;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkAbril;
        private System.Windows.Forms.CheckBox chkMarzo;
        private System.Windows.Forms.CheckBox chkFebrero;
        private System.Windows.Forms.CheckBox chkEnero;
        private System.Windows.Forms.DataGridView dgvAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn COM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NO_CONTROL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOM_ALUMNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APE_PATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APE_MATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes_Año;
    }
}

