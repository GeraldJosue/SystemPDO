namespace SystemForms
{
    partial class Horarios_Agregar
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
            this.pa_informacion = new System.Windows.Forms.Panel();
            this.rb_inactivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_hora_fin = new System.Windows.Forms.DateTimePicker();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.dt_hora_inicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pa_informacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pa_informacion
            // 
            this.pa_informacion.BackColor = System.Drawing.Color.Transparent;
            this.pa_informacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pa_informacion.Controls.Add(this.rb_inactivo);
            this.pa_informacion.Controls.Add(this.label3);
            this.pa_informacion.Controls.Add(this.dt_hora_fin);
            this.pa_informacion.Controls.Add(this.rb_activo);
            this.pa_informacion.Controls.Add(this.dt_hora_inicio);
            this.pa_informacion.Controls.Add(this.label2);
            this.pa_informacion.Controls.Add(this.label1);
            this.pa_informacion.Controls.Add(this.label10);
            this.pa_informacion.Controls.Add(this.tb_nombre);
            this.pa_informacion.Location = new System.Drawing.Point(34, 69);
            this.pa_informacion.Name = "pa_informacion";
            this.pa_informacion.Size = new System.Drawing.Size(504, 283);
            this.pa_informacion.TabIndex = 0;
            // 
            // rb_inactivo
            // 
            this.rb_inactivo.AutoSize = true;
            this.rb_inactivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactivo.Location = new System.Drawing.Point(298, 200);
            this.rb_inactivo.Name = "rb_inactivo";
            this.rb_inactivo.Size = new System.Drawing.Size(89, 24);
            this.rb_inactivo.TabIndex = 27;
            this.rb_inactivo.TabStop = true;
            this.rb_inactivo.Text = "Inactivo";
            this.rb_inactivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Estado";
            // 
            // dt_hora_fin
            // 
            this.dt_hora_fin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_hora_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_hora_fin.Location = new System.Drawing.Point(187, 147);
            this.dt_hora_fin.Name = "dt_hora_fin";
            this.dt_hora_fin.ShowUpDown = true;
            this.dt_hora_fin.Size = new System.Drawing.Size(200, 26);
            this.dt_hora_fin.TabIndex = 25;
            // 
            // rb_activo
            // 
            this.rb_activo.AutoSize = true;
            this.rb_activo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activo.Location = new System.Drawing.Point(187, 200);
            this.rb_activo.Name = "rb_activo";
            this.rb_activo.Size = new System.Drawing.Size(76, 24);
            this.rb_activo.TabIndex = 26;
            this.rb_activo.TabStop = true;
            this.rb_activo.Text = "Activo";
            this.rb_activo.UseVisualStyleBackColor = true;
            // 
            // dt_hora_inicio
            // 
            this.dt_hora_inicio.CustomFormat = "";
            this.dt_hora_inicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_hora_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dt_hora_inicio.Location = new System.Drawing.Point(187, 96);
            this.dt_hora_inicio.Name = "dt_hora_inicio";
            this.dt_hora_inicio.ShowUpDown = true;
            this.dt_hora_inicio.Size = new System.Drawing.Size(200, 26);
            this.dt_hora_inicio.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Hora Fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Hora Inicio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nombre del horario";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.Location = new System.Drawing.Point(187, 45);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(275, 26);
            this.tb_nombre.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(31, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(220, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "INFORMACIÓN DEL HORARIO";
            // 
            // Horarios_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pa_informacion);
            this.Controls.Add(this.label18);
            this.Name = "Horarios_Agregar";
            this.Size = new System.Drawing.Size(1164, 461);
            this.pa_informacion.ResumeLayout(false);
            this.pa_informacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pa_informacion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_hora_fin;
        private System.Windows.Forms.DateTimePicker dt_hora_inicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_inactivo;
        private System.Windows.Forms.RadioButton rb_activo;
    }
}
