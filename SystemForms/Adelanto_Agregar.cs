using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using System.Globalization;

namespace SystemForms
{
    public partial class Adelanto_Agregar : UserControl
    {

        Adelanto adelanto;
        List<Colaborador> lista;

        public Adelanto_Agregar(Adelanto adelanto)
        {
            InitializeComponent();
            this.adelanto = adelanto;
            llenar_cb_colaborador();

            setear_datos();
        }

        public Adelanto_Agregar()
        {
            InitializeComponent();
            llenar_cb_colaborador();
        }


        public void setear_datos()
        {
            cb_colaborador.SelectedValue = adelanto.IdColaborador;
            cb_colaborador.Enabled = false;
            dt_fecha.Value = adelanto.Fecha;
            tb_monto.Text = adelanto.Monto.ToString();
            if (adelanto.Estado)
            {
                rb_activo.Checked = true;
            }
            else
            {
                rb_inactivo.Checked = true;
            }

            
        }

        public Boolean agregar_sys()
        {
            Adelanto adelanto = obtener_datos();
            if (adelanto.agregar())
            {
                MessageBox.Show("Adelanto agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }


        public void llenar_cb_colaborador()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            lista = new Colaborador().obtener_lista_activos();            

           foreach (Colaborador x in lista)
           {
                
                    dt.Rows.Add(x.Id, x.Nombre);
                
            }   
                
            cb_colaborador.ValueMember = "Id";
            cb_colaborador.DisplayMember = "Nombre";
            cb_colaborador.DataSource = dt;
        }


        public Boolean editar_sys()
        {
            Adelanto adelanto = obtener_datos();
            adelanto.Id = this.adelanto.Id;
            List<Int32> lista = validar_cambios(adelanto);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (adelanto.editar(lista))
            {
                MessageBox.Show("Adelanto editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_colaborador.Enabled = true;
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_colaborador.Enabled = true;
                return false;
            }

        }


        public Adelanto obtener_datos()
        {
            Int32 idcolaborador = cb_colaborador.SelectedIndex == -1 ? 1 : Int32.Parse(cb_colaborador.SelectedValue.ToString());
            Decimal monto = tb_monto.Text.Equals("") ? 0 : Decimal.Parse(tb_monto.Text.ToString());
            Boolean estado = rb_activo.Checked ? true : false;
            DateTime fecha = dt_fecha.Value.Date;
                    

            
            return new Adelanto(0, idcolaborador, fecha, monto, estado);
        }

        public List<Int32> validar_cambios(Adelanto nuevo)
        {
            List<Int32> lista = new List<Int32>();
            
            if (nuevo.IdColaborador != this.adelanto.IdColaborador)//adaptar
            {
                lista.Add(0);
            }
            if (!nuevo.Fecha.Equals(this.adelanto.Fecha))//adaptar
            {
                lista.Add(1);
            }
            if (nuevo.Monto != this.adelanto.Monto)
            {
                lista.Add(2);
            }
            if (nuevo.Estado != this.adelanto.Estado)
            {
                lista.Add(3);
            }
            return lista;
        }

       

        private void tb_monto_enter(object sender, EventArgs e)
        {
            //tb_monto.Text = Convert.ToString(tb_monto.Tag);
        }

        private void tb_monto_leave(object sender, EventArgs e)
        {
            //Decimal monto = Decimal.Parse(tb_monto.Text);
            //tb_monto.Tag = monto;
            //tb_monto.Text = monto.ToString("C");
        }

       
    }
}
