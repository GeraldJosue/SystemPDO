namespace SystemForms
{
    partial class Adelanto_Agregar
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
            this.pn_agregar = new System.Windows.Forms.Panel();
            this.rb_pagado = new System.Windows.Forms.RadioButton();
            this.rb_solicitado = new System.Windows.Forms.RadioButton();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.cb_colaborador = new System.Windows.Forms.ComboBox();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.lb_monto = new System.Windows.Forms.Label();
            this.lb_colaborador = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pn_agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_agregar
            // 
            this.pn_agregar.BackColor = System.Drawing.Color.White;
            this.pn_agregar.Controls.Add(this.rb_pagado);
            this.pn_agregar.Controls.Add(this.rb_solicitado);
            this.pn_agregar.Controls.Add(this.dt_fecha);
            this.pn_agregar.Controls.Add(this.lb_Estado);
            this.pn_agregar.Controls.Add(this.lb_fecha);
            this.pn_agregar.Controls.Add(this.cb_colaborador);
            this.pn_agregar.Controls.Add(this.tb_monto);
            this.pn_agregar.Controls.Add(this.lb_monto);
            this.pn_agregar.Controls.Add(this.lb_colaborador);
            this.pn_agregar.Controls.Add(this.lb_titulo);
            this.pn_agregar.Location = new System.Drawing.Point(140, 39);
            this.pn_agregar.Name = "pn_agregar";
            this.pn_agregar.Size = new System.Drawing.Size(856, 388);
            this.pn_agregar.TabIndex = 0;
            // 
            // rb_pagado
            // 
            this.rb_pagado.AutoSize = true;
            this.rb_pagado.Location = new System.Drawing.Point(504, 264);
            this.rb_pagado.Name = "rb_pagado";
            this.rb_pagado.Size = new System.Drawing.Size(62, 17);
            this.rb_pagado.TabIndex = 9;
            this.rb_pagado.TabStop = true;
            this.rb_pagado.Text = "Pagado";
            this.rb_pagado.UseVisualStyleBackColor = true;
            // 
            // rb_solicitado
            // 
            this.rb_solicitado.AutoSize = true;
            this.rb_solicitado.Location = new System.Drawing.Point(504, 234);
            this.rb_solicitado.Name = "rb_solicitado";
            this.rb_solicitado.Size = new System.Drawing.Size(71, 17);
            this.rb_solicitado.TabIndex = 8;
            this.rb_solicitado.TabStop = true;
            this.rb_solicitado.Text = "Solicitado";
            this.rb_solicitado.UseVisualStyleBackColor = true;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(501, 135);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(216, 20);
            this.dt_fecha.TabIndex = 7;
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Location = new System.Drawing.Point(498, 194);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(40, 13);
            this.lb_Estado.TabIndex = 6;
            this.lb_Estado.Text = "Estado";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Location = new System.Drawing.Point(498, 107);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(37, 13);
            this.lb_fecha.TabIndex = 5;
            this.lb_fecha.Text = "Fecha";
            // 
            // cb_colaborador
            // 
            this.cb_colaborador.FormattingEnabled = true;
            this.cb_colaborador.Location = new System.Drawing.Point(139, 135);
            this.cb_colaborador.Name = "cb_colaborador";
            this.cb_colaborador.Size = new System.Drawing.Size(223, 21);
            this.cb_colaborador.TabIndex = 4;
            this.cb_colaborador.SelectedIndexChanged += new System.EventHandler(this.cb_colaborador_SelectedIndexChanged);
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(142, 231);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(220, 20);
            this.tb_monto.TabIndex = 3;
            this.tb_monto.Enter += new System.EventHandler(this.tb_monto_enter);
            this.tb_monto.Leave += new System.EventHandler(this.tb_monto_leave);
            // 
            // lb_monto
            // 
            this.lb_monto.AutoSize = true;
            this.lb_monto.Location = new System.Drawing.Point(139, 194);
            this.lb_monto.Name = "lb_monto";
            this.lb_monto.Size = new System.Drawing.Size(37, 13);
            this.lb_monto.TabIndex = 2;
            this.lb_monto.Text = "Monto";
            // 
            // lb_colaborador
            // 
            this.lb_colaborador.AutoSize = true;
            this.lb_colaborador.Location = new System.Drawing.Point(136, 107);
            this.lb_colaborador.Name = "lb_colaborador";
            this.lb_colaborador.Size = new System.Drawing.Size(64, 13);
            this.lb_colaborador.TabIndex = 1;
            this.lb_colaborador.Text = "Colaborador";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(69, 25);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(174, 24);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Agregar Adelanto";
            // 
            // Adelanto_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_agregar);
            this.Name = "Adelanto_Agregar";
            this.Size = new System.Drawing.Size(1158, 458);
            this.pn_agregar.ResumeLayout(false);
            this.pn_agregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_agregar;
        private System.Windows.Forms.Label lb_colaborador;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.ComboBox cb_colaborador;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.Label lb_monto;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.RadioButton rb_pagado;
        private System.Windows.Forms.RadioButton rb_solicitado;
    }
}
