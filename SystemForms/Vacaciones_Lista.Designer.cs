namespace SystemForms
{
    partial class Vacaciones_Lista
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dg_vacaciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_vacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_vacaciones
            // 
            this.dg_vacaciones.BackgroundColor = System.Drawing.Color.White;
            this.dg_vacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_vacaciones.GridColor = System.Drawing.Color.White;
            this.dg_vacaciones.Location = new System.Drawing.Point(3, 2);
            this.dg_vacaciones.Name = "dg_vacaciones";
            this.dg_vacaciones.Size = new System.Drawing.Size(1158, 511);
            this.dg_vacaciones.TabIndex = 0;
            // 
            // Vacaciones_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_vacaciones);
            this.Name = "Vacaciones_Lista";
            this.Size = new System.Drawing.Size(1164, 516);
            ((System.ComponentModel.ISupportInitialize)(this.dg_vacaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_vacaciones;
    }
}
