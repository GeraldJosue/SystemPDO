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
using BusinessLogic;

namespace SystemForms
{
    public partial class PruebaGrid : Form
    {
        DataTable t;
        DataTable t2;
        DateTime date;
        DateTimePicker oDateTimePicker;
        public PruebaGrid()
        {
            InitializeComponent();
            List<Pago> lista = new List<Pago>();

            lista.Add(new Pago(0, 2, DateTime.Now, 1000, 900, 0, 6, 2, "", true, 0, true, 0, 0, 0, 100, 1172018));
            lista.Add(new Pago(0, 3, DateTime.Now, 2000, 1900, 0, 6, 2, "", true, 0, true, 0, 0, 0, 100, 672018));
            lista.Add(new Pago(0, 4, DateTime.Now, 3000, 2900, 0, 6, 2, "", true, 0, true, 0, 0, 0, 100, 2862018));
            lista.Add(new Pago(0, 3, DateTime.Now, 4000, 3900, 0, 6, 2, "", true, 0, true, 0, 0, 0, 100, 342018));
            lista.Add(new Pago(0, 2, DateTime.Now, 5000, 5900, 0, 6, 2, "", true, 0, true, 0, 0, 0, 100, 1022018));
            new ExcelManager().export(lista);

        }

        public void iniciar()
        {
            List<Departamento> lista = new List<Departamento>();

            lista.Add(new Departamento(1, "rrhh", true));
            lista.Add(new Departamento(1, "finanzas", true));


            List<Departamento> listab = lista;

            foreach (Departamento d in listab)
            {
                d.Nombre = "cmbio";
            }

            oDateTimePicker = new DateTimePicker();


            for (int i = 0; i < 6; i++)
            {
                dataGridView1.Rows.Add("Prueba", "Prueba", "Prueba", 2, 2, 4);
            }
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
            //DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;

            //dv.RowFilter = "Nombre Like '%" + textBox1.Text + "%' OR Apellido Like '%"+textBox1.Text+"%'";

            Double numero = Double.Parse(textBox1.Text, CultureInfo.CreateSpecificCulture("es-CR"));
            textBox1.Tag = numero;
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
            //new ExcelManager().export();
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //Double numero = Double.Parse(textBox1.Text, CultureInfo.CreateSpecificCulture("es-CR"));
            //textBox1.Tag = numero;
            //textBox1.Text = numero.ToString("C");
            //Double nn = Double.Parse(textBox1.Tag.ToString());
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            //textBox1.Text = Convert.ToString(textBox1.Tag);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();
                oDateTimePicker.Value = DateTime.Parse(dataGridView1.CurrentCell.Value.ToString());
                //Adding DateTimePicker control into DataGridView   
                dataGridView1.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Time;
                oDateTimePicker.ShowUpDown = true;

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(odateTimePicker_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }
        }

        private void odateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dataGridView1.CurrentCell.Value = oDateTimePicker.Value.TimeOfDay;
        }

        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            oDateTimePicker.Visible = false;

        }
    }
}
