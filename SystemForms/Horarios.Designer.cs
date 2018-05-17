namespace SystemForms
{
    partial class Horarios
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
            this.pn_menu_izq = new System.Windows.Forms.Panel();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.pn_menu_izq.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_principal
            // 
            this.pn_principal.Location = new System.Drawing.Point(139, 3);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(1204, 517);
            this.pn_principal.TabIndex = 4;
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
            this.pn_menu_izq.TabIndex = 3;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_eliminar.Image = global::SystemForms.Properties.Resources.eliminar;
            this.bt_eliminar.Location = new System.Drawing.Point(27, 96);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 75);
            this.bt_eliminar.TabIndex = 3;
            this.bt_eliminar.UseVisualStyleBackColor = true;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_editar.Image = global::SystemForms.Properties.Resources.editar__2_;
            this.bt_editar.Location = new System.Drawing.Point(28, 177);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(75, 75);
            this.bt_editar.TabIndex = 2;
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_guardar.Image = global::SystemForms.Properties.Resources.guardar__2_;
            this.bt_guardar.Location = new System.Drawing.Point(28, 258);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 75);
            this.bt_guardar.TabIndex = 1;
            this.bt_guardar.UseVisualStyleBackColor = true;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_agregar.Image = global::SystemForms.Properties.Resources.agregar__2_;
            this.bt_agregar.Location = new System.Drawing.Point(27, 15);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 75);
            this.bt_agregar.TabIndex = 0;
            this.bt_agregar.UseVisualStyleBackColor = true;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // Horarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_principal);
            this.Controls.Add(this.pn_menu_izq);
            this.Name = "Horarios";
            this.Size = new System.Drawing.Size(1346, 523);
            this.pn_menu_izq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_principal;
        private System.Windows.Forms.Panel pn_menu_izq;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_guardar;
        private System.Windows.Forms.Button bt_agregar;
    }
}
