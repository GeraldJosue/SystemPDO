namespace SystemForms
{
    partial class Horarios_Agregar
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
            this.label2 = new System.Windows.Forms.Label();
            this.nud_min_out = new System.Windows.Forms.NumericUpDown();
            this.nud_hora_out = new System.Windows.Forms.NumericUpDown();
            this.dud_am_out = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_min_in = new System.Windows.Forms.NumericUpDown();
            this.nud_hora_in = new System.Windows.Forms.NumericUpDown();
            this.tb_codigo = new System.Windows.Forms.TextBox();
            this.dud_am_in = new System.Windows.Forms.DomainUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_estado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora_in)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = ":";
            // 
            // nud_min_out
            // 
            this.nud_min_out.Location = new System.Drawing.Point(228, 151);
            this.nud_min_out.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_min_out.Name = "nud_min_out";
            this.nud_min_out.Size = new System.Drawing.Size(86, 20);
            this.nud_min_out.TabIndex = 17;
            // 
            // nud_hora_out
            // 
            this.nud_hora_out.Location = new System.Drawing.Point(120, 151);
            this.nud_hora_out.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_hora_out.Name = "nud_hora_out";
            this.nud_hora_out.Size = new System.Drawing.Size(86, 20);
            this.nud_hora_out.TabIndex = 16;
            // 
            // dud_am_out
            // 
            this.dud_am_out.Location = new System.Drawing.Point(323, 151);
            this.dud_am_out.Name = "dud_am_out";
            this.dud_am_out.Size = new System.Drawing.Size(61, 20);
            this.dud_am_out.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = ":";
            // 
            // nud_min_in
            // 
            this.nud_min_in.Location = new System.Drawing.Point(228, 96);
            this.nud_min_in.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nud_min_in.Name = "nud_min_in";
            this.nud_min_in.Size = new System.Drawing.Size(86, 20);
            this.nud_min_in.TabIndex = 13;
            // 
            // nud_hora_in
            // 
            this.nud_hora_in.Location = new System.Drawing.Point(120, 96);
            this.nud_hora_in.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nud_hora_in.Name = "nud_hora_in";
            this.nud_hora_in.Size = new System.Drawing.Size(86, 20);
            this.nud_hora_in.TabIndex = 12;
            // 
            // tb_codigo
            // 
            this.tb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codigo.Location = new System.Drawing.Point(120, 37);
            this.tb_codigo.Name = "tb_codigo";
            this.tb_codigo.Size = new System.Drawing.Size(264, 20);
            this.tb_codigo.TabIndex = 11;
            // 
            // dud_am_in
            // 
            this.dud_am_in.Location = new System.Drawing.Point(323, 96);
            this.dud_am_in.Name = "dud_am_in";
            this.dud_am_in.Size = new System.Drawing.Size(61, 20);
            this.dud_am_in.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_estado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_codigo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dud_am_in);
            this.panel1.Controls.Add(this.nud_min_out);
            this.panel1.Controls.Add(this.nud_hora_in);
            this.panel1.Controls.Add(this.nud_hora_out);
            this.panel1.Controls.Add(this.nud_min_in);
            this.panel1.Controls.Add(this.dud_am_out);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(63, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 248);
            this.panel1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Estado del horario:";
            // 
            // cb_estado
            // 
            this.cb_estado.AutoSize = true;
            this.cb_estado.Checked = true;
            this.cb_estado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_estado.Location = new System.Drawing.Point(120, 210);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(105, 17);
            this.cb_estado.TabIndex = 22;
            this.cb_estado.Text = "(Activo/Inactivo)";
            this.cb_estado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hora de salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hora de entrada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Código del horario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "HORARIOS";
            // 
            // Horarios_Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Horarios_Agregar";
            this.Size = new System.Drawing.Size(1204, 517);
            ((System.ComponentModel.ISupportInitialize)(this.nud_min_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_min_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hora_in)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_min_out;
        private System.Windows.Forms.NumericUpDown nud_hora_out;
        private System.Windows.Forms.DomainUpDown dud_am_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_min_in;
        private System.Windows.Forms.NumericUpDown nud_hora_in;
        private System.Windows.Forms.TextBox tb_codigo;
        private System.Windows.Forms.DomainUpDown dud_am_in;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_estado;
        private System.Windows.Forms.Label label7;
    }
}
