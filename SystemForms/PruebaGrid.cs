using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class PruebaGrid : Form
    {
        DataTable t;
        DataTable t2;
        DateTime date;
        public PruebaGrid()
        {
            InitializeComponent();
            t = new DataTable();

            t.Columns.Add("Activo");
            t.Columns.Add("Nombre");
            t.Columns.Add("Apellido");
            t.Columns.Add("Fecha");

            t2 = new DataTable();

            t2.Columns.Add("Activo");
            t2.Columns.Add("Nombre");
            t2.Columns.Add("Apellido");
            t2.Columns.Add("Fecha");

            DateTime a = new DateTime(2018, 02, 20).Date;
            DateTime b = new DateTime(2018, 04, 20).Date;
            DateTime c = new DateTime(2018, 07, 20).Date;
            DateTime d = new DateTime(2018, 08, 20).Date;
            t.Rows.Add(1, "Gerald","González",a);
            t2.Rows.Add(0, "Christian","Ramirez", b);
            t.Rows.Add(1, "David","Alpizar", c);
            t.Rows.Add(1, "Da1","Alp", b);
            t2.Rows.Add(0, "Vid2", "Izar", c);
            t.Rows.Add(1, "Fernanda", "Oviedo", a);
            dataGridView1.DataSource = t;

            date = new DateTime(2018, 01, 01);

            //llenar_cb_año(date);
            //llenar_cb_mes(date);
            //llenar_cb_dia(date, 31);

            llenar_cb();

        }

        public void llenar_cb()
        {
            DataTable meses = new DataTable();
            meses.Columns.Add("Id");
            meses.Columns.Add("Nombre");

            meses.Rows.Add(5,"Enero");
            meses.Rows.Add(3,"Febrero");
            meses.Rows.Add(9,"Marzo");
            meses.Rows.Add("Abril","Abril");

            cb_prueba.ValueMember = "Id";
            cb_prueba.DisplayMember = "Nombre";

            cb_prueba.DataSource = meses;
        }




























        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;

            dv.RowFilter = "Nombre Like '%" + textBox1.Text + "%' OR Apellido Like '%"+textBox1.Text+"%'";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Fecha = '" + dateTimePicker1.Value.Date.ToString() + "'";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dataGridView1.DataSource = t2;
            }
            else
            {
                dataGridView1.DataSource = t;
            }
        }


        public void llenar_cb_dia(DateTime date, Int32 dias) {

            for (int i = 0; i < dias; i++)
            {
                cb_dia.Items.Add(date.AddDays(i).Day);
            }
            cb_dia.Items.Clear();
        }
        public void llenar_cb_mes(DateTime date) {

            for (int i = 0; i < 12; i++)
            {
                cb_mes.Items.Add( date.AddMonths(i).ToString("MMMM", CultureInfo.CreateSpecificCulture("es-ES")));
            }
        }
        public void llenar_cb_año(DateTime date) {
            
            for (int i = -1; i >= -80; i--)
            {
                cb_año.Items.Add(date.AddYears(i).Year);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = DateTime.Now.ToString("MMddyyyy");
        }

        private void cb_año_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mes.SelectedIndex != -1)
            {
                llenar_cb_dia(date, DateTime.DaysInMonth(Int32.Parse(cb_año.SelectedItem.ToString()), cb_mes.SelectedIndex + 1));
            }
        }

        private void cb_mes_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_cb_dia(date, DateTime.DaysInMonth(Int32.Parse(cb_año.SelectedItem.ToString()), cb_mes.SelectedIndex + 1));
        }

        private void cb_dia_SelectedIndexChanged(object sender, EventArgs e)
        {   
        }

        private void PruebaGrid_Load(object sender, EventArgs e)
        {

        }

        private void cb_prueba_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cb_prueba.SelectedValue.ToString();
        }
    }
}
