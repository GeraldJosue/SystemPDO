namespace SystemForms
{
    partial class Pantalla_Principal
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_principal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pn_principal
            // 
            this.pn_principal.BackColor = System.Drawing.Color.White;
            this.pn_principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_principal.Location = new System.Drawing.Point(0, 0);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(1364, 662);
            this.pn_principal.TabIndex = 0;
            // 
            // Pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1364, 662);
            this.Controls.Add(this.pn_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pantalla_Principal";
            this.Text = "SPDO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pantalla_Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_principal;
    }
}