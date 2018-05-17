namespace SystemForms
{
    partial class Horarios_Lista
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
            this.dg_horarios = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_horarios
            // 
            this.dg_horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_horarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.codigo,
            this.entrada,
            this.salida});
            this.dg_horarios.Location = new System.Drawing.Point(3, 3);
            this.dg_horarios.Name = "dg_horarios";
            this.dg_horarios.Size = new System.Drawing.Size(698, 511);
            this.dg_horarios.TabIndex = 0;
            // 
            // select
            // 
            this.select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select.HeaderText = "Seleccionar";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // entrada
            // 
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            // 
            // salida
            // 
            this.salida.HeaderText = "Salida";
            this.salida.Name = "salida";
            // 
            // Horarios_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dg_horarios);
            this.Name = "Horarios_Lista";
            this.Size = new System.Drawing.Size(1204, 517);
            ((System.ComponentModel.ISupportInitialize)(this.dg_horarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_horarios;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn salida;
    }
}
