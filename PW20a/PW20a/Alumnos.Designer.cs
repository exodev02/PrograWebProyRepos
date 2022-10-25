namespace PW20a
{
    partial class Alumnos
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNocontrol = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optUnionLibre = new System.Windows.Forms.RadioButton();
            this.optDivorciados = new System.Windows.Forms.RadioButton();
            this.optCasados = new System.Windows.Forms.RadioButton();
            this.optSoltero = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optFemenino = new System.Windows.Forms.RadioButton();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.cboCarreras = new System.Windows.Forms.ComboBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCambios = new System.Windows.Forms.Button();
            this.btnBajas = new System.Windows.Forms.Button();
            this.btnAltas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(52, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "INSTITUTO TECNOLOGICO DE NUEVO LEON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(196, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Catalogo de Alumnos";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(191, 244);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(153, 20);
            this.dtpFecha.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Location = new System.Drawing.Point(191, 209);
            this.txtAmaterno.Multiline = true;
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(264, 20);
            this.txtAmaterno.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apellido Materno:";
            // 
            // txtApaterno
            // 
            this.txtApaterno.Location = new System.Drawing.Point(191, 171);
            this.txtApaterno.Multiline = true;
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(264, 20);
            this.txtApaterno.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Apellido Paterno:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(191, 135);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nombre:";
            // 
            // txtNocontrol
            // 
            this.txtNocontrol.Location = new System.Drawing.Point(191, 100);
            this.txtNocontrol.Multiline = true;
            this.txtNocontrol.Name = "txtNocontrol";
            this.txtNocontrol.Size = new System.Drawing.Size(153, 20);
            this.txtNocontrol.TabIndex = 13;
            this.txtNocontrol.Click += new System.EventHandler(this.txtNocontrol_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "No. Control:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optUnionLibre);
            this.groupBox1.Controls.Add(this.optDivorciados);
            this.groupBox1.Controls.Add(this.optCasados);
            this.groupBox1.Controls.Add(this.optSoltero);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 60);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // optUnionLibre
            // 
            this.optUnionLibre.AutoSize = true;
            this.optUnionLibre.ForeColor = System.Drawing.Color.Black;
            this.optUnionLibre.Location = new System.Drawing.Point(456, 25);
            this.optUnionLibre.Name = "optUnionLibre";
            this.optUnionLibre.Size = new System.Drawing.Size(116, 23);
            this.optUnionLibre.TabIndex = 3;
            this.optUnionLibre.TabStop = true;
            this.optUnionLibre.Text = "Union Libre";
            this.optUnionLibre.UseVisualStyleBackColor = true;
            // 
            // optDivorciados
            // 
            this.optDivorciados.AutoSize = true;
            this.optDivorciados.ForeColor = System.Drawing.Color.Black;
            this.optDivorciados.Location = new System.Drawing.Point(288, 25);
            this.optDivorciados.Name = "optDivorciados";
            this.optDivorciados.Size = new System.Drawing.Size(129, 23);
            this.optDivorciados.TabIndex = 2;
            this.optDivorciados.TabStop = true;
            this.optDivorciados.Text = "Divorciado(a)";
            this.optDivorciados.UseVisualStyleBackColor = true;
            // 
            // optCasados
            // 
            this.optCasados.AutoSize = true;
            this.optCasados.ForeColor = System.Drawing.Color.Black;
            this.optCasados.Location = new System.Drawing.Point(151, 25);
            this.optCasados.Name = "optCasados";
            this.optCasados.Size = new System.Drawing.Size(105, 23);
            this.optCasados.TabIndex = 1;
            this.optCasados.TabStop = true;
            this.optCasados.Text = "Casado(a)";
            this.optCasados.UseVisualStyleBackColor = true;
            // 
            // optSoltero
            // 
            this.optSoltero.AutoSize = true;
            this.optSoltero.ForeColor = System.Drawing.Color.Black;
            this.optSoltero.Location = new System.Drawing.Point(6, 25);
            this.optSoltero.Name = "optSoltero";
            this.optSoltero.Size = new System.Drawing.Size(101, 23);
            this.optSoltero.TabIndex = 0;
            this.optSoltero.TabStop = true;
            this.optSoltero.Text = "Soltero(a)";
            this.optSoltero.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(20, 441);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Carreras:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optFemenino);
            this.groupBox2.Controls.Add(this.optMasculino);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 60);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clave Sexo";
            // 
            // optFemenino
            // 
            this.optFemenino.AutoSize = true;
            this.optFemenino.ForeColor = System.Drawing.Color.Black;
            this.optFemenino.Location = new System.Drawing.Point(359, 25);
            this.optFemenino.Name = "optFemenino";
            this.optFemenino.Size = new System.Drawing.Size(103, 23);
            this.optFemenino.TabIndex = 1;
            this.optFemenino.TabStop = true;
            this.optFemenino.Text = "Femenino";
            this.optFemenino.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.ForeColor = System.Drawing.Color.Black;
            this.optMasculino.Location = new System.Drawing.Point(113, 25);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(105, 23);
            this.optMasculino.TabIndex = 0;
            this.optMasculino.TabStop = true;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // cboCarreras
            // 
            this.cboCarreras.FormattingEnabled = true;
            this.cboCarreras.Location = new System.Drawing.Point(128, 442);
            this.cboCarreras.Name = "cboCarreras";
            this.cboCarreras.Size = new System.Drawing.Size(452, 21);
            this.cboCarreras.TabIndex = 24;
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(128, 484);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(452, 21);
            this.cboMaterias.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Materias:";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(24, 524);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(578, 102);
            this.dgvAlumnos.TabIndex = 27;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(527, 632);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCambios
            // 
            this.btnCambios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambios.Location = new System.Drawing.Point(422, 632);
            this.btnCambios.Name = "btnCambios";
            this.btnCambios.Size = new System.Drawing.Size(99, 23);
            this.btnCambios.TabIndex = 29;
            this.btnCambios.Text = "Cambios";
            this.btnCambios.UseVisualStyleBackColor = true;
            // 
            // btnBajas
            // 
            this.btnBajas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajas.Location = new System.Drawing.Point(341, 632);
            this.btnBajas.Name = "btnBajas";
            this.btnBajas.Size = new System.Drawing.Size(75, 23);
            this.btnBajas.TabIndex = 30;
            this.btnBajas.Text = "Bajas";
            this.btnBajas.UseVisualStyleBackColor = true;
            // 
            // btnAltas
            // 
            this.btnAltas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltas.Location = new System.Drawing.Point(260, 632);
            this.btnAltas.Name = "btnAltas";
            this.btnAltas.Size = new System.Drawing.Size(75, 23);
            this.btnAltas.TabIndex = 31;
            this.btnAltas.Text = "Altas";
            this.btnAltas.UseVisualStyleBackColor = true;
            // 
            // Alumnos
            // 
            this.ClientSize = new System.Drawing.Size(624, 661);
            this.Controls.Add(this.btnAltas);
            this.Controls.Add(this.btnBajas);
            this.Controls.Add(this.btnCambios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.cboCarreras);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAmaterno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNocontrol);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.Alumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNocontrol;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optUnionLibre;
        private System.Windows.Forms.RadioButton optDivorciados;
        private System.Windows.Forms.RadioButton optCasados;
        private System.Windows.Forms.RadioButton optSoltero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optFemenino;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboCarreras;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCambios;
        private System.Windows.Forms.Button btnBajas;
        private System.Windows.Forms.Button btnAltas;
    }
}