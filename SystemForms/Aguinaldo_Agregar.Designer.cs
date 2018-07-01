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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aguinaldo_Agregar));
            this.pn_agregarAguinaldo = new System.Windows.Forms.Panel();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.tb_transferencia = new System.Windows.Forms.TextBox();
            this.lb_transferencia = new System.Windows.Forms.Label();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.lb_monto = new System.Windows.Forms.Label();
            this.lb_fecha = new System.Windows.Forms.Label();
            this.pn_agregarAguinaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_agregarAguinaldo
            // 
            this.pn_agregarAguinaldo.BackColor = System.Drawing.Color.White;
            this.pn_agregarAguinaldo.Controls.Add(this.bt_guardar);
            this.pn_agregarAguinaldo.Controls.Add(this.tb_transferencia);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_transferencia);
            this.pn_agregarAguinaldo.Controls.Add(this.tb_monto);
            this.pn_agregarAguinaldo.Controls.Add(this.dtp_fecha);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_monto);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_fecha);
            this.pn_agregarAguinaldo.Location = new System.Drawing.Point(25, 25);
            this.pn_agregarAguinaldo.Name = "pn_agregarAguinaldo";
            this.pn_agregarAguinaldo.Size = new System.Drawing.Size(665, 372);
            this.pn_agregarAguinaldo.TabIndex = 0;
            
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
            this.bt_guardar.Location = new System.Drawing.Point(485, 292);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 50);
            this.bt_guardar.TabIndex = 17;
            this.bt_guardar.Text = "Salvar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // tb_transferencia
            // 
            this.tb_transferencia.Location = new System.Drawing.Point(324, 217);
            this.tb_transferencia.Name = "tb_transferencia";
            this.tb_transferencia.Size = new System.Drawing.Size(236, 20);
            this.tb_transferencia.TabIndex = 10;
            // 
            // lb_transferencia
            // 
            this.lb_transferencia.AutoSize = true;
            this.lb_transferencia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_transferencia.Location = new System.Drawing.Point(114, 217);
            this.lb_transferencia.Name = "lb_transferencia";
            this.lb_transferencia.Size = new System.Drawing.Size(192, 20);
            this.lb_transferencia.TabIndex = 9;
            this.lb_transferencia.Text = "Numero de transferencia";
            // 
            // tb_monto
            // 
            this.tb_monto.Location = new System.Drawing.Point(324, 133);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(236, 20);
            this.tb_monto.TabIndex = 8;
            this.tb_monto.Enter += new System.EventHandler(this.tb_monto_enter);
            this.tb_monto.Leave += new System.EventHandler(this.tb_monto_leave);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Location = new System.Drawing.Point(324, 65);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(236, 20);
            this.dtp_fecha.TabIndex = 5;
            // 
            // lb_monto
            // 
            this.lb_monto.AutoSize = true;
            this.lb_monto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_monto.Location = new System.Drawing.Point(114, 133);
            this.lb_monto.Name = "lb_monto";
            this.lb_monto.Size = new System.Drawing.Size(137, 20);
            this.lb_monto.TabIndex = 4;
            this.lb_monto.Text = "Monto Aguinaldo";
            // 
            // lb_fecha
            // 
            this.lb_fecha.AutoSize = true;
            this.lb_fecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fecha.Location = new System.Drawing.Point(114, 65);
            this.lb_fecha.Name = "lb_fecha";
            this.lb_fecha.Size = new System.Drawing.Size(55, 20);
            this.lb_fecha.TabIndex = 2;
            this.lb_fecha.Text = "Fecha";
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
        private System.Windows.Forms.Label lb_fecha;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.TextBox tb_transferencia;
        private System.Windows.Forms.Label lb_transferencia;
        private System.Windows.Forms.Button bt_guardar;
    }
}
