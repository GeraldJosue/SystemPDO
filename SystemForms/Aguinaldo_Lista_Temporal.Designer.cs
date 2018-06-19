namespace SystemForms
{
    partial class Aguinaldo_Lista_Temporal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.dg_lista_temp = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_temp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dg_lista_temp);
            this.panel1.Location = new System.Drawing.Point(38, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 398);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_calcular);
            this.panel2.Location = new System.Drawing.Point(38, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 63);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // bt_calcular
            // 
            this.bt_calcular.BackColor = System.Drawing.Color.Maroon;
            this.bt_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.ForeColor = System.Drawing.Color.White;
            this.bt_calcular.Location = new System.Drawing.Point(802, 14);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(219, 35);
            this.bt_calcular.TabIndex = 15;
            this.bt_calcular.Text = "Calcular Aguinaldo";
            this.bt_calcular.UseVisualStyleBackColor = false;
            // 
            // dg_lista_temp
            // 
            this.dg_lista_temp.BackgroundColor = System.Drawing.Color.White;
            this.dg_lista_temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista_temp.Location = new System.Drawing.Point(4, 4);
            this.dg_lista_temp.Name = "dg_lista_temp";
            this.dg_lista_temp.Size = new System.Drawing.Size(1096, 391);
            this.dg_lista_temp.TabIndex = 0;
            // 
            // Aguinaldo_Lista_Temporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Aguinaldo_Lista_Temporal";
            this.Size = new System.Drawing.Size(1164, 516);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_temp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.DataGridView dg_lista_temp;
    }
}
