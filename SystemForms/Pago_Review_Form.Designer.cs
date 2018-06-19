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
            this.pn_agregarPago = new System.Windows.Forms.Panel();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.rb_inactivo = new System.Windows.Forms.RadioButton();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_bono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.nud_extras = new System.Windows.Forms.NumericUpDown();
            this.nud_horas = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_transferencia = new System.Windows.Forms.TextBox();
            this.lb_Transferencia = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.tb_neto = new System.Windows.Forms.TextBox();
            this.tb_rebajo = new System.Windows.Forms.TextBox();
            this.tb_bruto = new System.Windows.Forms.TextBox();
            this.lb_rebajo = new System.Windows.Forms.Label();
            this.lb_salarioNeto = new System.Windows.Forms.Label();
            this.lb_salarioBruto = new System.Windows.Forms.Label();
            this.lb_hasta = new System.Windows.Forms.Label();
            this.lb_desde = new System.Windows.Forms.Label();
            this.lb_Colaborador = new System.Windows.Forms.Label();
            this.rb_tramite = new System.Windows.Forms.RadioButton();
            this.rb_pagado = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pn_agregarPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_extras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_agregarPago
            // 
            this.pn_agregarPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_agregarPago.Controls.Add(this.panel2);
            this.pn_agregarPago.Controls.Add(this.panel1);
            this.pn_agregarPago.Controls.Add(this.bt_cancelar);
            this.pn_agregarPago.Controls.Add(this.bt_guardar);
            this.pn_agregarPago.Controls.Add(this.tb_bono);
            this.pn_agregarPago.Controls.Add(this.label1);
            this.pn_agregarPago.Controls.Add(this.lb_nombre);
            this.pn_agregarPago.Controls.Add(this.nud_extras);
            this.pn_agregarPago.Controls.Add(this.nud_horas);
            this.pn_agregarPago.Controls.Add(this.label14);
            this.pn_agregarPago.Controls.Add(this.label13);
            this.pn_agregarPago.Controls.Add(this.tb_transferencia);
            this.pn_agregarPago.Controls.Add(this.lb_Transferencia);
            this.pn_agregarPago.Controls.Add(this.dtp_hasta);
            this.pn_agregarPago.Controls.Add(this.dtp_desde);
            this.pn_agregarPago.Controls.Add(this.tb_neto);
            this.pn_agregarPago.Controls.Add(this.tb_rebajo);
            this.pn_agregarPago.Controls.Add(this.tb_bruto);
            this.pn_agregarPago.Controls.Add(this.lb_rebajo);
            this.pn_agregarPago.Controls.Add(this.lb_salarioNeto);
            this.pn_agregarPago.Controls.Add(this.lb_salarioBruto);
            this.pn_agregarPago.Controls.Add(this.lb_hasta);
            this.pn_agregarPago.Controls.Add(this.lb_desde);
            this.pn_agregarPago.Controls.Add(this.lb_Colaborador);
            this.pn_agregarPago.Location = new System.Drawing.Point(25, 25);
            this.pn_agregarPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_agregarPago.Name = "pn_agregarPago";
            this.pn_agregarPago.Size = new System.Drawing.Size(976, 329);
            this.pn_agregarPago.TabIndex = 1;
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
            this.bt_cancelar.Location = new System.Drawing.Point(891, 274);
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
            this.bt_guardar.Location = new System.Drawing.Point(808, 274);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 50);
            this.bt_guardar.TabIndex = 37;
            this.bt_guardar.Text = "Salvar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
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
            // tb_bono
            // 
            this.tb_bono.Location = new System.Drawing.Point(694, 18);
            this.tb_bono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_bono.Name = "tb_bono";
            this.tb_bono.Size = new System.Drawing.Size(142, 26);
            this.tb_bono.TabIndex = 33;
            this.tb_bono.Enter += new System.EventHandler(this.tb_bono_Enter);
            this.tb_bono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_bono_KeyPress);
            this.tb_bono.Leave += new System.EventHandler(this.tb_bono_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Bono";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(155, 24);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(68, 20);
            this.lb_nombre.TabIndex = 31;
            this.lb_nombre.Text = "Nombre";
            // 
            // nud_extras
            // 
            this.nud_extras.DecimalPlaces = 1;
            this.nud_extras.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_extras.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_extras.Location = new System.Drawing.Point(159, 198);
            this.nud_extras.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nud_extras.Name = "nud_extras";
            this.nud_extras.Size = new System.Drawing.Size(145, 26);
            this.nud_extras.TabIndex = 30;
            // 
            // nud_horas
            // 
            this.nud_horas.DecimalPlaces = 1;
            this.nud_horas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_horas.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_horas.Location = new System.Drawing.Point(159, 160);
            this.nud_horas.Maximum = new decimal(new int[] {
            239,
            0,
            0,
            65536});
            this.nud_horas.Name = "nud_horas";
            this.nud_horas.Size = new System.Drawing.Size(145, 26);
            this.nud_horas.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Hora laboradas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 204);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Horas extra";
            // 
            // tb_transferencia
            // 
            this.tb_transferencia.Location = new System.Drawing.Point(694, 198);
            this.tb_transferencia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_transferencia.Name = "tb_transferencia";
            this.tb_transferencia.Size = new System.Drawing.Size(142, 26);
            this.tb_transferencia.TabIndex = 20;
            // 
            // lb_Transferencia
            // 
            this.lb_Transferencia.AutoSize = true;
            this.lb_Transferencia.Location = new System.Drawing.Point(487, 204);
            this.lb_Transferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Transferencia.Name = "lb_Transferencia";
            this.lb_Transferencia.Size = new System.Drawing.Size(192, 20);
            this.lb_Transferencia.TabIndex = 17;
            this.lb_Transferencia.Text = "Número de Transferencia";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Location = new System.Drawing.Point(159, 116);
            this.dtp_hasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(250, 26);
            this.dtp_hasta.TabIndex = 12;
            // 
            // dtp_desde
            // 
            this.dtp_desde.Location = new System.Drawing.Point(159, 68);
            this.dtp_desde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(250, 26);
            this.dtp_desde.TabIndex = 11;
            // 
            // tb_neto
            // 
            this.tb_neto.Location = new System.Drawing.Point(694, 160);
            this.tb_neto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_neto.Name = "tb_neto";
            this.tb_neto.Size = new System.Drawing.Size(142, 26);
            this.tb_neto.TabIndex = 10;
            this.tb_neto.Enter += new System.EventHandler(this.tb_neto_Enter);
            this.tb_neto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_neto_KeyPress);
            this.tb_neto.Leave += new System.EventHandler(this.tb_neto_Leave);
            // 
            // tb_rebajo
            // 
            this.tb_rebajo.Location = new System.Drawing.Point(694, 68);
            this.tb_rebajo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_rebajo.Name = "tb_rebajo";
            this.tb_rebajo.Size = new System.Drawing.Size(142, 26);
            this.tb_rebajo.TabIndex = 9;
            this.tb_rebajo.Enter += new System.EventHandler(this.tb_rebajo_Enter);
            this.tb_rebajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_rebajo_KeyPress);
            this.tb_rebajo.Leave += new System.EventHandler(this.tb_rebajo_Leave);
            // 
            // tb_bruto
            // 
            this.tb_bruto.Location = new System.Drawing.Point(694, 116);
            this.tb_bruto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_bruto.Name = "tb_bruto";
            this.tb_bruto.Size = new System.Drawing.Size(142, 26);
            this.tb_bruto.TabIndex = 8;
            this.tb_bruto.Enter += new System.EventHandler(this.tb_bruto_Enter);
            this.tb_bruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_bruto_KeyPress);
            this.tb_bruto.Leave += new System.EventHandler(this.tb_bruto_Leave);
            // 
            // lb_rebajo
            // 
            this.lb_rebajo.AutoSize = true;
            this.lb_rebajo.Location = new System.Drawing.Point(487, 74);
            this.lb_rebajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_rebajo.Name = "lb_rebajo";
            this.lb_rebajo.Size = new System.Drawing.Size(61, 20);
            this.lb_rebajo.TabIndex = 7;
            this.lb_rebajo.Text = "Rebajo";
            // 
            // lb_salarioNeto
            // 
            this.lb_salarioNeto.AutoSize = true;
            this.lb_salarioNeto.Location = new System.Drawing.Point(487, 166);
            this.lb_salarioNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_salarioNeto.Name = "lb_salarioNeto";
            this.lb_salarioNeto.Size = new System.Drawing.Size(97, 20);
            this.lb_salarioNeto.TabIndex = 6;
            this.lb_salarioNeto.Text = "Salario Neto";
            // 
            // lb_salarioBruto
            // 
            this.lb_salarioBruto.AutoSize = true;
            this.lb_salarioBruto.Location = new System.Drawing.Point(487, 122);
            this.lb_salarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_salarioBruto.Name = "lb_salarioBruto";
            this.lb_salarioBruto.Size = new System.Drawing.Size(100, 20);
            this.lb_salarioBruto.TabIndex = 5;
            this.lb_salarioBruto.Text = "Salario bruto";
            // 
            // lb_hasta
            // 
            this.lb_hasta.AutoSize = true;
            this.lb_hasta.Location = new System.Drawing.Point(25, 122);
            this.lb_hasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_hasta.Name = "lb_hasta";
            this.lb_hasta.Size = new System.Drawing.Size(50, 20);
            this.lb_hasta.TabIndex = 4;
            this.lb_hasta.Text = "Hasta";
            // 
            // lb_desde
            // 
            this.lb_desde.AutoSize = true;
            this.lb_desde.Location = new System.Drawing.Point(25, 74);
            this.lb_desde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_desde.Name = "lb_desde";
            this.lb_desde.Size = new System.Drawing.Size(56, 20);
            this.lb_desde.TabIndex = 3;
            this.lb_desde.Text = "Desde";
            // 
            // lb_Colaborador
            // 
            this.lb_Colaborador.AutoSize = true;
            this.lb_Colaborador.Location = new System.Drawing.Point(25, 25);
            this.lb_Colaborador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Colaborador.Name = "lb_Colaborador";
            this.lb_Colaborador.Size = new System.Drawing.Size(104, 20);
            this.lb_Colaborador.TabIndex = 2;
            this.lb_Colaborador.Text = "Colaborador";
            // 
            // rb_tramite
            // 
            this.rb_tramite.AutoSize = true;
            this.rb_tramite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_tramite.Location = new System.Drawing.Point(243, 15);
            this.rb_tramite.Name = "rb_tramite";
            this.rb_tramite.Size = new System.Drawing.Size(99, 24);
            this.rb_tramite.TabIndex = 41;
            this.rb_tramite.Text = "En trámite";
            this.rb_tramite.UseVisualStyleBackColor = true;
            // 
            // rb_pagado
            // 
            this.rb_pagado.AutoSize = true;
            this.rb_pagado.Checked = true;
            this.rb_pagado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pagado.Location = new System.Drawing.Point(151, 15);
            this.rb_pagado.Name = "rb_pagado";
            this.rb_pagado.Size = new System.Drawing.Size(86, 24);
            this.rb_pagado.TabIndex = 40;
            this.rb_pagado.TabStop = true;
            this.rb_pagado.Text = "Pagado";
            this.rb_pagado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Proceso del Pago";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.rb_activo);
            this.panel1.Controls.Add(this.rb_inactivo);
            this.panel1.Location = new System.Drawing.Point(29, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 42);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rb_pagado);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rb_tramite);
            this.panel2.Location = new System.Drawing.Point(394, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 42);
            this.panel2.TabIndex = 43;
            // 
            // Pago_Review_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 376);
            this.Controls.Add(this.pn_agregarPago);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pago_Review_Form";
            this.Text = "Revisión de pago";
            this.pn_agregarPago.ResumeLayout(false);
            this.pn_agregarPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_extras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_agregarPago;
        private System.Windows.Forms.TextBox tb_transferencia;
        private System.Windows.Forms.Label lb_Transferencia;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.TextBox tb_neto;
        private System.Windows.Forms.TextBox tb_rebajo;
        private System.Windows.Forms.TextBox tb_bruto;
        private System.Windows.Forms.Label lb_rebajo;
        private System.Windows.Forms.Label lb_salarioNeto;
        private System.Windows.Forms.Label lb_salarioBruto;
        private System.Windows.Forms.Label lb_hasta;
        private System.Windows.Forms.Label lb_desde;
        private System.Windows.Forms.Label lb_Colaborador;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.NumericUpDown nud_extras;
        private System.Windows.Forms.NumericUpDown nud_horas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_bono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_inactivo;
        private System.Windows.Forms.RadioButton rb_activo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.RadioButton rb_tramite;
        private System.Windows.Forms.RadioButton rb_pagado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}