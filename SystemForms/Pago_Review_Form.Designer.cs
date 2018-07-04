namespace SystemForms
{
    partial class Pago_Review_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pago_Review_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.rb_inactivo = new System.Windows.Forms.RadioButton();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.dg_pago_detalle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_ingresos = new System.Windows.Forms.DataGridView();
            this.bono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aguinaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_deducciones = new System.Windows.Forms.DataGridView();
            this.adelanto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seguro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rebajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dg_totales = new System.Windows.Forms.DataGridView();
            this.bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pago_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ingresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_deducciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_totales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.rb_activo);
            this.panel1.Controls.Add(this.rb_inactivo);
            this.panel1.Location = new System.Drawing.Point(12, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 42);
            this.panel1.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Estado del Pago";
            // 
            // rb_activo
            // 
            this.rb_activo.AutoSize = true;
            this.rb_activo.Checked = true;
            this.rb_activo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activo.Location = new System.Drawing.Point(137, 13);
            this.rb_activo.Name = "rb_activo";
            this.rb_activo.Size = new System.Drawing.Size(74, 24);
            this.rb_activo.TabIndex = 35;
            this.rb_activo.TabStop = true;
            this.rb_activo.Text = "Válido";
            this.rb_activo.UseVisualStyleBackColor = true;
            // 
            // rb_inactivo
            // 
            this.rb_inactivo.AutoSize = true;
            this.rb_inactivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactivo.Location = new System.Drawing.Point(229, 13);
            this.rb_inactivo.Name = "rb_inactivo";
            this.rb_inactivo.Size = new System.Drawing.Size(87, 24);
            this.rb_inactivo.TabIndex = 36;
            this.rb_inactivo.Text = "Inválido";
            this.rb_inactivo.UseVisualStyleBackColor = true;
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
            this.bt_cancelar.Location = new System.Drawing.Point(95, 441);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(80, 50);
            this.bt_cancelar.TabIndex = 38;
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
            this.bt_guardar.Location = new System.Drawing.Point(12, 441);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 50);
            this.bt_guardar.TabIndex = 37;
            this.bt_guardar.Text = "Salvar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // dg_pago_detalle
            // 
            this.dg_pago_detalle.AllowUserToAddRows = false;
            this.dg_pago_detalle.AllowUserToDeleteRows = false;
            this.dg_pago_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_pago_detalle.BackgroundColor = System.Drawing.Color.White;
            this.dg_pago_detalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_pago_detalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_pago_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pago_detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colaborador,
            this.fecha,
            this.horas,
            this.extras,
            this.planilla});
            this.dg_pago_detalle.EnableHeadersVisualStyles = false;
            this.dg_pago_detalle.Location = new System.Drawing.Point(12, 42);
            this.dg_pago_detalle.Name = "dg_pago_detalle";
            this.dg_pago_detalle.ReadOnly = true;
            this.dg_pago_detalle.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_pago_detalle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_pago_detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pago_detalle.Size = new System.Drawing.Size(881, 60);
            this.dg_pago_detalle.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // colaborador
            // 
            this.colaborador.HeaderText = "Colaborador";
            this.colaborador.Name = "colaborador";
            this.colaborador.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas Laboradas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            // 
            // extras
            // 
            this.extras.HeaderText = "Horas Extras";
            this.extras.Name = "extras";
            this.extras.ReadOnly = true;
            // 
            // planilla
            // 
            this.planilla.HeaderText = "Planilla";
            this.planilla.Name = "planilla";
            this.planilla.ReadOnly = true;
            // 
            // dg_ingresos
            // 
            this.dg_ingresos.AllowUserToAddRows = false;
            this.dg_ingresos.AllowUserToDeleteRows = false;
            this.dg_ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ingresos.BackgroundColor = System.Drawing.Color.White;
            this.dg_ingresos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_ingresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ingresos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bono,
            this.vacaciones,
            this.aguinaldo});
            this.dg_ingresos.EnableHeadersVisualStyles = false;
            this.dg_ingresos.Location = new System.Drawing.Point(12, 128);
            this.dg_ingresos.Name = "dg_ingresos";
            this.dg_ingresos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_ingresos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_ingresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_ingresos.Size = new System.Drawing.Size(738, 60);
            this.dg_ingresos.TabIndex = 3;
            this.dg_ingresos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ingresos_CellEnter);
            // 
            // bono
            // 
            this.bono.HeaderText = "Bono";
            this.bono.Name = "bono";
            // 
            // vacaciones
            // 
            this.vacaciones.HeaderText = "Vacaciones";
            this.vacaciones.Name = "vacaciones";
            // 
            // aguinaldo
            // 
            this.aguinaldo.HeaderText = "Aguinaldo";
            this.aguinaldo.Name = "aguinaldo";
            // 
            // dg_deducciones
            // 
            this.dg_deducciones.AllowUserToAddRows = false;
            this.dg_deducciones.AllowUserToDeleteRows = false;
            this.dg_deducciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_deducciones.BackgroundColor = System.Drawing.Color.White;
            this.dg_deducciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_deducciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_deducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_deducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adelanto,
            this.seguro,
            this.rebajo});
            this.dg_deducciones.EnableHeadersVisualStyles = false;
            this.dg_deducciones.Location = new System.Drawing.Point(12, 214);
            this.dg_deducciones.Name = "dg_deducciones";
            this.dg_deducciones.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_deducciones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_deducciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_deducciones.Size = new System.Drawing.Size(738, 60);
            this.dg_deducciones.TabIndex = 4;
            this.dg_deducciones.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_deducciones_CellEnter);
            // 
            // adelanto
            // 
            this.adelanto.HeaderText = "Adelanto";
            this.adelanto.Name = "adelanto";
            // 
            // seguro
            // 
            this.seguro.HeaderText = "Seguro";
            this.seguro.Name = "seguro";
            // 
            // rebajo
            // 
            this.rebajo.HeaderText = "Rebajo";
            this.rebajo.Name = "rebajo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Información de pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingresos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Deducciones";
            // 
            // dg_totales
            // 
            this.dg_totales.AllowUserToAddRows = false;
            this.dg_totales.AllowUserToDeleteRows = false;
            this.dg_totales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_totales.BackgroundColor = System.Drawing.Color.White;
            this.dg_totales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_totales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dg_totales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_totales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bruto,
            this.neto});
            this.dg_totales.EnableHeadersVisualStyles = false;
            this.dg_totales.Location = new System.Drawing.Point(12, 300);
            this.dg_totales.Name = "dg_totales";
            this.dg_totales.ReadOnly = true;
            this.dg_totales.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dg_totales.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dg_totales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_totales.Size = new System.Drawing.Size(738, 60);
            this.dg_totales.TabIndex = 8;
            // 
            // bruto
            // 
            this.bruto.HeaderText = "Salario Bruto";
            this.bruto.Name = "bruto";
            this.bruto.ReadOnly = true;
            // 
            // neto
            // 
            this.neto.HeaderText = "Salario Neto";
            this.neto.Name = "neto";
            this.neto.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Saldo";
            // 
            // Pago_Review_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_totales);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dg_deducciones);
            this.Controls.Add(this.dg_ingresos);
            this.Controls.Add(this.dg_pago_detalle);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pago_Review_Form";
            this.Text = "Revisión de pago";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pago_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ingresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_deducciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_totales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rb_inactivo;
        private System.Windows.Forms.RadioButton rb_activo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_pago_detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn planilla;
        private System.Windows.Forms.DataGridView dg_ingresos;
        private System.Windows.Forms.DataGridViewTextBoxColumn bono;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn aguinaldo;
        private System.Windows.Forms.DataGridView dg_deducciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dg_totales;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn neto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn adelanto;
        private System.Windows.Forms.DataGridViewTextBoxColumn seguro;
        private System.Windows.Forms.DataGridViewTextBoxColumn rebajo;
    }
}