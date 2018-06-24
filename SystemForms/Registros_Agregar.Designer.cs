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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros_Agregar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.lb_colaborador = new System.Windows.Forms.Label();
            this.dg_horas_totales = new System.Windows.Forms.DataGridView();
            this.horas_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extras_totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_registros = new System.Windows.Forms.DataGridView();
            this.review = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_laboradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas_extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desayuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almuerzo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cafe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_colaborador = new System.Windows.Forms.ComboBox();
            this.cb_departamento = new System.Windows.Forms.ComboBox();
            this.pn_validacion = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bgw_registros = new System.ComponentModel.BackgroundWorker();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_horas_totales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dt_inicio);
            this.panel1.Controls.Add(this.dt_fin);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_guardar);
            this.panel1.Controls.Add(this.lb_colaborador);
            this.panel1.Controls.Add(this.dg_horas_totales);
            this.panel1.Controls.Add(this.dg_registros);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_colaborador);
            this.panel1.Controls.Add(this.cb_departamento);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 455);
            this.panel1.TabIndex = 0;
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.BackColor = System.Drawing.Color.DarkRed;
            this.bt_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.bt_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.bt_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.ForeColor = System.Drawing.Color.White;
            this.bt_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("bt_cancelar.Image")));
            this.bt_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_cancelar.Location = new System.Drawing.Point(1070, 392);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(80, 58);
            this.bt_cancelar.TabIndex = 45;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_cancelar.UseVisualStyleBackColor = false;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_guardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.bt_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.Color.White;
            this.bt_guardar.Image = ((System.Drawing.Image)(resources.GetObject("bt_guardar.Image")));
            this.bt_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_guardar.Location = new System.Drawing.Point(987, 392);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 58);
            this.bt_guardar.TabIndex = 44;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // lb_colaborador
            // 
            this.lb_colaborador.AutoSize = true;
            this.lb_colaborador.Location = new System.Drawing.Point(3, 50);
            this.lb_colaborador.Name = "lb_colaborador";
            this.lb_colaborador.Size = new System.Drawing.Size(97, 17);
            this.lb_colaborador.TabIndex = 43;
            this.lb_colaborador.Text = "Colaborador:";
            // 
            // dg_horas_totales
            // 
            this.dg_horas_totales.AllowUserToAddRows = false;
            this.dg_horas_totales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_horas_totales.BackgroundColor = System.Drawing.Color.White;
            this.dg_horas_totales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_horas_totales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.horas_totales,
            this.extras_totales});
            this.dg_horas_totales.EnableHeadersVisualStyles = false;
            this.dg_horas_totales.Location = new System.Drawing.Point(6, 392);
            this.dg_horas_totales.Name = "dg_horas_totales";
            this.dg_horas_totales.RowHeadersVisible = false;
            this.dg_horas_totales.Size = new System.Drawing.Size(505, 58);
            this.dg_horas_totales.TabIndex = 42;
            // 
            // horas_totales
            // 
            this.horas_totales.HeaderText = "Horas Laboradas Totales";
            this.horas_totales.Name = "horas_totales";
            // 
            // extras_totales
            // 
            this.extras_totales.HeaderText = "Horas Extras Totales";
            this.extras_totales.Name = "extras_totales";
            // 
            // dg_registros
            // 
            this.dg_registros.AllowUserToAddRows = false;
            this.dg_registros.AllowUserToDeleteRows = false;
            this.dg_registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_registros.BackgroundColor = System.Drawing.Color.White;
            this.dg_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.review,
            this.fecha,
            this.entrada,
            this.salida,
            this.horas_laboradas,
            this.horas_extras,
            this.desayuno,
            this.almuerzo,
            this.cafe});
            this.dg_registros.EnableHeadersVisualStyles = false;
            this.dg_registros.Location = new System.Drawing.Point(6, 90);
            this.dg_registros.Name = "dg_registros";
            this.dg_registros.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_registros.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_registros.Size = new System.Drawing.Size(1144, 296);
            this.dg_registros.TabIndex = 41;
            this.dg_registros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_registros_CellClick);
            this.dg_registros.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_registros_CellLeave);
            this.dg_registros.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_registros_CellValueChanged);
            // 
            // review
            // 
            this.review.HeaderText = "Habilitado";
            this.review.Name = "review";
            this.review.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // entrada
            // 
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            // 
            // salida
            // 
            this.salida.HeaderText = "Salida";
            this.salida.Name = "salida";
            // 
            // horas_laboradas
            // 
            this.horas_laboradas.HeaderText = "Horas Laboradas";
            this.horas_laboradas.Name = "horas_laboradas";
            // 
            // horas_extras
            // 
            this.horas_extras.HeaderText = "Horas Extras";
            this.horas_extras.Name = "horas_extras";
            // 
            // desayuno
            // 
            this.desayuno.HeaderText = "Desayuno";
            this.desayuno.Name = "desayuno";
            // 
            // almuerzo
            // 
            this.almuerzo.HeaderText = "Almuerzo";
            this.almuerzo.Name = "almuerzo";
            // 
            // cafe
            // 
            this.cafe.HeaderText = "Cafe";
            this.cafe.Name = "cafe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(856, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Colaborador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Departamento";
            // 
            // cb_colaborador
            // 
            this.cb_colaborador.FormattingEnabled = true;
            this.cb_colaborador.Location = new System.Drawing.Point(955, 4);
            this.cb_colaborador.Name = "cb_colaborador";
            this.cb_colaborador.Size = new System.Drawing.Size(200, 25);
            this.cb_colaborador.TabIndex = 17;
            this.cb_colaborador.SelectedIndexChanged += new System.EventHandler(this.cb_colaborador_SelectedIndexChanged);
            // 
            // cb_departamento
            // 
            this.cb_departamento.FormattingEnabled = true;
            this.cb_departamento.Location = new System.Drawing.Point(600, 4);
            this.cb_departamento.Name = "cb_departamento";
            this.cb_departamento.Size = new System.Drawing.Size(250, 25);
            this.cb_departamento.TabIndex = 16;
            // 
            // pn_validacion
            // 
            this.pn_validacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_validacion.Location = new System.Drawing.Point(867, 592);
            this.pn_validacion.Name = "pn_validacion";
            this.pn_validacion.Size = new System.Drawing.Size(257, 32);
            this.pn_validacion.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(495, 593);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 31);
            this.panel3.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(209, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 31);
            this.panel2.TabIndex = 33;
            // 
            // bgw_registros
            // 
            this.bgw_registros.WorkerReportsProgress = true;
            this.bgw_registros.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_registros_DoWork);
            this.bgw_registros.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_registros_ProgressChanged);
            this.bgw_registros.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_registros_RunWorkerCompleted);
            // 
            // dt_fin
            // 
            this.dt_fin.Location = new System.Drawing.Point(279, 6);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(200, 23);
            this.dt_fin.TabIndex = 46;
            this.dt_fin.ValueChanged += new System.EventHandler(this.dt_fin_ValueChanged);
            // 
            // dt_inicio
            // 
            this.dt_inicio.Location = new System.Drawing.Point(43, 6);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(200, 23);
            this.dt_inicio.TabIndex = 47;
            this.dt_inicio.ValueChanged += new System.EventHandler(this.dt_inicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Al:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Del:";
            // 
            // Registros_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_validacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "Registros_Agregar";
            this.Size = new System.Drawing.Size(1164, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_horas_totales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_departamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_colaborador;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pn_validacion;
        private System.Windows.Forms.DataGridView dg_registros;
        private System.Windows.Forms.DataGridView dg_horas_totales;
        private System.Windows.Forms.Label lb_colaborador;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn review;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_laboradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn desayuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn almuerzo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cafe;
        private System.ComponentModel.BackgroundWorker bgw_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn extras_totales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.DateTimePicker dt_fin;
    }
}
