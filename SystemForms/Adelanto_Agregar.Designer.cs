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
            this.rb_inactivo = new System.Windows.Forms.RadioButton();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.dt_fecha = new System.Windows.Forms.DateTimePicker();
            this.lb_Estado = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.cb_colaborador = new System.Windows.Forms.ComboBox();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.lb_monto = new System.Windows.Forms.Label();
            this.lb_colaborador = new System.Windows.Forms.Label();
            this.pn_agregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_agregar
            // 
            this.pn_agregar.BackColor = System.Drawing.Color.White;
            this.pn_agregar.Controls.Add(this.rb_inactivo);
            this.pn_agregar.Controls.Add(this.rb_activo);
            this.pn_agregar.Controls.Add(this.dt_fecha);
            this.pn_agregar.Controls.Add(this.lb_Estado);
            this.pn_agregar.Controls.Add(this.lb_fecha);
            this.pn_agregar.Controls.Add(this.cb_colaborador);
            this.pn_agregar.Controls.Add(this.tb_monto);
            this.pn_agregar.Controls.Add(this.lb_monto);
            this.pn_agregar.Controls.Add(this.lb_colaborador);
            this.pn_agregar.Location = new System.Drawing.Point(140, 39);
            this.pn_agregar.Name = "pn_agregar";
            this.pn_agregar.Size = new System.Drawing.Size(856, 388);
            this.pn_agregar.TabIndex = 0;
            // 
            // rb_inactivo
            // 
            this.rb_inactivo.AutoSize = true;
            this.rb_inactivo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactivo.Location = new System.Drawing.Point(662, 217);
            this.rb_inactivo.Name = "rb_inactivo";
            this.rb_inactivo.Size = new System.Drawing.Size(79, 21);
            this.rb_inactivo.TabIndex = 9;
            this.rb_inactivo.TabStop = true;
            this.rb_inactivo.Text = "Inactivo";
            this.rb_inactivo.UseVisualStyleBackColor = true;
            // 
            // rb_activo
            // 
            this.rb_activo.AutoSize = true;
            this.rb_activo.Checked = true;
            this.rb_activo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activo.Location = new System.Drawing.Point(578, 215);
            this.rb_activo.Name = "rb_activo";
            this.rb_activo.Size = new System.Drawing.Size(68, 21);
            this.rb_activo.TabIndex = 8;
            this.rb_activo.TabStop = true;
            this.rb_activo.Text = "Activo";
            this.rb_activo.UseVisualStyleBackColor = true;
            // 
            // dt_fecha
            // 
            this.dt_fecha.Location = new System.Drawing.Point(555, 110);
            this.dt_fecha.Name = "dt_fecha";
            this.dt_fecha.Size = new System.Drawing.Size(216, 20);
            this.dt_fecha.TabIndex = 7;
            // 
            // lb_Estado
            // 
            this.lb_Estado.AutoSize = true;
            this.lb_Estado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Estado.Location = new System.Drawing.Point(484, 214);
            this.lb_Estado.Name = "lb_Estado";
            this.lb_Estado.Size = new System.Drawing.Size(62, 20);
            this.lb_Estado.TabIndex = 6;
            this.lb_Estado.Text = "Estado:";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.Location = new System.Drawing.Point(484, 110);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(55, 20);
            this.lb_fecha.TabIndex = 5;
            this.lb_fecha.Text = "Fecha";
            // 
            // cb_colaborador
            // 
            this.cb_colaborador.FormattingEnabled = true;
            this.cb_colaborador.Location = new System.Drawing.Point(223, 109);
            this.cb_colaborador.Name = "cb_colaborador";
            this.cb_colaborador.Size = new System.Drawing.Size(223, 21);
            this.cb_colaborador.TabIndex = 4;
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(226, 212);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(220, 20);
            this.tb_monto.TabIndex = 3;
            this.tb_monto.Enter += new System.EventHandler(this.tb_monto_enter);
            this.tb_monto.Leave += new System.EventHandler(this.tb_monto_leave);
            // 
            // lb_monto
            // 
            this.lb_monto.AutoSize = true;
            this.lb_monto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_monto.Location = new System.Drawing.Point(113, 212);
            this.lb_monto.Name = "lb_monto";
            this.lb_monto.Size = new System.Drawing.Size(58, 20);
            this.lb_monto.TabIndex = 2;
            this.lb_monto.Text = "Monto";
            // 
            // lb_colaborador
            // 
            this.lb_colaborador.AutoSize = true;
            this.lb_colaborador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_colaborador.Location = new System.Drawing.Point(113, 110);
            this.lb_colaborador.Name = "lb_colaborador";
            this.lb_colaborador.Size = new System.Drawing.Size(104, 20);
            this.lb_colaborador.TabIndex = 1;
            this.lb_colaborador.Text = "Colaborador";
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
        private System.Windows.Forms.ComboBox cb_colaborador;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.Label lb_monto;
        private System.Windows.Forms.DateTimePicker dt_fecha;
        private System.Windows.Forms.Label lb_Estado;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.RadioButton rb_inactivo;
        private System.Windows.Forms.RadioButton rb_activo;
    }
}
