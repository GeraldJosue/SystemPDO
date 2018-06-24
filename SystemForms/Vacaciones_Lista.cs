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
    public partial class Vacaciones_Lista : UserControl
    {
        DataTable dt_vacaciones_activos;
        DataTable dt_vacaciones_inactivos;
        String filtro;
        String texto;
        DateTime fecha_salida;
        DateTime fecha_regreso;

        List<Vacacion> lista;
        public Vacaciones_Lista()
        {
            InitializeComponent();

            dt_vacaciones_activos = new DataTable();
            dt_vacaciones_activos.Columns.Add("Id");
            dt_vacaciones_activos.Columns.Add("Colaborador");
            dt_vacaciones_activos.Columns.Add("Fecha Salida");
            dt_vacaciones_activos.Columns.Add("Fecha Regreso");
            dt_vacaciones_activos.Columns.Add("Cantidad de días");
            dt_vacaciones_activos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_activos.Columns.Add("Transferencia");
            dt_vacaciones_activos.Columns.Add("Estado");

            dt_vacaciones_inactivos = new DataTable();
            dt_vacaciones_inactivos.Columns.Add("Id");
            dt_vacaciones_inactivos.Columns.Add("Colaborador");
            dt_vacaciones_inactivos.Columns.Add("Fecha Salida");
            dt_vacaciones_inactivos.Columns.Add("Fecha Regreso");
            dt_vacaciones_inactivos.Columns.Add("Cantidad de días");
            dt_vacaciones_inactivos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_inactivos.Columns.Add("Transferencia");
            dt_vacaciones_inactivos.Columns.Add("Estado");

            obtener_lista_sys();
            texto = "";
        }

        public void obtener_lista_sys()
        {
            lista = new Vacacion().obtener_lista();
            llenar_tabla();
            dg_vacaciones.DataSource = dt_vacaciones_activos;
            dg_vacaciones.Columns["Id"].Visible = false;
        }

        public DataTable llenar_tabla()
        {
            dt_vacaciones_activos.Clear();
            dt_vacaciones_inactivos.Clear();
            foreach (Vacacion x in lista)
            {
                if (x.Estado)
                {
                    //dt_vacaciones_activos.Rows.Add(x.Id, x.Nombre_Horario, formato_hora(x.Hora_Inicio), formato_hora(x.Hora_Fin), x.Estado ? "Activo" : "Inactivo");
                }
                else
                {
                    //dt_vacaciones_inactivos.Rows.Add(x.Id, x.Nombre_Horario, formato_hora(x.Hora_Inicio), formato_hora(x.Hora_Fin), x.Estado ? "Activo" : "Inactivo");
                }

            }
            return dt_vacaciones_activos;
        }

        private String formato_fecha(DateTime date)
        {
            return string.Format("{0:h:mm tt}", date);
        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_vacaciones.CurrentRow.Cells["Nombre"].Value.ToString();

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

    //    public Horario obtener()
    //    {
    //        Horario horario = new Horario();
    //        Int32 id = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Id"].Value.ToString());
    //        foreach (Horario x in lista)
    //        {
    //            if (x.Id == id)
    //            {
    //                horario = x;
    //            }
    //        }
    //        return horario;
    //    }

    //    public void bajar_fila()
    //    {
    //        Int32 i = dg_horarios.CurrentCell.RowIndex;
    //        if (i + 1 < dg_horarios.Rows.Count)
    //        {
    //            dg_horarios.Rows[i].Selected = false;
    //            dg_horarios.Rows[i + 1].Selected = true;
    //            dg_horarios.CurrentCell = dg_horarios.Rows[i + 1].Cells[1];
    //        }
    //    }

    //    public void subir_fila()
    //    {
    //        Int32 i = dg_horarios.CurrentCell.RowIndex;
    //        if (i - 1 >= 0)
    //        {
    //            dg_horarios.Rows[i].Selected = false;
    //            dg_horarios.Rows[i - 1].Selected = true;
    //            dg_horarios.CurrentCell = dg_horarios.Rows[i - 1].Cells[1];
    //        }
    //    }

    //    public void set_datasource(Boolean estado)
    //    {
    //        if (estado)
    //        {
    //            dg_horarios.DataSource = dt_vacaciones_activos;
    //        }
    //        else
    //        {
    //            dg_horarios.DataSource = dt_vacaciones_inactivos;
    //        }
    //    }

    //    public void filtro_nombre(String busqueda)
    //    {
    //        texto = busqueda;
    //        filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + fecha_salida.TimeOfDay + "# AND [Hora Fin] <= #" + fecha_regreso.TimeOfDay + "#)";
    //        ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
    //    }

    //    public void filtro_hora_inicio(DateTime hora)
    //    {
    //        fecha_salida = hora;
    //        filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + fecha_salida.TimeOfDay + "# AND [Hora Fin] <= #" + fecha_regreso.TimeOfDay + "#)";
    //        ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
    //    }

    //    public void filtro_hora_fin(DateTime hora)
    //    {
    //        fecha_regreso = hora;
    //        filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + fecha_salida.TimeOfDay + "# AND [Hora Fin] <= #" + fecha_regreso.TimeOfDay + "#)";
    //        ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
    //    }
    }
}

