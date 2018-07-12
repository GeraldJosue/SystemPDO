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
    public partial class Adelanto_Lista : UserControl
    {
        List<Adelanto> lista;
        List<Colaborador> lista_col;
        DataTable table_activos;
        DataTable table_inactvos;
        Adelanto_Control parent;
        String filtro;
        String texto;
        String fecha;
            
        public Adelanto_Lista(Adelanto_Control parent_control)
        {
            InitializeComponent();
            lista_col = new Colaborador().obtener_lista_activos();
            this.parent = parent_control;
            table_activos = new DataTable();
            table_inactvos = new DataTable();

            table_activos.Columns.Add("Id");
            table_inactvos.Columns.Add("Id");

            table_activos.Columns.Add("Colaborador");
            table_inactvos.Columns.Add("Colaborador");

            table_activos.Columns.Add("Monto");
            table_inactvos.Columns.Add("Monto");

            table_activos.Columns.Add("Fecha");
            table_inactvos.Columns.Add("Fecha");

            table_activos.Columns.Add("Estado");
            table_inactvos.Columns.Add("Estado");

            

            obtener_lista_sys();
            fecha = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            texto = "";

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

        public void obtener_lista_sys()
        {
            lista = new Adelanto().obtener_lista();
            llenar_tabla();
            dg_adelantos.DataSource = table_activos;
            dg_adelantos.Columns["Id"].Visible = false;
            dg_adelantos.Columns["Estado"].Visible = false;
        }
        
        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_adelantos.DataSource = table_activos;
            }
            else
            {
                dg_adelantos.DataSource = table_inactvos;
            }
        }


        public Adelanto obtener()
        {
            Adelanto adelanto = new Adelanto();

            Int32 id = Int32.Parse(dg_adelantos.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Adelanto x in lista)
            {
                if (x.Id == id)
                {
                    adelanto = x;
                }
            }

            return adelanto;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_adelantos.CurrentRow.Cells["Id"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como pago el adelanto seleccionado?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Adelanto adelanto = new Adelanto();
                adelanto.Id = id;
                adelanto.Estado = false;
                if (adelanto.eliminar())
                {
                    MessageBox.Show("Adelanto pagado", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void llenar_tabla()                         
        {
            table_activos.Clear();
            table_inactvos.Clear();
            foreach (Adelanto x in lista)
            {
                if (x.Estado)
                {
                    table_activos.Rows.Add(x.Id, get_nombre(x.IdColaborador), x.Monto, x.Fecha.Date.ToShortDateString(),x.Estado);
                }
                else
                {
                    table_inactvos.Rows.Add(x.Id, get_nombre(x.IdColaborador), x.Monto, x.Fecha.Date.ToShortDateString(), x.Estado);
                }
            }
        }

        public void bajar_fila()
        {
            Int32 i = dg_adelantos.CurrentCell.RowIndex;
            if (i + 1 < dg_adelantos.Rows.Count)
            {
                dg_adelantos.Rows[i].Selected = false;
                dg_adelantos.Rows[i + 1].Selected = true;
                dg_adelantos.CurrentCell = dg_adelantos.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_adelantos.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_adelantos.Rows[i].Selected = false;
                dg_adelantos.Rows[i - 1].Selected = true;
                dg_adelantos.CurrentCell = dg_adelantos.Rows[i - 1].Cells[0];
            }
        }

        public void filtro_monto(String busqueda)
        {
            texto = busqueda;
            filtro = "(Monto Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dg_adelantos.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_inicio(DateTime date)
        {
            fecha = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Monto Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dg_adelantos.DataSource).DefaultView.RowFilter = filtro;
        }

        private void dg_adelantos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            parent.editar_adelanto();
        }
    }
}
