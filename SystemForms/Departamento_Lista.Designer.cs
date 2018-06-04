namespace SystemForms
{
    partial class Departamento_Lista
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
            this.dg_Departamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Departamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_Departamentos
            // 
            this.dg_Departamentos.BackgroundColor = System.Drawing.Color.White;
            this.dg_Departamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Departamentos.GridColor = System.Drawing.Color.White;
            this.dg_Departamentos.Location = new System.Drawing.Point(3, 3);
            this.dg_Departamentos.Name = "dg_Departamentos";
            this.dg_Departamentos.Size = new System.Drawing.Size(1158, 511);
            this.dg_Departamentos.TabIndex = 0;
            // 
            // Departamento_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_Departamentos);
            this.Name = "Departamento_Lista";
            this.Size = new System.Drawing.Size(1158, 511);
            ((System.ComponentModel.ISupportInitialize)(this.dg_Departamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Departamentos;
    }
}
