namespace SystemForms
{
    partial class Colaboradores_Lista
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
            this.dg_colaboradores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_colaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_colaboradores
            // 
            this.dg_colaboradores.AllowUserToAddRows = false;
            this.dg_colaboradores.AllowUserToDeleteRows = false;
            this.dg_colaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_colaboradores.Location = new System.Drawing.Point(3, 3);
            this.dg_colaboradores.MultiSelect = false;
            this.dg_colaboradores.Name = "dg_colaboradores";
            this.dg_colaboradores.ReadOnly = true;
            this.dg_colaboradores.Size = new System.Drawing.Size(1198, 511);
            this.dg_colaboradores.TabIndex = 0;
            // 
            // Colaboradores_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_colaboradores);
            this.Name = "Colaboradores_Lista";
            this.Size = new System.Drawing.Size(1204, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dg_colaboradores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_colaboradores;
    }
}
