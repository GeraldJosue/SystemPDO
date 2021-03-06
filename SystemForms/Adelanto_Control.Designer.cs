﻿namespace SystemForms
{
    partial class Adelanto_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adelanto_Control));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_eliminar = new System.Windows.Forms.Button();
            this.bt_listar = new System.Windows.Forms.Button();
            this.bt_agregar = new System.Windows.Forms.Button();
            this.pn_filtros = new System.Windows.Forms.Panel();
            this.bt_down = new System.Windows.Forms.Button();
            this.bt_up = new System.Windows.Forms.Button();
            this.tb_buscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_activos = new System.Windows.Forms.CheckBox();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.pn_master = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_filtros.SuspendLayout();
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
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADELANTOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.bt_eliminar);
            this.panel3.Controls.Add(this.bt_listar);
            this.panel3.Controls.Add(this.bt_agregar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1164, 55);
            this.panel3.TabIndex = 5;
            // 
            // bt_eliminar
            // 
            this.bt_eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.bt_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.bt_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.bt_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_eliminar.ForeColor = System.Drawing.Color.White;
            this.bt_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("bt_eliminar.Image")));
            this.bt_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_eliminar.Location = new System.Drawing.Point(169, 5);
            this.bt_eliminar.Name = "bt_eliminar";
            this.bt_eliminar.Size = new System.Drawing.Size(75, 50);
            this.bt_eliminar.TabIndex = 7;
            this.bt_eliminar.Text = "Eliminar";
            this.bt_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_eliminar.UseVisualStyleBackColor = false;
            this.bt_eliminar.Click += new System.EventHandler(this.bt_eliminar_Click);
            // 
            // bt_listar
            // 
            this.bt_listar.BackColor = System.Drawing.Color.Teal;
            this.bt_listar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bt_listar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.bt_listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_listar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_listar.ForeColor = System.Drawing.Color.White;
            this.bt_listar.Image = ((System.Drawing.Image)(resources.GetObject("bt_listar.Image")));
            this.bt_listar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_listar.Location = new System.Drawing.Point(88, 5);
            this.bt_listar.Name = "bt_listar";
            this.bt_listar.Size = new System.Drawing.Size(75, 50);
            this.bt_listar.TabIndex = 4;
            this.bt_listar.Text = "Listar";
            this.bt_listar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_listar.UseVisualStyleBackColor = false;
            this.bt_listar.Click += new System.EventHandler(this.bt_listar_Click);
            // 
            // bt_agregar
            // 
            this.bt_agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_agregar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.bt_agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bt_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_agregar.ForeColor = System.Drawing.Color.White;
            this.bt_agregar.Image = ((System.Drawing.Image)(resources.GetObject("bt_agregar.Image")));
            this.bt_agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_agregar.Location = new System.Drawing.Point(7, 5);
            this.bt_agregar.Name = "bt_agregar";
            this.bt_agregar.Size = new System.Drawing.Size(75, 50);
            this.bt_agregar.TabIndex = 3;
            this.bt_agregar.Text = "Agregar";
            this.bt_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_agregar.UseVisualStyleBackColor = false;
            this.bt_agregar.Click += new System.EventHandler(this.bt_agregar_Click);
            // 
            // pn_filtros
            // 
            this.pn_filtros.BackColor = System.Drawing.Color.White;
            this.pn_filtros.Controls.Add(this.bt_down);
            this.pn_filtros.Controls.Add(this.bt_up);
            this.pn_filtros.Controls.Add(this.tb_buscar);
            this.pn_filtros.Controls.Add(this.label2);
            this.pn_filtros.Controls.Add(this.label3);
            this.pn_filtros.Controls.Add(this.cb_activos);
            this.pn_filtros.Controls.Add(this.dt_inicio);
            this.pn_filtros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_filtros.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_filtros.Location = new System.Drawing.Point(0, 110);
            this.pn_filtros.Name = "pn_filtros";
            this.pn_filtros.Size = new System.Drawing.Size(1164, 36);
            this.pn_filtros.TabIndex = 11;
            // 
            // bt_down
            // 
            this.bt_down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_down.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_down.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_down.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_down.Image = global::SystemForms.Properties.Resources.caret_down;
            this.bt_down.Location = new System.Drawing.Point(35, 7);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(35, 23);
            this.bt_down.TabIndex = 1;
            this.bt_down.UseVisualStyleBackColor = true;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // bt_up
            // 
            this.bt_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_up.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.bt_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_up.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_up.Image = global::SystemForms.Properties.Resources.sort_up;
            this.bt_up.Location = new System.Drawing.Point(3, 7);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(32, 23);
            this.bt_up.TabIndex = 0;
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // tb_buscar
            // 
            this.tb_buscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscar.Location = new System.Drawing.Point(127, 9);
            this.tb_buscar.Name = "tb_buscar";
            this.tb_buscar.Size = new System.Drawing.Size(128, 22);
            this.tb_buscar.TabIndex = 2;
            this.tb_buscar.TextChanged += new System.EventHandler(this.tb_buscar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Expedición";
            // 
            // cb_activos
            // 
            this.cb_activos.AutoSize = true;
            this.cb_activos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_activos.Location = new System.Drawing.Point(270, 10);
            this.cb_activos.Name = "cb_activos";
            this.cb_activos.Size = new System.Drawing.Size(82, 21);
            this.cb_activos.TabIndex = 0;
            this.cb_activos.Text = "Inactivos";
            this.cb_activos.UseVisualStyleBackColor = true;
            this.cb_activos.CheckedChanged += new System.EventHandler(this.cb_activos_CheckedChanged);
            // 
            // dt_inicio
            // 
            this.dt_inicio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_inicio.Location = new System.Drawing.Point(477, 8);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(163, 22);
            this.dt_inicio.TabIndex = 1;
            this.dt_inicio.ValueChanged += new System.EventHandler(this.dt_inicio_ValueChanged);
            // 
            // pn_master
            // 
            this.pn_master.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_master.Location = new System.Drawing.Point(0, 146);
            this.pn_master.Name = "pn_master";
            this.pn_master.Size = new System.Drawing.Size(1164, 516);
            this.pn_master.TabIndex = 13;
            // 
            // Adelanto_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_master);
            this.Controls.Add(this.pn_filtros);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Adelanto_Control";
            this.Size = new System.Drawing.Size(1164, 662);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pn_filtros.ResumeLayout(false);
            this.pn_filtros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_eliminar;
        private System.Windows.Forms.Button bt_listar;
        private System.Windows.Forms.Button bt_agregar;
        private System.Windows.Forms.Panel pn_filtros;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.TextBox tb_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_activos;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.Windows.Forms.Panel pn_master;
    }
}
