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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_pagos_review = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bgw_pagos = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dg_pagos_review)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_pagos_review
            // 
            this.dg_pagos_review.AllowUserToAddRows = false;
            this.dg_pagos_review.AllowUserToDeleteRows = false;
            this.dg_pagos_review.AllowUserToOrderColumns = true;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            this.dg_pagos_review.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dg_pagos_review.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_pagos_review.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_pagos_review.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dg_pagos_review.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_pagos_review.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select});
            this.dg_pagos_review.EnableHeadersVisualStyles = false;
            this.dg_pagos_review.Location = new System.Drawing.Point(3, 3);
            this.dg_pagos_review.Name = "dg_pagos_review";
            this.dg_pagos_review.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_pagos_review.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dg_pagos_review.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dg_pagos_review.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dg_pagos_review.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_pagos_review.Size = new System.Drawing.Size(1158, 455);
            this.dg_pagos_review.TabIndex = 0;
            // 
            // select
            // 
            this.select.HeaderText = "Revisar";
            this.select.Name = "select";
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.ComponentModel.BackgroundWorker bgw_pagos;
    }
}
