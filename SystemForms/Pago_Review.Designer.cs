namespace SystemForms
{
    partial class Pago_Review
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_pagos_review = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgw_pagos = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pagos_review)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_pagos_review
            // 
            this.dg_pagos_review.AllowUserToAddRows = false;
            this.dg_pagos_review.AllowUserToDeleteRows = false;
            this.dg_pagos_review.AllowUserToOrderColumns = true;
            this.dg_pagos_review.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dg_pagos_review.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_pagos_review.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_pagos_review.BackgroundColor = System.Drawing.Color.White;
            this.dg_pagos_review.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_pagos_review.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_pagos_review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pagos_review.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.colaborador,
            this.bruto,
            this.neto,
            this.horas,
            this.extras,
            this.planilla});
            this.dg_pagos_review.EnableHeadersVisualStyles = false;
            this.dg_pagos_review.Location = new System.Drawing.Point(3, 3);
            this.dg_pagos_review.Name = "dg_pagos_review";
            this.dg_pagos_review.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_pagos_review.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_pagos_review.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dg_pagos_review.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_pagos_review.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pagos_review.Size = new System.Drawing.Size(1158, 455);
            this.dg_pagos_review.TabIndex = 0;
            // 
            // select
            // 
            this.select.HeaderText = "Revisar";
            this.select.Name = "select";
            // 
            // colaborador
            // 
            this.colaborador.HeaderText = "Colaborador";
            this.colaborador.Name = "colaborador";
            // 
            // bruto
            // 
            this.bruto.HeaderText = "Salario Bruto";
            this.bruto.Name = "bruto";
            // 
            // neto
            // 
            this.neto.HeaderText = "Salario Neto";
            this.neto.Name = "neto";
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            // 
            // extras
            // 
            this.extras.HeaderText = "Extras";
            this.extras.Name = "extras";
            // 
            // planilla
            // 
            this.planilla.HeaderText = "Planilla";
            this.planilla.Name = "planilla";
            // 
            // bgw_pagos
            // 
            this.bgw_pagos.WorkerReportsProgress = true;
            this.bgw_pagos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_pagos_DoWork);
            this.bgw_pagos.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_pagos_ProgressChanged);
            this.bgw_pagos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_pagos_RunWorkerCompleted);
            // 
            // Pago_Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dg_pagos_review);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pago_Review";
            this.Size = new System.Drawing.Size(1164, 461);
            ((System.ComponentModel.ISupportInitialize)(this.dg_pagos_review)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_pagos_review;
        private System.ComponentModel.BackgroundWorker bgw_pagos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn planilla;
    }
}
