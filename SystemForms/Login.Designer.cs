namespace SystemForms
{
    partial class Login
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
            this.pn_principal = new System.Windows.Forms.Panel();
            this.pn_login = new System.Windows.Forms.Panel();
            this.lb_contraseña = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.pn_menu_izq = new System.Windows.Forms.Panel();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.pn_principal.SuspendLayout();
            this.pn_login.SuspendLayout();
            this.pn_menu_izq.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_principal
            // 
            this.pn_principal.Controls.Add(this.pn_login);
            this.pn_principal.Location = new System.Drawing.Point(139, 3);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(1204, 517);
            this.pn_principal.TabIndex = 1;
            // 
            // pn_login
            // 
            this.pn_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_login.Controls.Add(this.lb_contraseña);
            this.pn_login.Controls.Add(this.lb_name);
            this.pn_login.Controls.Add(this.tb_usuario);
            this.pn_login.Controls.Add(this.bt_ingresar);
            this.pn_login.Controls.Add(this.tb_contraseña);
            this.pn_login.Location = new System.Drawing.Point(300, 114);
            this.pn_login.Name = "pn_login";
            this.pn_login.Size = new System.Drawing.Size(510, 282);
            this.pn_login.TabIndex = 4;
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.AutoSize = true;
            this.lb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña.Location = new System.Drawing.Point(141, 90);
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(87, 16);
            this.lb_contraseña.TabIndex = 5;
            this.lb_contraseña.Text = "Contraseña";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(138, 44);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(62, 16);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Usuario";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(138, 63);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(230, 20);
            this.tb_usuario.TabIndex = 2;
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.Firebrick;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar.Location = new System.Drawing.Point(138, 169);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(230, 50);
            this.bt_ingresar.TabIndex = 1;
            this.bt_ingresar.Text = "INGRESAR";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Location = new System.Drawing.Point(138, 112);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.Size = new System.Drawing.Size(230, 20);
            this.tb_contraseña.TabIndex = 3;
            // 
            // pn_menu_izq
            // 
            this.pn_menu_izq.BackColor = System.Drawing.Color.Gainsboro;
            this.pn_menu_izq.Controls.Add(this.bt_eliminar);
            this.pn_menu_izq.Controls.Add(this.bt_editar);
            this.pn_menu_izq.Controls.Add(this.bt_guardar);
            this.pn_menu_izq.Controls.Add(this.bt_agregar);
            this.pn_menu_izq.Location = new System.Drawing.Point(3, 3);
            this.pn_menu_izq.Name = "pn_menu_izq";
            this.pn_menu_izq.Size = new System.Drawing.Size(130, 517);
            this.pn_menu_izq.TabIndex = 2;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_eliminar.Enabled = false;
            this.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eliminar.Location = new System.Drawing.Point(27, 96);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 75);
            this.bt_eliminar.TabIndex = 1;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            // 
            // bt_editar
            // 
            this.bt_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_editar.Enabled = false;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.Location = new System.Drawing.Point(28, 177);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 75);
            this.bt_editar.TabIndex = 2;
            this.bt_editar.UseVisualStyleBackColor = true;
            // 
            // bt_guardar
            // 
            this.bt_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_guardar.Enabled = false;
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Location = new System.Drawing.Point(28, 258);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 75);
            this.bt_guardar.TabIndex = 3;
            this.bt_guardar.UseVisualStyleBackColor = true;
            // 
            // bt_agregar
            // 
            this.bt_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_agregar.Enabled = false;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Location = new System.Drawing.Point(27, 15);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 75);
            this.bt_agregar.TabIndex = 0;
            this.bt_agregar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_menu_izq);
            this.Controls.Add(this.pn_principal);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1346, 523);
            this.pn_principal.ResumeLayout(false);
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.pn_menu_izq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_principal;
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.Panel pn_menu_izq;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Label lb_contraseña;
        private System.Windows.Forms.Label lb_name;
    }
}
