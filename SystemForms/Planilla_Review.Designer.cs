namespace SystemForms
{
    partial class Planilla_Review
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Planilla_Review));
            this.dg_planillas = new System.Windows.Forms.DataGridView();
            this.encabezado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_revisar = new System.Windows.Forms.Button();
            this.bt_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_planillas)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_planillas
            // 
            this.dg_planillas.AllowUserToAddRows = false;
            this.dg_planillas.AllowUserToDeleteRows = false;
            this.dg_planillas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dg_planillas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_planillas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_planillas.BackgroundColor = System.Drawing.Color.White;
            this.dg_planillas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_planillas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_planillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_planillas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.encabezado,
            this.total,
            this.desde,
            this.hasta,
            this.tipo});
            this.dg_planillas.EnableHeadersVisualStyles = false;
            this.dg_planillas.Location = new System.Drawing.Point(3, 3);
            this.dg_planillas.Name = "dg_planillas";
            this.dg_planillas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dg_planillas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_planillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_planillas.Size = new System.Drawing.Size(1158, 399);
            this.dg_planillas.TabIndex = 0;
            // 
            // encabezado
            // 
            this.encabezado.HeaderText = "Encabezado";
            this.encabezado.Name = "encabezado";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // desde
            // 
            this.desde.HeaderText = "Desde";
            this.desde.Name = "desde";
            // 
            // hasta
            // 
            this.hasta.HeaderText = "Hasta";
            this.hasta.Name = "hasta";
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // bt_revisar
            // 
            this.bt_revisar.BackColor = System.Drawing.Color.Orange;
            this.bt_revisar.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.bt_revisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.bt_revisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_revisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_revisar.ForeColor = System.Drawing.Color.White;
            this.bt_revisar.Image = ((System.Drawing.Image)(resources.GetObject("bt_revisar.Image")));
            this.bt_revisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_revisar.Location = new System.Drawing.Point(1086, 408);
            this.bt_revisar.Name = "bt_revisar";
            this.bt_revisar.Size = new System.Drawing.Size(75, 50);
            this.bt_revisar.TabIndex = 2;
            this.bt_revisar.Text = "Revisar";
            this.bt_revisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_revisar.UseVisualStyleBackColor = false;
            this.bt_revisar.Click += new System.EventHandler(this.bt_revisar_Click);
            // 
            // bt_guardar
            // 
            this.bt_guardar.BackColor = System.Drawing.Color.LimeGreen;
            this.bt_guardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.bt_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.bt_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guardar.ForeColor = System.Drawing.Color.White;
            this.bt_guardar.Image = ((System.Drawing.Image)(resources.GetObject("bt_guardar.Image")));
            this.bt_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_guardar.Location = new System.Drawing.Point(1005, 408);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 50);
            this.bt_guardar.TabIndex = 3;
            this.bt_guardar.Text = "Guardar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // Planilla_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bt_guardar);
            this.Controls.Add(this.bt_revisar);
            this.Controls.Add(this.dg_planillas);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Planilla_Review";
            this.Size = new System.Drawing.Size(1164, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dg_planillas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_planillas;
        private System.Windows.Forms.Button bt_revisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn encabezado;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button bt_guardar;
    }
}
