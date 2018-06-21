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
            this.pn_login = new System.Windows.Forms.Panel();
            this.lb_contraseña = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.bt_ingresar = new System.Windows.Forms.Button();
            this.tb_contraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_login.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_login
            // 
            this.pn_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_login.Controls.Add(this.lb_contraseña);
            this.pn_login.Controls.Add(this.lb_name);
            this.pn_login.Controls.Add(this.tb_usuario);
            this.pn_login.Controls.Add(this.bt_ingresar);
            this.pn_login.Controls.Add(this.tb_contraseña);
            this.pn_login.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_login.Location = new System.Drawing.Point(427, 255);
            this.pn_login.Name = "pn_login";
            this.pn_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pn_login.Size = new System.Drawing.Size(521, 252);
            this.pn_login.TabIndex = 4;
            // 
            // lb_contraseña
            // 
            this.lb_contraseña.AutoSize = true;
            this.lb_contraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contraseña.Location = new System.Drawing.Point(165, 105);
            this.lb_contraseña.Name = "lb_contraseña";
            this.lb_contraseña.Size = new System.Drawing.Size(93, 18);
            this.lb_contraseña.TabIndex = 5;
            this.lb_contraseña.Text = "Contraseña";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(165, 52);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(62, 18);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Usuario";
            // 
            // tb_usuario
            // 
            this.tb_usuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuario.Location = new System.Drawing.Point(264, 51);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(224, 26);
            this.tb_usuario.TabIndex = 2;
            this.tb_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_usuario_KeyPress);
            // 
            // bt_ingresar
            // 
            this.bt_ingresar.BackColor = System.Drawing.Color.CadetBlue;
            this.bt_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ingresar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ingresar.ForeColor = System.Drawing.Color.White;
            this.bt_ingresar.Location = new System.Drawing.Point(373, 150);
            this.bt_ingresar.Name = "bt_ingresar";
            this.bt_ingresar.Size = new System.Drawing.Size(123, 50);
            this.bt_ingresar.TabIndex = 1;
            this.bt_ingresar.Text = "INGRESAR";
            this.bt_ingresar.UseVisualStyleBackColor = false;
            this.bt_ingresar.Click += new System.EventHandler(this.bt_ingresar_Click);
            // 
            // tb_contraseña
            // 
            this.tb_contraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contraseña.Location = new System.Drawing.Point(264, 101);
            this.tb_contraseña.Name = "tb_contraseña";
            this.tb_contraseña.PasswordChar = '•';
            this.tb_contraseña.Size = new System.Drawing.Size(224, 26);
            this.tb_contraseña.TabIndex = 3;
            this.tb_contraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_contraseña_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 100);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1278, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "SPDO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribuidora de Carnes Oviedo ";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pn_login);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1364, 662);
            this.pn_login.ResumeLayout(false);
            this.pn_login.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_contraseña;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.Button bt_ingresar;
        private System.Windows.Forms.Panel pn_login;
        private System.Windows.Forms.Label lb_contraseña;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
