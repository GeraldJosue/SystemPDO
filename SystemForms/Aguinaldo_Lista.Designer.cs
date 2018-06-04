namespace SystemForms
{
    partial class Aguinaldo_Lista
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
            this.dgv_Aguinaldo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aguinaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Aguinaldo
            // 
            this.dgv_Aguinaldo.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Aguinaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aguinaldo.GridColor = System.Drawing.Color.White;
            this.dgv_Aguinaldo.Location = new System.Drawing.Point(3, 3);
            this.dgv_Aguinaldo.Name = "dgv_Aguinaldo";
            this.dgv_Aguinaldo.Size = new System.Drawing.Size(1158, 511);
            this.dgv_Aguinaldo.TabIndex = 0;
            // 
            // Aguinaldo_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Aguinaldo);
            this.Name = "Aguinaldo_Lista";
            this.Size = new System.Drawing.Size(1158, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aguinaldo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Aguinaldo;
    }
}
