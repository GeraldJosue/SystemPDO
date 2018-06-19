namespace SystemForms
{
    partial class Pago_Calculos
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
            this.cb_periodo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.dt_inicio = new System.Windows.Forms.DateTimePicker();
            this.bgw_calculos = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_periodo
            // 
            this.cb_periodo.FormattingEnabled = true;
            this.cb_periodo.Location = new System.Drawing.Point(150, 62);
            this.cb_periodo.Name = "cb_periodo";
            this.cb_periodo.Size = new System.Drawing.Size(275, 28);
            this.cb_periodo.TabIndex = 1;
            this.cb_periodo.SelectedIndexChanged += new System.EventHandler(this.cb_periodo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Periodo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_calcular);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dt_fin);
            this.panel1.Controls.Add(this.dt_inicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_periodo);
            this.panel1.Location = new System.Drawing.Point(330, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 410);
            this.panel1.TabIndex = 4;
            // 
            // bt_calcular
            // 
            this.bt_calcular.BackColor = System.Drawing.Color.Maroon;
            this.bt_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_calcular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.ForeColor = System.Drawing.Color.White;
            this.bt_calcular.Location = new System.Drawing.Point(150, 253);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(275, 52);
            this.bt_calcular.TabIndex = 8;
            this.bt_calcular.Text = "Calcular";
            this.bt_calcular.UseVisualStyleBackColor = false;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fin";
            // 
            // dt_fin
            // 
            this.dt_fin.Location = new System.Drawing.Point(150, 194);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(200, 26);
            this.dt_fin.TabIndex = 5;
            this.dt_fin.Value = new System.DateTime(2018, 6, 15, 0, 0, 0, 0);
            // 
            // dt_inicio
            // 
            this.dt_inicio.Location = new System.Drawing.Point(150, 137);
            this.dt_inicio.Name = "dt_inicio";
            this.dt_inicio.Size = new System.Drawing.Size(200, 26);
            this.dt_inicio.TabIndex = 4;
            // 
            // bgw_calculos
            // 
            this.bgw_calculos.WorkerReportsProgress = true;
            this.bgw_calculos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_calculos_DoWork);
            this.bgw_calculos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_calculos_ProgressChanged);
            this.bgw_calculos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_calculos_RunWorkerCompleted);
            // 
            // Pago_Calculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pago_Calculos";
            this.Size = new System.Drawing.Size(1164, 461);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_periodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_fin;
        private System.Windows.Forms.DateTimePicker dt_inicio;
        private System.ComponentModel.BackgroundWorker bgw_calculos;
    }
}
