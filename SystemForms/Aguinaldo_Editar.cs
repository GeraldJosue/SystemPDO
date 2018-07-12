using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SystemForms
{
    public partial class Aguinaldo_Editar : Form
    {
        Aguinaldo aguinaldo;
        Aguinaldo_Control parent;
        Aguinaldo_Lista_Temporal parent_temp;
        Boolean temp;

        public Aguinaldo_Editar()
        {
            InitializeComponent();
            //llenar_cb_colaborador();

        }


        public Aguinaldo_Editar(Aguinaldo aguinaldo, Aguinaldo_Control parent_control)
        {
            InitializeComponent();
            this.aguinaldo = aguinaldo;
            parent = parent_control;
            temp = false;

            setear_datos();
        }

        public Aguinaldo_Editar(Aguinaldo aguinaldo, Aguinaldo_Lista_Temporal parent)
        {
            InitializeComponent();
            this.aguinaldo = aguinaldo;
            parent_temp = parent;
            temp = true;

            setear_datos();
        }

        //public Boolean agregar_sys()
        //{
        //    Aguinaldo aguinaldo = obtener_datos();
        //    if (aguinaldo.agregar())
        //    {
        //        MessageBox.Show("Aguinaldo agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //}

        public Boolean agregar_lista(List<Aguinaldo> list)
        {
            foreach (Aguinaldo a in list)
            {
                if (!a.agregar())
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            MessageBox.Show("Aguinaldo editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        //public Boolean editar_sys()
        //{
        //    Aguinaldo aguinaldo = obtener_datos();
        //    aguinaldo.Id = this.aguinaldo.Id;
        //    List<Int32> lista = validar_cambios(aguinaldo);
        //    if (lista.Count == 0)
        //    {
        //        return true;
        //    }
        //    else if (aguinaldo.editar(lista))
        //    {
        //        MessageBox.Show("Aguinaldo editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return true;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //}

        //public Aguinaldo editar_temp()
        //{
        //    //Aguinaldo aguinaldo = obtener_datos();
        //    //return aguinaldo;
        //}

        public void obtener_datos()
        {
            DateTime fecha = dtp_fecha.Value.Date;
            Decimal salarioAguinaldo = tb_monto.Text.Equals("") ? 0 : Decimal.Parse(Convert.ToString(tb_monto.Tag));
            String transferencia = tb_transferencia.Text.Equals("") ? "No disponible" : tb_transferencia.Text;

            aguinaldo.FechaAguinaldo = fecha;
            aguinaldo.Salario = salarioAguinaldo;
            aguinaldo.TransferenciaAguinaldo = transferencia;
        }

        public void setear_datos()
        {
            //Setear el selected index            
            //cb_colaborador.SelectedIndex = aguinaldo.IdColaborador;
            dtp_fecha.Text = aguinaldo.FechaAguinaldo.ToString();
            tb_monto.Tag = aguinaldo.Salario.ToString();
            tb_monto.Text = aguinaldo.Salario.ToString("C");
            tb_transferencia.Text = aguinaldo.TransferenciaAguinaldo;
        }

        public List<Int32> validar_cambios(Aguinaldo aguinaldoNuevo)
        {
            List<Int32> lista = new List<Int32>();
            //if (aguinaldoNuevo.IdColaborador != this.aguinaldo.IdColaborador)
            //{
            //    lista.Add(0);
            //}
            if (aguinaldoNuevo.FechaAguinaldo != this.aguinaldo.FechaAguinaldo)
            {
                lista.Add(0);
            }
            if (aguinaldoNuevo.Salario != this.aguinaldo.Salario)
            {
                lista.Add(1);
            }
            if (aguinaldoNuevo.TransferenciaAguinaldo != this.aguinaldo.TransferenciaAguinaldo)
            {
                lista.Add(2);
            }
            if (aguinaldoNuevo.EstadoAguinaldo != this.aguinaldo.EstadoAguinaldo)
            {
                lista.Add(3);
            }
            return lista;
        }


        //public void llenar_cb_colaborador()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Id");
        //    dt.Columns.Add("Nombre");
        //    lista = new Colaborador().obtener_lista_activos();

        //    foreach (Colaborador x in lista)
        //    {
        //        dt.Rows.Add(x.Id, x.Nombre);
        //    }

        //    cb_colaborador.ValueMember = "Id";
        //    cb_colaborador.DisplayMember = "Nombre";
        //    cb_colaborador.DataSource = dt;
        //}

        private void tb_monto_enter(object sender, EventArgs e)
        {
            tb_monto.Text = Convert.ToString(tb_monto.Tag);
        }

        private void tb_monto_leave(object sender, EventArgs e)
        {

            if (!tb_monto.Text.Equals(""))
            {
                try
                {
                    Decimal monto = Decimal.Parse(tb_monto.Text);
                    tb_monto.Tag = monto;
                    tb_monto.Text = monto.ToString("C");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El campo para ingresar el monto solo admite numeros", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_monto.Focus();
                }
            }
            
        }     

        private void bt_guardar_Click_1(object sender, EventArgs e)
        {
            obtener_datos();
            parent_temp.llenar_tabla();
            this.Close();
        }

        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
