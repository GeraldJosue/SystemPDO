namespace SystemForms
{
    partial class Vacaciones_Agregar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_cantidad_dias = new System.Windows.Forms.TextBox();
            this.rb_inactivo = new System.Windows.Forms.RadioButton();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.dtp_fecha_regreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha_salida = new System.Windows.Forms.DateTimePicker();
            this.cb_colaborador = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_salario = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_dias_vacaciones_disp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_dias_vacaciones_disp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_cantidad_dias);
            this.panel1.Controls.Add(this.rb_inactivo);
            this.panel1.Controls.Add(this.rb_activo);
            this.panel1.Controls.Add(this.dtp_fecha_regreso);
            this.panel1.Controls.Add(this.dtp_fecha_salida);
            this.panel1.Controls.Add(this.cb_colaborador);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_salario);
            this.panel1.Location = new System.Drawing.Point(32, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 367);
            this.panel1.TabIndex = 1;
            // 
            // tb_cantidad_dias
            // 
            this.tb_cantidad_dias.Enabled = false;
            this.tb_cantidad_dias.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cantidad_dias.Location = new System.Drawing.Point(665, 153);
            this.tb_cantidad_dias.Name = "tb_cantidad_dias";
            this.tb_cantidad_dias.Size = new System.Drawing.Size(70, 26);
            this.tb_cantidad_dias.TabIndex = 25;
            // 
            // rb_inactivo
            // 
            this.rb_inactivo.AutoSize = true;
            this.rb_inactivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactivo.Location = new System.Drawing.Point(374, 271);
            this.rb_inactivo.Name = "rb_inactivo";
            this.rb_inactivo.Size = new System.Drawing.Size(89, 24);
            this.rb_inactivo.TabIndex = 24;
            this.rb_inactivo.TabStop = true;
            this.rb_inactivo.Text = "Inactivo";
            this.rb_inactivo.UseVisualStyleBackColor = true;
            // 
            // rb_activo
            // 
            this.rb_activo.AutoSize = true;
            this.rb_activo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activo.Location = new System.Drawing.Point(232, 271);
            this.rb_activo.Name = "rb_activo";
            this.rb_activo.Size = new System.Drawing.Size(76, 24);
            this.rb_activo.TabIndex = 23;
            this.rb_activo.TabStop = true;
            this.rb_activo.Text = "Activo";
            this.rb_activo.UseVisualStyleBackColor = true;
            // 
            // dtp_fecha_regreso
            // 
            this.dtp_fecha_regreso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_regreso.Location = new System.Drawing.Point(204, 153);
            this.dtp_fecha_regreso.Name = "dtp_fecha_regreso";
            this.dtp_fecha_regreso.Size = new System.Drawing.Size(275, 26);
            this.dtp_fecha_regreso.TabIndex = 20;
            this.dtp_fecha_regreso.ValueChanged += new System.EventHandler(this.dtp_fecha_regreso_ValueChanged);
            // 
            // dtp_fecha_salida
            // 
            this.dtp_fecha_salida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha_salida.Location = new System.Drawing.Point(204, 99);
            this.dtp_fecha_salida.Name = "dtp_fecha_salida";
            this.dtp_fecha_salida.Size = new System.Drawing.Size(275, 26);
            this.dtp_fecha_salida.TabIndex = 19;
            this.dtp_fecha_salida.ValueChanged += new System.EventHandler(this.dtp_fecha_salida_ValueChanged);
            // 
            // cb_colaborador
            // 
            this.cb_colaborador.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_colaborador.FormattingEnabled = true;
            this.cb_colaborador.Location = new System.Drawing.Point(204, 39);
            this.cb_colaborador.Name = "cb_colaborador";
            this.cb_colaborador.Size = new System.Drawing.Size(275, 28);
            this.cb_colaborador.TabIndex = 18;
            this.cb_colaborador.SelectedIndexChanged += new System.EventHandler(this.cb_colaborador_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(35, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Estado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(524, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cantidad de días";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Fecha Regreso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Fecha Salida";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Colaborador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salario Vacaciones";
            // 
            // tb_salario
            // 
            this.tb_salario.Enabled = false;
            this.tb_salario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salario.Location = new System.Drawing.Point(204, 211);
            this.tb_salario.Name = "tb_salario";
            this.tb_salario.Size = new System.Drawing.Size(275, 26);
            this.tb_salario.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(29, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(245, 18);
            this.label18.TabIndex = 20;
            this.label18.Text = "INFORMACIÓN DE VACACIONES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Días de vacaciones disponibles";
            // 
            // tb_dias_vacaciones_disp
            // 
            this.tb_dias_vacaciones_disp.Enabled = false;
            this.tb_dias_vacaciones_disp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dias_vacaciones_disp.Location = new System.Drawing.Point(769, 38);
            this.tb_dias_vacaciones_disp.Name = "tb_dias_vacaciones_disp";
            this.tb_dias_vacaciones_disp.Size = new System.Drawing.Size(71, 26);
            this.tb_dias_vacaciones_disp.TabIndex = 27;
            // 
            // Vacaciones_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
            this.Name = "Vacaciones_Agregar";
            this.Size = new System.Drawing.Size(1164, 516);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_salario;
        private System.Windows.Forms.DateTimePicker dtp_fecha_regreso;
        private System.Windows.Forms.DateTimePicker dtp_fecha_salida;
        private System.Windows.Forms.ComboBox cb_colaborador;
        private System.Windows.Forms.RadioButton rb_inactivo;
        private System.Windows.Forms.RadioButton rb_activo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_cantidad_dias;
        private System.Windows.Forms.TextBox tb_dias_vacaciones_disp;
        private System.Windows.Forms.Label label1;
    }
}
