namespace SystemForms
{
    partial class Aguinaldo_Agregar
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
            this.pn_agregarAguinaldo = new System.Windows.Forms.Panel();
            this.cb_estado = new System.Windows.Forms.CheckBox();
            this.lb_estado = new System.Windows.Forms.Label();
            this.tb_transferencia = new System.Windows.Forms.TextBox();
            this.lb_transferencia = new System.Windows.Forms.Label();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.cb_colaborador = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lb_monto = new System.Windows.Forms.Label();
            this.lb_colaborador = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.pn_agregarAguinaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_agregarAguinaldo
            // 
            this.pn_agregarAguinaldo.Controls.Add(this.cb_estado);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_estado);
            this.pn_agregarAguinaldo.Controls.Add(this.tb_transferencia);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_transferencia);
            this.pn_agregarAguinaldo.Controls.Add(this.tb_monto);
            this.pn_agregarAguinaldo.Controls.Add(this.cb_colaborador);
            this.pn_agregarAguinaldo.Controls.Add(this.dtp_fecha);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_monto);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_colaborador);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_fecha);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_titulo);
            this.pn_agregarAguinaldo.Location = new System.Drawing.Point(52, 26);
            this.pn_agregarAguinaldo.Name = "pn_agregarAguinaldo";
            this.pn_agregarAguinaldo.Size = new System.Drawing.Size(947, 454);
            this.pn_agregarAguinaldo.TabIndex = 0;
            // 
            // cb_estado
            // 
            this.cb_estado.AutoSize = true;
            this.cb_estado.Location = new System.Drawing.Point(428, 281);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(75, 17);
            this.cb_estado.TabIndex = 12;
            this.cb_estado.Text = "Entregado";
            this.cb_estado.UseVisualStyleBackColor = true;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Location = new System.Drawing.Point(425, 241);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(90, 13);
            this.lb_estado.TabIndex = 11;
            this.lb_estado.Text = "Estado Aguinaldo";
            // 
            // tb_transferencia
            // 
            this.tb_transferencia.Location = new System.Drawing.Point(428, 186);
            this.tb_transferencia.Name = "tb_transferencia";
            this.tb_transferencia.Size = new System.Drawing.Size(219, 20);
            this.tb_transferencia.TabIndex = 10;
            // 
            // lb_transferencia
            // 
            this.lb_transferencia.AutoSize = true;
            this.lb_transferencia.Location = new System.Drawing.Point(425, 161);
            this.lb_transferencia.Name = "lb_transferencia";
            this.lb_transferencia.Size = new System.Drawing.Size(123, 13);
            this.lb_transferencia.TabIndex = 9;
            this.lb_transferencia.Text = "Numero de transferencia";
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(133, 278);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(219, 20);
            this.tb_monto.TabIndex = 8;
            this.tb_monto.Enter += new System.EventHandler(this.tb_monto_enter);
            this.tb_monto.Leave += new System.EventHandler(this.tb_monto_leave);
            // 
            // cb_colaborador
            // 
            this.cb_colaborador.FormattingEnabled = true;
            this.cb_colaborador.Location = new System.Drawing.Point(133, 113);
            this.cb_colaborador.Name = "cb_colaborador";
            this.cb_colaborador.Size = new System.Drawing.Size(219, 21);
            this.cb_colaborador.TabIndex = 7;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(133, 186);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(219, 20);
            this.dtp_fecha.TabIndex = 5;
            // 
            // lb_monto
            // 
            this.lb_monto.AutoSize = true;
            this.lb_monto.Location = new System.Drawing.Point(130, 241);
            this.lb_monto.Name = "lb_monto";
            this.lb_monto.Size = new System.Drawing.Size(87, 13);
            this.lb_monto.TabIndex = 4;
            this.lb_monto.Text = "Monto Aguinaldo";
            // 
            // lb_colaborador
            // 
            this.lb_colaborador.AutoSize = true;
            this.lb_colaborador.Location = new System.Drawing.Point(130, 97);
            this.lb_colaborador.Name = "lb_colaborador";
            this.lb_colaborador.Size = new System.Drawing.Size(64, 13);
            this.lb_colaborador.TabIndex = 3;
            this.lb_colaborador.Text = "Colaborador";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Location = new System.Drawing.Point(130, 161);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(37, 13);
            this.lb_fecha.TabIndex = 2;
            this.lb_fecha.Text = "Fecha";
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(50, 31);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(169, 24);
            this.lb_titulo.TabIndex = 0;
            this.lb_titulo.Text = "Agregar Aguinaldo";
            // 
            // Aguinaldo_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_agregarAguinaldo);
            this.Name = "Aguinaldo_Agregar";
            this.Size = new System.Drawing.Size(1164, 516);
            this.pn_agregarAguinaldo.ResumeLayout(false);
            this.pn_agregarAguinaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_agregarAguinaldo;
        private System.Windows.Forms.Label lb_monto;
        private System.Windows.Forms.Label lb_colaborador;
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.ComboBox cb_colaborador;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox tb_transferencia;
        private System.Windows.Forms.Label lb_transferencia;
        private System.Windows.Forms.CheckBox cb_estado;
        private System.Windows.Forms.Label lb_estado;
    }
}
