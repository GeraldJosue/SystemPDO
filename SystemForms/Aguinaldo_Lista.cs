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

namespace SystemForms
{
    public partial class Aguinaldo_Lista : UserControl
    {
        List<Aguinaldo_General> lista;
        List<Colaborador> lista_col;
        DataTable tableActivos;
        DataTable tableInactivos;
        Aguinaldo_Control parent;
        String texto;
        String filtro;
        String fecha;
        String colaborador;

        public Aguinaldo_Lista(Aguinaldo_Control parent_control)
        {
            InitializeComponent();
            this.parent = parent_control;
            lista_col = new Colaborador().obtener_lista_activos();
            tableActivos = new DataTable();
            tableActivos.Columns.Add("Encabezado");           
            tableActivos.Columns.Add("Fecha");
            tableActivos.Columns.Add("Monto");

            tableInactivos = new DataTable();
            tableInactivos.Columns.Add("Encabezado");
            tableInactivos.Columns.Add("Fecha");
            tableInactivos.Columns.Add("Monto");

            obtener_lista_sys();

            fecha = 1 + "/" + 1 + "/" + 1900;
            texto = "";
            colaborador = "";
        }


        public void obtener_lista_sys()
        {
            lista = new Aguinaldo_General().obtener_lista();
            llenar_tabla();
            dgv_Aguinaldo.DataSource = tableActivos;
            

        }


        public void obtener_lista_temps(List <Aguinaldo_General> lista_temp)
        {
            lista = lista_temp;
            llenar_tabla();
            dgv_Aguinaldo.DataSource = tableActivos;

        }

        public String get_nombre(Int32 id)
        {
            foreach (Colaborador c in lista_col)
            {
                if (c.Id == id)
                {
                    return c.Nombre + " " + c.Apellido + " " + c.Segundo_apellido;
                }
            }
            return "No disponible";
        }


        //public void llenar_tabla()
        //{
        //    tableActivos.Clear();
        //    tableInactivos.Clear();
        //    foreach (Aguinaldo_General x in lista)
        //    {
        //        if (x.EstadoAguinaldo)
        //        {
        //            tableActivos.Rows.Add(x.Id, get_nombre(x.IdColaborador), x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);
        //        }
        //        else
        //        {
        //            tableInactivos.Rows.Add(x.Id, x.IdColaborador, x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);
        //        }
        //    }
        //}

        public void llenar_tabla()
        {
            tableActivos.Clear();
            tableInactivos.Clear();
            foreach (Aguinaldo_General x in lista)
            {
                if (x.Estado)
                {
                    tableActivos.Rows.Add(x.Id, x.Fecha.ToShortDateString(), x.Monto_total.ToString("C"));
                }
                else
                {
                    tableInactivos.Rows.Add(x.Id, x.Fecha.ToShortDateString(), x.Monto_total.ToString("C"));
                }
            }
        }


        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dgv_Aguinaldo.CurrentRow.Cells["Encabezado"].Value.ToString());
            String transferencia = dgv_Aguinaldo.CurrentRow.Cells["Transferencia"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer inactivo el aguinaldo con la transferencia" + transferencia + " ?", "Pagado", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Aguinaldo aguinaldo = new Aguinaldo();
                aguinaldo.Id = id;
                aguinaldo.EstadoAguinaldo = false;
                if (aguinaldo.eliminar())
                {
                    MessageBox.Show("Aguinaldo inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        public Aguinaldo_General obtener()
        {
            Aguinaldo_General aguinaldo = new Aguinaldo_General();
            Int32 id = Int32.Parse(dgv_Aguinaldo.CurrentRow.Cells["Encabezado"].Value.ToString());
            foreach (Aguinaldo_General x in lista)
            {
                if (x.Id == id)
                {
                    aguinaldo = x;
                }
            }

            return aguinaldo;

        }

        public void bajar_fila()
        {
            Int32 i = dgv_Aguinaldo.CurrentCell.RowIndex;
            if (i + 1 < dgv_Aguinaldo.Rows.Count)
            {
                dgv_Aguinaldo.Rows[i].Selected = false;
                dgv_Aguinaldo.Rows[i + 1].Selected = true;
                dgv_Aguinaldo.CurrentCell = dgv_Aguinaldo.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dgv_Aguinaldo.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dgv_Aguinaldo.Rows[i].Selected = false;
                dgv_Aguinaldo.Rows[i - 1].Selected = true;
                dgv_Aguinaldo.CurrentCell = dgv_Aguinaldo.Rows[i - 1].Cells[0];
            }
        }

        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dgv_Aguinaldo.DataSource = tableActivos;
            }
            else
            {
                dgv_Aguinaldo.DataSource = tableInactivos;
            }
        }

        public void filtro_datos(String busqueda)
        {
            texto = busqueda;
            filtro = "(Transferencia Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dgv_Aguinaldo.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha(DateTime date)
        {
            fecha = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Transferencia Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dgv_Aguinaldo.DataSource).DefaultView.RowFilter = filtro;
        }

        private void dgv_Aguinaldo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Aguinaldo_General general = obtener();
            parent.listar_aguinaldos_review(general);
        }

}
}
