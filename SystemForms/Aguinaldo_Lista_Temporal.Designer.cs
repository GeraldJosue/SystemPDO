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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aguinaldo_Lista_Temporal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_lista_temp = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aguinaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_guardar = new System.Windows.Forms.Button();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.bg_calcular_aguinaldo = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_temp)).BeginInit();
            this.panel2.SuspendLayout();
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
            // dg_lista_temp
            // 
            this.dg_lista_temp.AllowUserToAddRows = false;
            this.dg_lista_temp.AllowUserToDeleteRows = false;
            this.dg_lista_temp.AllowUserToOrderColumns = true;
            this.dg_lista_temp.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dg_lista_temp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_lista_temp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_lista_temp.BackgroundColor = System.Drawing.Color.White;
            this.dg_lista_temp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_lista_temp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_lista_temp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_lista_temp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.aguinaldo,
            this.colaborador,
            this.salario,
            this.fecha,
            this.Transferencia});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_lista_temp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_lista_temp.EnableHeadersVisualStyles = false;
            this.dg_lista_temp.Location = new System.Drawing.Point(0, 4);
            this.dg_lista_temp.Name = "dg_lista_temp";
            this.dg_lista_temp.ReadOnly = true;
            this.dg_lista_temp.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_lista_temp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_lista_temp.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dg_lista_temp.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_lista_temp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_lista_temp.Size = new System.Drawing.Size(1100, 391);
            this.dg_lista_temp.TabIndex = 0;
            this.dg_lista_temp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_lista_temp_CellDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // aguinaldo
            // 
            this.aguinaldo.HeaderText = "Aguinaldo";
            this.aguinaldo.Name = "aguinaldo";
            this.aguinaldo.ReadOnly = true;
            // 
            // colaborador
            // 
            this.colaborador.HeaderText = "Colaborador";
            this.colaborador.Name = "colaborador";
            this.colaborador.ReadOnly = true;
            // 
            // salario
            // 
            this.salario.HeaderText = "Salario Aguinaldo";
            this.salario.Name = "salario";
            this.salario.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Transferencia
            // 
            this.Transferencia.HeaderText = "Transferencia";
            this.Transferencia.Name = "Transferencia";
            this.Transferencia.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bt_guardar);
            this.panel2.Controls.Add(this.bt_calcular);
            this.panel2.Location = new System.Drawing.Point(38, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 63);
            this.panel2.TabIndex = 1;
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
            this.bt_guardar.Location = new System.Drawing.Point(1022, 3);
            this.bt_guardar.Name = "bt_guardar";
            this.bt_guardar.Size = new System.Drawing.Size(75, 50);
            this.bt_guardar.TabIndex = 16;
            this.bt_guardar.Text = "Salvar";
            this.bt_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_guardar.UseVisualStyleBackColor = false;
            this.bt_guardar.Click += new System.EventHandler(this.bt_guardar_Click);
            // 
            // bt_calcular
            // 
            this.bt_calcular.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bt_calcular.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular.ForeColor = System.Drawing.Color.White;
            this.bt_calcular.Location = new System.Drawing.Point(797, 3);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(219, 50);
            this.bt_calcular.TabIndex = 15;
            this.bt_calcular.Text = "Calcular Aguinaldo";
            this.bt_calcular.UseVisualStyleBackColor = false;
            this.bt_calcular.Click += new System.EventHandler(this.bt_calcular_Click);
            // 
            // bg_calcular_aguinaldo
            // 
            this.bg_calcular_aguinaldo.WorkerReportsProgress = true;
            this.bg_calcular_aguinaldo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bg_calcular_aguinaldo_DoWork);
            this.bg_calcular_aguinaldo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bg_calcular_aguinaldo_ProgressChanged);
            this.bg_calcular_aguinaldo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bg_calcular_aguinaldo_RunWorkerCompleted);
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
            ((System.ComponentModel.ISupportInitialize)(this.dg_lista_temp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.DataGridView dg_lista_temp;
        private System.Windows.Forms.Button bt_guardar;
        private System.ComponentModel.BackgroundWorker bg_calcular_aguinaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn aguinaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transferencia;
    }
}
