namespace SystemForms
{
    partial class Pago_Lista
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
            this.dg_Pagos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Pagos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Pagos
            // 
            this.dg_Pagos.BackgroundColor = System.Drawing.Color.White;
            this.dg_Pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Pagos.GridColor = System.Drawing.Color.White;
            this.dg_Pagos.Location = new System.Drawing.Point(0, 3);
            this.dg_Pagos.Name = "dg_Pagos";
            this.dg_Pagos.Size = new System.Drawing.Size(1158, 511);
            this.dg_Pagos.TabIndex = 0;
            // 
            // Pago_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_Pagos);
            this.Name = "Pago_Lista";
            this.Size = new System.Drawing.Size(1158, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Pagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Pagos;
    }
}
