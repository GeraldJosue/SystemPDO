namespace SystemForms
{
    partial class Registros_Agregar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dt_salida = new System.Windows.Forms.DateTimePicker();
            this.dt_entrada = new System.Windows.Forms.DateTimePicker();
            this.dt_cafe = new System.Windows.Forms.DateTimePicker();
            this.dt_almuerzo = new System.Windows.Forms.DateTimePicker();
            this.dt_desayuno = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rb_invalido = new System.Windows.Forms.RadioButton();
            this.rb_valido = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_completo = new System.Windows.Forms.RadioButton();
            this.rb_proceso = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.nud_extras = new System.Windows.Forms.NumericUpDown();
            this.nud_horas = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_colaborador = new System.Windows.Forms.ComboBox();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.pn_validacion = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_extras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horas)).BeginInit();
            this.pn_validacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pn_validacion);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.nud_extras);
            this.panel1.Controls.Add(this.nud_horas);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_colaborador);
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(25, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 411);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dt_salida);
            this.panel4.Controls.Add(this.dt_entrada);
            this.panel4.Controls.Add(this.dt_cafe);
            this.panel4.Controls.Add(this.dt_almuerzo);
            this.panel4.Controls.Add(this.dt_desayuno);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(88, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 100);
            this.panel4.TabIndex = 35;
            // 
            // dt_salida
            // 
            this.dt_salida.CustomFormat = "";
            this.dt_salida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_salida.Location = new System.Drawing.Point(750, 50);
            this.dt_salida.Name = "dt_salida";
            this.dt_salida.ShowCheckBox = true;
            this.dt_salida.ShowUpDown = true;
            this.dt_salida.Size = new System.Drawing.Size(145, 26);
            this.dt_salida.TabIndex = 2;
            this.dt_salida.Value = new System.DateTime(2018, 6, 8, 17, 0, 0, 0);
            this.dt_salida.ValueChanged += new System.EventHandler(this.dt_salida_ValueChanged);
            // 
            // dt_entrada
            // 
            this.dt_entrada.CustomFormat = "";
            this.dt_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_entrada.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dt_entrada.Location = new System.Drawing.Point(66, 49);
            this.dt_entrada.Name = "dt_entrada";
            this.dt_entrada.ShowCheckBox = true;
            this.dt_entrada.ShowUpDown = true;
            this.dt_entrada.Size = new System.Drawing.Size(145, 26);
            this.dt_entrada.TabIndex = 0;
            this.dt_entrada.Value = new System.DateTime(2018, 6, 8, 6, 0, 0, 0);
            this.dt_entrada.ValueChanged += new System.EventHandler(this.dt_entrada_ValueChanged);
            // 
            // dt_cafe
            // 
            this.dt_cafe.CustomFormat = "";
            this.dt_cafe.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_cafe.Location = new System.Drawing.Point(579, 50);
            this.dt_cafe.Name = "dt_cafe";
            this.dt_cafe.ShowCheckBox = true;
            this.dt_cafe.ShowUpDown = true;
            this.dt_cafe.Size = new System.Drawing.Size(145, 26);
            this.dt_cafe.TabIndex = 3;
            this.dt_cafe.Value = new System.DateTime(2018, 6, 8, 0, 0, 0, 0);
            // 
            // dt_almuerzo
            // 
            this.dt_almuerzo.CustomFormat = "";
            this.dt_almuerzo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_almuerzo.Location = new System.Drawing.Point(408, 49);
            this.dt_almuerzo.Name = "dt_almuerzo";
            this.dt_almuerzo.ShowCheckBox = true;
            this.dt_almuerzo.ShowUpDown = true;
            this.dt_almuerzo.Size = new System.Drawing.Size(145, 26);
            this.dt_almuerzo.TabIndex = 4;
            this.dt_almuerzo.Value = new System.DateTime(2018, 6, 8, 0, 0, 0, 0);
            this.dt_almuerzo.ValueChanged += new System.EventHandler(this.dt_almuerzo_ValueChanged);
            // 
            // dt_desayuno
            // 
            this.dt_desayuno.CustomFormat = "";
            this.dt_desayuno.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_desayuno.Location = new System.Drawing.Point(237, 49);
            this.dt_desayuno.Name = "dt_desayuno";
            this.dt_desayuno.ShowCheckBox = true;
            this.dt_desayuno.ShowUpDown = true;
            this.dt_desayuno.Size = new System.Drawing.Size(145, 26);
            this.dt_desayuno.TabIndex = 5;
            this.dt_desayuno.Value = new System.DateTime(2018, 6, 8, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Desayuno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Almuerzo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Café";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(746, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salida";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rb_invalido);
            this.panel3.Controls.Add(this.rb_valido);
            this.panel3.Location = new System.Drawing.Point(652, 360);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 31);
            this.panel3.TabIndex = 34;
            // 
            // rb_invalido
            // 
            this.rb_invalido.AutoSize = true;
            this.rb_invalido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_invalido.Location = new System.Drawing.Point(83, 4);
            this.rb_invalido.Name = "rb_invalido";
            this.rb_invalido.Size = new System.Drawing.Size(87, 24);
            this.rb_invalido.TabIndex = 32;
            this.rb_invalido.Text = "Inválido";
            this.rb_invalido.UseVisualStyleBackColor = true;
            // 
            // rb_valido
            // 
            this.rb_valido.AutoSize = true;
            this.rb_valido.Checked = true;
            this.rb_valido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_valido.Location = new System.Drawing.Point(3, 4);
            this.rb_valido.Name = "rb_valido";
            this.rb_valido.Size = new System.Drawing.Size(74, 24);
            this.rb_valido.TabIndex = 31;
            this.rb_valido.TabStop = true;
            this.rb_valido.Text = "Válido";
            this.rb_valido.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_completo);
            this.panel2.Controls.Add(this.rb_proceso);
            this.panel2.Location = new System.Drawing.Point(196, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 31);
            this.panel2.TabIndex = 33;
            // 
            // rb_completo
            // 
            this.rb_completo.AutoSize = true;
            this.rb_completo.Checked = true;
            this.rb_completo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_completo.Location = new System.Drawing.Point(3, 4);
            this.rb_completo.Name = "rb_completo";
            this.rb_completo.Size = new System.Drawing.Size(100, 24);
            this.rb_completo.TabIndex = 28;
            this.rb_completo.TabStop = true;
            this.rb_completo.Text = "Completo";
            this.rb_completo.UseVisualStyleBackColor = true;
            // 
            // rb_proceso
            // 
            this.rb_proceso.AutoSize = true;
            this.rb_proceso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_proceso.Location = new System.Drawing.Point(109, 4);
            this.rb_proceso.Name = "rb_proceso";
            this.rb_proceso.Size = new System.Drawing.Size(109, 24);
            this.rb_proceso.TabIndex = 29;
            this.rb_proceso.Text = "En proceso";
            this.rb_proceso.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(495, 366);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = "Estado del registro";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(23, 366);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Proceso del registro";
            // 
            // nud_extras
            // 
            this.nud_extras.DecimalPlaces = 1;
            this.nud_extras.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_extras.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_extras.Location = new System.Drawing.Point(196, 284);
            this.nud_extras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_extras.Name = "nud_extras";
            this.nud_extras.Size = new System.Drawing.Size(145, 31);
            this.nud_extras.TabIndex = 26;
            // 
            // nud_horas
            // 
            this.nud_horas.DecimalPlaces = 1;
            this.nud_horas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_horas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_horas.Location = new System.Drawing.Point(196, 224);
            this.nud_horas.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            65536});
            this.nud_horas.Name = "nud_horas";
            this.nud_horas.Size = new System.Drawing.Size(145, 31);
            this.nud_horas.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 22);
            this.label14.TabIndex = 24;
            this.label14.Text = "Hora laboradas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "Horas extra";
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(2, 2);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(250, 26);
            this.dt_fecha.TabIndex = 22;
            this.dt_fecha.ValueChanged += new System.EventHandler(this.dt_fecha_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(770, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Fecha";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(404, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Colaborador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Departamento";
            // 
            // cb_colaborador
            // 
            this.cb_colaborador.FormattingEnabled = true;
            this.cb_colaborador.Location = new System.Drawing.Point(514, 18);
            this.cb_colaborador.Name = "cb_colaborador";
            this.cb_colaborador.Size = new System.Drawing.Size(250, 28);
            this.cb_colaborador.TabIndex = 17;
            this.cb_colaborador.SelectedIndexChanged += new System.EventHandler(this.cb_colaborador_SelectedIndexChanged);
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(148, 17);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(250, 28);
            this.cb_departamento.TabIndex = 16;
            // 
            // pn_validacion
            // 
            this.pn_validacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_validacion.Controls.Add(this.dt_fecha);
            this.pn_validacion.Location = new System.Drawing.Point(831, 14);
            this.pn_validacion.Name = "pn_validacion";
            this.pn_validacion.Size = new System.Drawing.Size(257, 32);
            this.pn_validacion.TabIndex = 36;
            // 
            // Registros_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "Registros_Agregar";
            this.Size = new System.Drawing.Size(1164, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_extras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horas)).EndInit();
            this.pn_validacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dt_entrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_desayuno;
        private System.Windows.Forms.DateTimePicker dt_almuerzo;
        private System.Windows.Forms.DateTimePicker dt_cafe;
        private System.Windows.Forms.DateTimePicker dt_salida;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.NumericUpDown nud_extras;
        private System.Windows.Forms.NumericUpDown nud_horas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_colaborador;
        private System.Windows.Forms.RadioButton rb_proceso;
        private System.Windows.Forms.RadioButton rb_completo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton rb_invalido;
        private System.Windows.Forms.RadioButton rb_valido;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pn_validacion;
    }
}
