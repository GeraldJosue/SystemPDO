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
        List<Aguinaldo> lista;
        DataTable tableActivos;
        DataTable tableInactivos;
        String texto;
        String filtro;
        String fecha;

        public Aguinaldo_Lista()
        {
            InitializeComponent();
            tableActivos = new DataTable();
            tableActivos.Columns.Add("Id");
            tableActivos.Columns.Add("Id Colaborador");
            tableActivos.Columns.Add("Fecha");
            tableActivos.Columns.Add("Salario Aguinaldo");
            tableActivos.Columns.Add("Transferencia");
            tableActivos.Columns.Add("Estado");

            tableInactivos = new DataTable();
            tableInactivos.Columns.Add("Id");
            tableInactivos.Columns.Add("Id Colaborador");
            tableInactivos.Columns.Add("Fecha");
            tableInactivos.Columns.Add("Salario Aguinaldo");
            tableInactivos.Columns.Add("Transferencia");
            tableInactivos.Columns.Add("Estado");

            obtener_lista_sys();

            fecha = 1 + "/" + 1 + "/" + 1900;
            texto = "";
        }


        public void obtener_lista_sys()
        {
            lista = new Aguinaldo().obtener_lista();
            llenar_tabla();
            dgv_Aguinaldo.DataSource = tableActivos;
            
        }


        public void llenar_tabla()
        {
            tableActivos.Clear();
            tableInactivos.Clear();
            foreach (Aguinaldo x in lista)
            {
                if (x.EstadoAguinaldo)
                {
                    tableActivos.Rows.Add(x.Id, x.IdColaborador, x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);
                }
                else
                {
                    tableInactivos.Rows.Add(x.Id, x.IdColaborador, x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);
                }
            }
        }


        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dgv_Aguinaldo.CurrentRow.Cells["Id"].Value.ToString());
            String transferencia = dgv_Aguinaldo.CurrentRow.Cells["Transferencia"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer pagado el aguinaldo con la transferencia" + transferencia + " ?", "Pagado", MessageBoxButtons.YesNo);
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



        public Aguinaldo obtener()
        {
            Aguinaldo aguinaldo = new Aguinaldo();
            Int32 id = Int32.Parse(dgv_Aguinaldo.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Aguinaldo x in lista)
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


    }
}
