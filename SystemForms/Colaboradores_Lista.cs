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
    public partial class Colaboradores_Lista : UserControl
    {
        List<Colaborador> lista;
        DataTable table_activos;
        DataTable table_inactivos;
        String filtro;
        String texto;
        String fecha_inicio;
        String fecha_fin;

        public Colaboradores_Lista()
        {
            InitializeComponent();
            table_activos = new DataTable();
            table_inactivos = new DataTable();

            table_activos.Columns.Add("Id");
            table_inactivos.Columns.Add("Id");

            table_activos.Columns.Add("Nombre");
            table_inactivos.Columns.Add("Nombre");

            table_activos.Columns.Add("Apellido");
            table_inactivos.Columns.Add("Apellido");

            table_activos.Columns.Add("Fecha");
            table_inactivos.Columns.Add("Fecha");

            table_activos.Columns.Add("Teléfono");
            table_inactivos.Columns.Add("Teléfono");

            table_activos.Columns.Add("Dirección");
            table_inactivos.Columns.Add("Dirección");

            table_activos.Columns.Add("Nacionalidad");
            table_inactivos.Columns.Add("Nacionalidad");

            table_activos.Columns.Add("Cuenta");
            table_inactivos.Columns.Add("Cuenta");

            table_activos.Columns.Add("Entidad");
            table_inactivos.Columns.Add("Entidad");

            table_activos.Columns.Add("Telefono Familiar");
            table_inactivos.Columns.Add("Telefono Familiar");

            obtener_lista_sys();

            
            fecha_inicio = 1 + "/" + 1 + "/" + 1900;
            fecha_fin = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            texto = "";

            
        }

        public void obtener_lista_sys()
        {
            lista = new Colaborador().obtener_lista();
            llenar_tabla();
            dg_colaboradores.DataSource = table_activos;
        }

        public void set_datasource(Boolean estado)
        {
            if(estado)
            {
                dg_colaboradores.DataSource = table_activos;
            } else
            {
                dg_colaboradores.DataSource = table_inactivos;
            }
        }

        public void filtro_nombre(String busqueda)
        {
            texto = busqueda;
            filtro = "(Nombre Like '%" + texto + "%' OR Apellido Like '%" + texto + "%') AND (Fecha >= #" + fecha_inicio + "# AND Fecha <= #" + fecha_fin + "#)";
            ((DataTable)dg_colaboradores.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_inicio(DateTime date)
        {
            fecha_inicio = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Nombre Like '%" + texto + "%' OR Apellido Like '%" + texto + "%') AND (Fecha >= #" + fecha_inicio + "# AND Fecha <= #" + fecha_fin + "#)";
            ((DataTable)dg_colaboradores.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_fin(DateTime date)
        {
            fecha_fin = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Nombre Like '%" + texto + "%' OR Apellido Like '%" + texto + "%') AND (Fecha >= #" + fecha_inicio + "# AND Fecha <= #" + fecha_fin + "#)";
            ((DataTable)dg_colaboradores.DataSource).DefaultView.RowFilter = filtro;
        }

        public Colaborador obtener()
        {
            Colaborador colaborador = new Colaborador();

            Int32 id = Int32.Parse(dg_colaboradores.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Colaborador x in lista)
            {
                if(x.Id == id)
                {
                    colaborador = x;
                }
            }
            
            return colaborador;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_colaboradores.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_colaboradores.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo al colaborador " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Colaborador colaborador = new Colaborador();
                colaborador.Id = id;
                colaborador.Estado = false;
                if(colaborador.eliminar())
                {
                     MessageBox.Show("Colaborador inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            table_inactivos.Clear();
            foreach(Colaborador x in lista)
            {
                if (x.Estado)
                {
                    table_activos.Rows.Add(x.Id, x.Nombre, x.Apellido, x.Fecha.Date.ToShortDateString(), x.Telefono, x.Direccion, x.Nacionalidad, x.Cuenta, x.Entidad, x.FTelefono);
                }
                else
                {
                    table_inactivos.Rows.Add(x.Id, x.Nombre, x.Apellido, x.Fecha.Date.ToShortDateString(), x.Telefono, x.Direccion, x.Nacionalidad, x.Cuenta, x.Entidad, x.FTelefono);
                }
            }
        }

        public void bajar_fila()
        {
            Int32 i = dg_colaboradores.CurrentCell.RowIndex;
            if (i+1 < dg_colaboradores.Rows.Count) {
                dg_colaboradores.Rows[i].Selected = false;
                dg_colaboradores.Rows[i + 1].Selected = true;
                dg_colaboradores.CurrentCell = dg_colaboradores.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_colaboradores.CurrentCell.RowIndex;
            if (i-1 >= 0) {
                dg_colaboradores.Rows[i].Selected = false;
                dg_colaboradores.Rows[i - 1].Selected = true;
                dg_colaboradores.CurrentCell = dg_colaboradores.Rows[i - 1].Cells[0];
            }
        }
    }
}
