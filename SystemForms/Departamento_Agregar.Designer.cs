namespace SystemForms
{
    partial class Departamento_Agregar
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
            this.rb_inactivo = new System.Windows.Forms.RadioButton();
            this.rb_activo = new System.Windows.Forms.RadioButton();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.lb_estado = new System.Windows.Forms.Label();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.pn_agregarAguinaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_agregarAguinaldo
            // 
            this.pn_agregarAguinaldo.Controls.Add(this.rb_inactivo);
            this.pn_agregarAguinaldo.Controls.Add(this.rb_activo);
            this.pn_agregarAguinaldo.Controls.Add(this.tb_nombre);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_estado);
            this.pn_agregarAguinaldo.Controls.Add(this.lb_nombre);
            this.pn_agregarAguinaldo.Location = new System.Drawing.Point(56, 26);
            this.pn_agregarAguinaldo.Name = "pn_agregarAguinaldo";
            this.pn_agregarAguinaldo.Size = new System.Drawing.Size(959, 379);
            this.pn_agregarAguinaldo.TabIndex = 0;
            // 
            // rb_inactivo
            // 
            this.rb_inactivo.AutoSize = true;
            this.rb_inactivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_inactivo.Location = new System.Drawing.Point(387, 235);
            this.rb_inactivo.Name = "rb_inactivo";
            this.rb_inactivo.Size = new System.Drawing.Size(89, 24);
            this.rb_inactivo.TabIndex = 5;
            this.rb_inactivo.TabStop = true;
            this.rb_inactivo.Text = "Inactivo";
            this.rb_inactivo.UseVisualStyleBackColor = true;
            // 
            // rb_activo
            // 
            this.rb_activo.AutoSize = true;
            this.rb_activo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_activo.Location = new System.Drawing.Point(387, 199);
            this.rb_activo.Name = "rb_activo";
            this.rb_activo.Size = new System.Drawing.Size(76, 24);
            this.rb_activo.TabIndex = 4;
            this.rb_activo.TabStop = true;
            this.rb_activo.Text = "Activo";
            this.rb_activo.UseVisualStyleBackColor = true;
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(387, 101);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(301, 20);
            this.tb_nombre.TabIndex = 3;
            // 
            // lb_estado
            // 
            this.lb_estado.AutoSize = true;
            this.lb_estado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_estado.Location = new System.Drawing.Point(109, 199);
            this.lb_estado.Name = "lb_estado";
            this.lb_estado.Size = new System.Drawing.Size(196, 20);
            this.lb_estado.TabIndex = 2;
            this.lb_estado.Text = "Estado del departamento";
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre.Location = new System.Drawing.Point(109, 105);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(206, 20);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre del departamento";
            // 
            // Departamento_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_agregarAguinaldo);
            this.Name = "Departamento_Agregar";
            this.Size = new System.Drawing.Size(1164, 429);
            this.pn_agregarAguinaldo.ResumeLayout(false);
            this.pn_agregarAguinaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_agregarAguinaldo;
        private System.Windows.Forms.RadioButton rb_inactivo;
        private System.Windows.Forms.RadioButton rb_activo;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.Label lb_estado;
        private System.Windows.Forms.Label lb_nombre;
    }
}
