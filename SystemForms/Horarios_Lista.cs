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
    public partial class Horarios_Lista : UserControl
    {
        DataTable dt_horarios_activos;
        DataTable dt_horarios_inactivos;
        String filtro;
        String texto;
        DateTime hora_inicio;
        DateTime hora_fin;

        List<Horario> lista;

        public Horarios_Lista()
        {
            InitializeComponent();
            dt_horarios_activos = new DataTable();
            dt_horarios_activos.Columns.Add("Id");
            dt_horarios_activos.Columns.Add("Nombre");
            dt_horarios_activos.Columns.Add("Hora Inicio");
            dt_horarios_activos.Columns.Add("Hora Fin");
            dt_horarios_activos.Columns.Add("Estado");
                 
            dt_horarios_inactivos = new DataTable();
            dt_horarios_inactivos.Columns.Add("Id");
            dt_horarios_inactivos.Columns.Add("Nombre");
            dt_horarios_inactivos.Columns.Add("Hora Inicio");
            dt_horarios_inactivos.Columns.Add("Hora Fin");
            dt_horarios_inactivos.Columns.Add("Estado");

            obtener_lista_sys();
            texto = "";
        }

        public void obtener_lista_sys()
        {
            lista = new Horario().obtener_lista();
            llenar_tabla();
            dg_horarios.DataSource = dt_horarios_activos;
            dg_horarios.Columns["Id"].Visible = false;
        }

        public DataTable llenar_tabla()
        {
            dt_horarios_activos.Clear();
            dt_horarios_inactivos.Clear();
            foreach (Horario x in lista)
            {
                if(x.Estado)
                {
                    dt_horarios_activos.Rows.Add(x.Id, x.Nombre_Horario, formato_hora(x.Hora_Inicio), formato_hora(x.Hora_Fin), x.Estado ? "Activo" : "Inactivo");
                } else
                {
                    dt_horarios_inactivos.Rows.Add(x.Id, x.Nombre_Horario, formato_hora(x.Hora_Inicio), formato_hora(x.Hora_Fin), x.Estado ? "Activo" : "Inactivo");
                }
                
            }
            return dt_horarios_activos;
        }

        private String formato_hora(DateTime date)
        {
            return string.Format("{0:h:mm tt}", date);
        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_horarios.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_horarios.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo el horario " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Horario horario = new Horario();
                horario.Id = id;
                horario.Estado = false;
                if (horario.eliminar())
                {
                    MessageBox.Show("Horario inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Horario obtener()
        {
            Horario horario = new Horario();
            Int32 id = Int32.Parse(dg_horarios.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Horario x in lista)
            {
                if (x.Id == id)
                {
                    horario = x;
                }
            }
            return horario;
        }

        public void bajar_fila()
        {
            Int32 i = dg_horarios.CurrentCell.RowIndex;
            if (i + 1 < dg_horarios.Rows.Count)
            {
                dg_horarios.Rows[i].Selected = false;
                dg_horarios.Rows[i + 1].Selected = true;
                dg_horarios.CurrentCell = dg_horarios.Rows[i + 1].Cells[1];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_horarios.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_horarios.Rows[i].Selected = false;
                dg_horarios.Rows[i - 1].Selected = true;
                dg_horarios.CurrentCell = dg_horarios.Rows[i - 1].Cells[1];
            }
        }

        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_horarios.DataSource = dt_horarios_activos;
            }
            else
            {
                dg_horarios.DataSource = dt_horarios_inactivos;
            }
        }

        public void filtro_nombre(String busqueda)
        {
            texto = busqueda;
            filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + hora_inicio.TimeOfDay + "# AND [Hora Fin] <= #" + hora_fin.TimeOfDay + "#)";
            ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_hora_inicio(DateTime hora)
        {
            hora_inicio = hora;
            filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + hora_inicio.TimeOfDay + "# AND [Hora Fin] <= #" + hora_fin.TimeOfDay + "#)";
            ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_hora_fin(DateTime hora)
        {
            hora_fin = hora;
            filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + hora_inicio.TimeOfDay + "# AND [Hora Fin] <= #" + hora_fin.TimeOfDay + "#)";
            ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
        }
    }
}
