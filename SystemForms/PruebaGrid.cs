using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class PruebaGrid : Form
    {
        public PruebaGrid()
        {
            InitializeComponent();
            DataTable t = new DataTable();
            t.Columns.Add("Nombre");
            t.Columns.Add("Apellido");
            t.Columns.Add("Telefono");
            t.Columns.Add("Direccion");
            t.Columns.Add("Nacionalidad");
            t.Rows.Add("Gerald","González","88202414","San Ramon","Costarricense");
            t.Rows.Add("Christian","Ramirez","34568392","Palmares","Costarricense");
            t.Rows.Add("David","Alpizar","99583902","Zarcero","Costarricense");
            t.Rows.Add("Fernanda", "Oviedo","82949203","Zarcero","Costarricense");
            dataGridView1.DataSource = t;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Nombre Like '%" + textBox1.Text+ "%' OR Telefono Like '%" + textBox1.Text + "%'";
        }
    }
}
