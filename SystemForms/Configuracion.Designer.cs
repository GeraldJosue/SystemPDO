namespace SystemForms
{
    partial class Configuracion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_master = new System.Windows.Forms.Panel();
            this.pa_informacion = new System.Windows.Forms.Panel();
            this.num_porcent_hora_extra = new System.Windows.Forms.NumericUpDown();
            this.num_porcent_seguro = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pn_master.SuspendLayout();
            this.pa_informacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_porcent_hora_extra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_porcent_seguro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 55);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURACIÓN";
            // 
            // pn_master
            // 
            this.pn_master.Controls.Add(this.pa_informacion);
            this.pn_master.Controls.Add(this.label18);
            this.pn_master.Location = new System.Drawing.Point(0, 101);
            this.pn_master.Name = "pn_master";
            this.pn_master.Size = new System.Drawing.Size(1164, 502);
            this.pn_master.TabIndex = 13;
            // 
            // pa_informacion
            // 
            this.pa_informacion.BackColor = System.Drawing.Color.Transparent;
            this.pa_informacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_informacion.Controls.Add(this.num_porcent_hora_extra);
            this.pa_informacion.Controls.Add(this.num_porcent_seguro);
            this.pa_informacion.Controls.Add(this.label2);
            this.pa_informacion.Controls.Add(this.label3);
            this.pa_informacion.Location = new System.Drawing.Point(35, 68);
            this.pa_informacion.Name = "pa_informacion";
            this.pa_informacion.Size = new System.Drawing.Size(446, 234);
            this.pa_informacion.TabIndex = 20;
            // 
            // num_porcent_hora_extra
            // 
            this.num_porcent_hora_extra.DecimalPlaces = 2;
            this.num_porcent_hora_extra.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_porcent_hora_extra.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_porcent_hora_extra.Location = new System.Drawing.Point(253, 135);
            this.num_porcent_hora_extra.Name = "num_porcent_hora_extra";
            this.num_porcent_hora_extra.Size = new System.Drawing.Size(120, 26);
            this.num_porcent_hora_extra.TabIndex = 27;
            // 
            // num_porcent_seguro
            // 
            this.num_porcent_seguro.DecimalPlaces = 2;
            this.num_porcent_seguro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_porcent_seguro.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.num_porcent_seguro.Location = new System.Drawing.Point(253, 53);
            this.num_porcent_seguro.Name = "num_porcent_seguro";
            this.num_porcent_seguro.Size = new System.Drawing.Size(120, 26);
            this.num_porcent_seguro.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Porcentaje de hora extra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Porcentaje de seguro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(32, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(274, 18);
            this.label18.TabIndex = 21;
            this.label18.Text = "INFORMACIÓN DE CONFIGURACIÓN";
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
            this.bt_guardar.Location = new System.Drawing.Point(3, 609);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 50);
            this.bt_guardar.TabIndex = 14;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.pn_master);
            this.Controls.Add(this.panel1);
            this.Name = "Configuracion";
            this.Size = new System.Drawing.Size(1164, 662);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_master.ResumeLayout(false);
            this.pn_master.PerformLayout();
            this.pa_informacion.ResumeLayout(false);
            this.pa_informacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_porcent_hora_extra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_porcent_seguro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_master;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Panel pa_informacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_porcent_hora_extra;
        private System.Windows.Forms.NumericUpDown num_porcent_seguro;
    }
}
